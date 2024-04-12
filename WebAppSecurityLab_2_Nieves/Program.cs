using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Intex2_Bricks.Data;
using Intex2_Bricks.Models;
using Intex2_Bricks.Controllers;

namespace Intex2_Bricks
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var services = builder.Services;
            var configuration = builder.Configuration;

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("BricksConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(connectionString)); //MAKE SURE THIS WORKS PROPERLY

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            //SET Third-Party AUTHENTICATION
            //services.AddAuthentication().AddGoogle(googleOptions =>
            //{
            //    googleOptions.ClientId = configuration["Authentication:Google:ClientId"];
            //    googleOptions.ClientSecret = configuration["Authentication:Google:ClientSecret"];
            //});

            //SET DBCONTEXT
            builder.Services.AddDbContext<BricksContext>(options =>
            {
                options.UseSqlite(builder.Configuration["ConnectionStrings:BricksConnection"]);
            });

            builder.Services.AddScoped<IBricksRepository, EFBricksRepository>();
            builder.Services.AddScoped<IOrderRepository, EFOrderRepository>();
            services.AddScoped<IBRecommendation, IBRecommendation>();

            builder.Services.AddRazorPages();

            builder.Services.AddControllersWithViews();

            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession();

            builder.Services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            builder.Services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential 
                // cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
                options.ConsentCookieValue = "true";
            });

            builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders()
                .AddDefaultUI();

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy => policy.RequireRole("Admin"));
                options.AddPolicy("Member", policy => policy.RequireRole("Member"));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute("catpage",
                "{category}/Page{productPage:int}",
                new { Controller = "Home", action = "Index" });

            app.MapControllerRoute("page", "Page{productPage:int}",
                new { Controller = "Home", action = "Index", productPage = 1 });

            app.MapControllerRoute("category", "{category}",
                new { Controller = "Home", action = "Index", productPage = 1 });

            app.MapControllerRoute("primary_color", "{primary_color}",
                new { Controller = "Home", action = "Index", productPage = 1 });

            app.MapControllerRoute("pagination",
                "Products/Page{productPage}",
                new { Controller = "Home", action = "Index", productPage = 1 });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapDefaultControllerRoute();
            app.MapRazorPages();

            app.Run();
        }
    }
}
