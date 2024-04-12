using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Intex2_Bricks.Models;
using NuGet.ProjectModel;
using Intex2_Bricks.Models.ViewModels;
using System.Drawing.Printing;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using Microsoft.Build.Framework;
using Microsoft.Extensions.Logging;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace Intex2_Bricks.Controllers
{
    public class HomeController : Controller
    {
        private IBricksRepository _repo;
        private IEnumerable<Order> OrdersListViewModel;
        private readonly InferenceSession _session;
        private readonly string _onnxModelPath;
        private readonly IBRecommendation _productRecommendationService;

        public HomeController(IBricksRepository temp, IHostEnvironment hostEnvironment, IBRecommendation productRecommendationService)
        {
            _repo = temp;

            _onnxModelPath = System.IO.Path.Combine(hostEnvironment.ContentRootPath, "fraud.onnx"); System.IO.Path.Combine(hostEnvironment.ContentRootPath, "fraud.onnx");
            _session = new InferenceSession(_onnxModelPath);
            _productRecommendationService = productRecommendationService;
        }

        public IActionResult Index()
        {
            var list = new ProductsListViewModel
            {
                Products = _repo.Products
                    .Where(x => new[] {27, 33, 34, 37 }.Contains(x.product_Id))
            };
            return View(list);
        }
        public IActionResult Shop(string? category, string? primary_color, int productPage = 1, int pageSize = 5)
        {
            var list = new ProductsListViewModel
            {
                Products = _repo.Products.Where(p => (category == null || p.category == category) && (primary_color == null || p.primary_color == primary_color))
                     .OrderBy(p => p.product_Id)
                     .Skip((productPage - 1) * pageSize)
                     .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = pageSize,
                    TotalItems = (category == null ? _repo.Products.Count() : _repo.Products.Count(p => p.category == category)) +
                               (primary_color == null ? 0 : _repo.Products.Count(p => p.primary_color == primary_color))
                },
                CurrentCategory = category,
                SelectedPrimaryColor = primary_color
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

        public IActionResult Product_Detail(int id)
        {
            

            var product = _repo.Products
                .FirstOrDefault(x => x.product_Id == id);

            ViewBag.Product = product;


            IBRecommendation rec = _repo.IBRecommendations
                .Where(x => x.original_product_ID == id).First();
            


            int[] recommendationIds = new[]
            {
                rec.Recommended_Product_1_ID,
                rec.Recommended_Product_2_ID,
                rec.Recommended_Product_3_ID,
                rec.Recommended_Product_4_ID
            };
                


            List<Product> recommendationProducts = _repo.Products
                .Where(x => recommendationIds.Contains(x.product_Id))
                .ToList();

            ViewBag.Recommendations = recommendationProducts;

            return View();
        }


        public IActionResult EditProduct()
        {
            return View();
        }

        [Authorize(Policy = "Admin")]
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

        [Authorize(Policy = "Admin")]
        public IActionResult AdminCustomers()
        {
            var list = new CustomersListViewModel
            {
                Customers = _repo.Customers
            };
            return View(list);
        }

        [Authorize(Policy = "Admin")]
        public IActionResult AdminOrders()
        {
            var list = new OrdersListViewModel
            {
                Orders = _repo.Orders
                    .OrderBy(x => x.fulfilled)
            };
            return View(list);
        }


        [Authorize(Policy = "Admin")]
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

        [Authorize(Policy = "Admin")]
        public IActionResult AddProduct()
        {
            return View();
        }

        [Authorize(Policy = "Admin")]
        [HttpGet]
        public IActionResult EditCustomer()
        {
            return View();
        }

        [Authorize(Policy = "Admin")]
        [HttpGet]
        public IActionResult Edit(int id)
        {

            var recordToEdit = _repo.Products
                .Single(x => x.product_Id == id);
            return View("EditProduct", recordToEdit);
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]

        // public IActionResult EditProduct(Product updatedInfo)
        public IActionResult Edit(Product updatedInfo)
        {
            _repo.Update(updatedInfo);

            // return RedirectToAction("EditProduct");
            return RedirectToAction("AdminProducts");
        }

        [Authorize(Policy = "Admin")]
        [HttpGet]
        public IActionResult EditCust(int id)
        {

            var recordToEdit = _repo.Customers
                .Single(x => x.customer_Id == id);
            return View("EditCustomer", recordToEdit);
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        public IActionResult EditCustomer(Customer updatedInfo)
        {
            _repo.Update(updatedInfo);

            return RedirectToAction("EditCustomer");
        }

        [Authorize(Policy = "Admin")]
        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            var recordToDelete = _repo.Products
              .Single(x => x.product_Id == id);
            return View("DeleteProduct", recordToDelete);
        }
        [Authorize(Policy = "Admin")]
        [HttpPost]
        public IActionResult DeleteProduct(Product deletedInfo)
        {
            var productToDelete = _repo.Products
              .SingleOrDefault(x => x.product_Id == deletedInfo.product_Id);
            if (productToDelete == null)
            {
                // Product not found, handle the error (e.g., show an error message)
                return RedirectToAction("Index", "Home"); // Redirect to a suitable action
            }
            _repo.Delete(productToDelete); // Assuming _repo.Delete method removes the product from the database
            return RedirectToAction("Index", "Home"); // Redirect to a suitable action after deletion
        }

        [Authorize(Policy = "Admin")]
        [HttpGet]
        public IActionResult DeleteCustomer(int id)
        {
            var recordToDelete = _repo.Customers
                .Single(x => x.customer_Id == id);
            return View("DeleteCustomer", recordToDelete);
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        public IActionResult DeleteCustomer(Customer deletedInfo)
        {
            _repo.Delete(deletedInfo);

            return RedirectToAction("DeleteCustomer");
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _repo.AddProduct(product);
            return RedirectToAction("AddProduct"); // Redirect to the home page or another appropriate action
        }

    }
}
