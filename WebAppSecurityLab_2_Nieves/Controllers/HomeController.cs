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

        public IActionResult About_Us()
        {
            return View();
        }


        //[Authorize]
        //public IActionResult AdminDashboard()
        //{
        //    if (User.IsInRole("Admin"))
        //    {
        //        return View("AdminDashboard", "_AdminLayout");
        //    }
        //    else
        //    {
        //        return RedirectToAction("AccessDenied", "Account");
        //    }

        //    var list = new OrdersListViewModel // FIX ME
        //    {
        //        Orders = _repo.Orders
        //                    .Where(x => x.fulfilled is 0)
        //                    .OrderBy(x => x.date)
        //                    .Skip((pageNum - 1) * pageSize)
        //                    .Take(pageSize),
        //        PaginationInfo = new PaginationInfo
        //        {
        //            CurrentPage = pageNum,
        //            ItemsPerPage = pageSize,
        //            TotalItems = productCategory == null ? _repo.Products.Count() : _repo.Products.Where(x => x.Category == productCategory).Count()
        //        },
        //    };
        //    return View(list);
        //}

        //[Authorize]
        //public IActionResult AdminOrders()
        //{
        //    if (User.IsInRole("Admin"))
        //    {
        //        return View("AdminOrders", "_AdminLayout");
        //    }
        //    else
        //    {
        //        return RedirectToAction("AccessDenied", "Account");
        //    }

        //    var list = new OrdersListViewModel // FIX ME
        //    {
        //        Orders = _repo.Orders
        //                    .Where(x => x)
        //                    .OrderBy(x => x.date)
        //                    .Skip((pageNum - 1) * pageSize)
        //                    .Take(pageSize),
        //        PaginationInfo = new PaginationInfo
        //        {
        //            CurrentPage = pageNum,
        //            ItemsPerPage = pageSize,
        //            TotalItems = productCategory == null ? _repo.Products.Count() : _repo.Products.Where(x => x.Category == productCategory).Count()
        //        },
        //    };
        //    return View(list);
        //}

        //[Authorize]
        //public IActionResult AdminProducts()
        //{
        //    if (User.IsInRole("Admin"))
        //    {
        //        return View("AdminProducts", "_AdminLayout");
        //    }
        //    else
        //    {
        //        return RedirectToAction("AccessDenied", "Account");
        //    }

        //    var list = new ProductsListViewModel // FIX ME
        //    {
        //        Products = _repo.Products
        //                    .Where(x => x)
        //                    .OrderBy(x => x.name)
        //                    .Skip((pageNum - 1) * pageSize)
        //                    .Take(pageSize),
        //        PaginationInfo = new PaginationInfo
        //        {
        //            CurrentPage = pageNum,
        //            ItemsPerPage = pageSize,
        //            TotalItems = productCategory == null ? _repo.Products.Count() : _repo.Products.Where(x => x.Category == productCategory).Count()
        //        },
        //    };
        //    return View(list);
        //}

        //[Authorize]
        //public IActionResult AdminUsers()
        //{
        //    if (User.IsInRole("Admin"))
        //    {
        //        return View("AdminUsers", "_AdminLayout");
        //    }
        //    else
        //    {
        //        return RedirectToAction("AccessDenied", "Account");
        //    }

        //    var list = new CustomersListViewModel // FIX ME
        //    {
        //        Customers = _repo.Customers
        //                    .Where(x => x)
        //                    .OrderBy(x => x.name)
        //                    .Skip((pageNum - 1) * pageSize)
        //                    .Take(pageSize),
        //        PaginationInfo = new PaginationInfo
        //        {
        //            CurrentPage = pageNum,
        //            ItemsPerPage = pageSize,
        //            TotalItems = productCategory == null ? _repo.Products.Count() : _repo.Products.Where(x => x.Category == productCategory).Count()
        //        },
        //    };
        //    return View(list);
        //}

    }
}
