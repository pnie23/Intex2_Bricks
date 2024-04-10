using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Intex2_Bricks.Models;
using NuGet.ProjectModel;
using Intex2_Bricks.Models.ViewModels;
using System.Drawing.Printing;
using Microsoft.EntityFrameworkCore;

namespace Intex2_Bricks.Controllers
{
    public class HomeController : Controller
    {
        private IBricksRepository _repo;

        public HomeController(IBricksRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index(string? category, int productPage = 1)
        {
            int PageSize = 5; //, 10, or 20; // FIX ME
            var list = new ProductsListViewModel
            {
                Products = _repo.Products.Where(p => category == null || p.category == category).OrderBy(p => p.product_Id).Skip((productPage - 1) * PageSize).Take(PageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ? _repo.Products.Count() : _repo.Products.Where(e => e.category == category).Count()
                },
                CurrentCategory = category
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

        public IActionResult PurchaseSuccessfulConfirmation()
        {
            return View();
        }

        public IActionResult FraudConfirmation()
        {
            return View();
        }

        public ActionResult Product_Detail(int id)
        {
            ViewData["id"] = id;

            return View("Product_Detail");
        }

        public IActionResult EditProduct()
        {
            return View();
        }

        //[Authorize]
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

        //[Authorize]
        public IActionResult AdminCustomers()
        {
            var list = new CustomersListViewModel
            {
                Customers = _repo.Customers
            };
            return View(list);
        }

        //[Authorize]
        public IActionResult AdminOrders()
        {
            var list = new OrdersListViewModel
            {
                Orders = _repo.Orders
                    .OrderBy(x => x.date)
            };
            return View(list);
        }

        //[Authorize]
        [HttpGet]
        public IActionResult AdminProducts(int pageNum)
        {
            int pageSize = 5; //, 10, or 20; // FIX ME

            var list = new ProductsListViewModel
            {
                Products = _repo.Products
                .OrderBy(x => x.name)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Products.Count()
                }
            }; return View(list);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _repo.Products
                .Single(x => x.product_Id == id);
            return View("EditProduct", recordToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Product updatedInfo)
        {
            _repo.Update(updatedInfo);

            return RedirectToAction("EditProduct");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _repo.Products
                .Single(x => x.product_Id == id);
            return View(recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(ProductsListViewModel product)
        {
            return RedirectToAction("AdminProducts");
        }

    }
}
