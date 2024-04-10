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

        public IActionResult PurchaseSuccessfulConfirmation()
        {
            return View();
        }

        public IActionResult FraudConfirmation()
        {
            return View();
        }

        public ActionResult Product_Detail(int id, string product_name, string image_link, int price, string description)
        {
            var product = new Product
            {
                product_Id = id,
                name = product_name,
                img_link = image_link,
                price = price,
                description = description
            };

            ViewBag.Product = product;

            return View("Product_Detail");
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

        public IActionResult AdminCustomers()
        {
            var list = new CustomersListViewModel
            {
                Customers = _repo.Customers
            };
            return View(list);
        }

        public IActionResult AdminOrders()
        {
            var list = new OrdersListViewModel
            {
                Orders = _repo.Orders
                    .OrderBy(x => x.date)
            };
            return View(list);
        }

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

        public IActionResult AddProduct()
        {
            return View();
        }
        public IActionResult EditProduct()
        {
            return View();
        }

        public IActionResult EditCustomer()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            var recordToEdit = _repo.Products
                .Single(x => x.product_Id == id);
            return View("EditProduct", recordToEdit);
        }
        [HttpPost]
        public IActionResult EditProduct(Product updatedInfo)
        {
            _repo.Update(updatedInfo);

            return RedirectToAction("EditProduct");
        }

        [HttpGet]
        public IActionResult EditCust(int id)
        {

            var recordToEdit = _repo.Customers
                .Single(x => x.customer_Id == id);
            return View("EditCustomer", recordToEdit);
        }
        [HttpPost]
        public IActionResult EditCustomer(Customer updatedInfo)
        {
            _repo.Update(updatedInfo);

            return RedirectToAction("EditCustomer");
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            var recordToDelete = _repo.Products
                .Single(x => x.product_Id == id);
            return View("DeleteProduct", recordToDelete);
        }
        [HttpPost]
        public IActionResult DeleteProduct(Product deletedInfo)
        {
            _repo.Delete(deletedInfo);

            return RedirectToAction("DeleteProduct");
        }

        [HttpGet]
        public IActionResult DeleteCustomer(int id)
        {
            var recordToDelete = _repo.Customers
                .Single(x => x.customer_Id == id);
            return View("DeleteCustomer", recordToDelete);
        }
        [HttpPost]
        public IActionResult DeleteCustomer(Customer deletedInfo)
        {
            _repo.Delete(deletedInfo);

            return RedirectToAction("DeleteCustomer");
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _repo.AddProduct(product);
            return RedirectToAction("AddProduct"); // Redirect to the home page or another appropriate action
        }

    }
}
