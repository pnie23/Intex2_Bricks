using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Intex2_Bricks.Data;
using Intex2_Bricks.Models;

namespace Intex2_Bricks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var services = builder.Services;
            var configuration = builder.Configuration;

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("BricksConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(connectionString)); //MAKE SURE THIS WORKS PROPERLY

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            //SET AUTHENTICATION
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

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            //app.MapControllerRoute("pagenumandtype", "{projectType}/{pageNum}", new { Controller = "Home", action = "Index" });
            //app.MapControllerRoute("pagination", "{pageNum}", new { Controller = "Home", action = "Index", pageNum = 1 });
            //app.MapControllerRoute("productCategory", "{productCateogry}", new { Controller = "Home", action = "Index", pageNum = 1 });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapDefaultControllerRoute();
            app.MapRazorPages();

            app.Run();
        }
    }
}
