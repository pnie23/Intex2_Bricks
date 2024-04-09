using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Intex2_Bricks.Models;
using NuGet.ProjectModel;
using Intex2_Bricks.Models.ViewModels;
using System.Drawing.Printing;

namespace Intex2_Bricks.Controllers
{
    public class HomeController : Controller
    {
        private IBricksRepository _repo;

        public HomeController(IBricksRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index(int pageNum, string? productCategory)
        {
            int pageSize = 5; //, 10, or 20; // FIX ME

            var list = new ProductsListViewModel // FIX ME
            {
                Products = _repo.Products
                .Where(x => x.category == productCategory || productCategory == null)
                .OrderBy(x => x.name)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = productCategory == null ? _repo.Products.Count() : _repo.Products.Where(x => x.category == productCategory).Count()
                },

                CurrentProductCategory = productCategory
            };
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult AdminDashboard()
        {
            var list = new OrdersListViewModel
            {
                Orders = _repo.Orders
                            .Where(x => !x.fulfilled)
                            .OrderBy(x => x.date)
            };
            return View(list);
        }


    }
}
