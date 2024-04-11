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


        public IActionResult Index(string? category, int productPage = 1, int pageSize = 5)
        {
            var list = new ProductsListViewModel
            {
                Products = _repo.Products.Where(p => category == null || p.category == category).OrderBy(p => p.product_Id).Skip((productPage - 1) * pageSize).Take(pageSize),
                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = pageSize,
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

        public IActionResult Product_Detail(int id, string product_name, string image_link, int price, string description)
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

            //var viewModel = new IBRecommendationViewModel
            //{
            //    Product = product,
            //    IBRecommendations = GetRecommendedProducts(id)
            //};

            return View(/*viewModel*/); // Ensure that you are passing viewModel of type IBRecommendationViewModel
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
        [Authorize(Policy = "Admin")]
        public IActionResult AdminOrders(OrdersListViewModel ordersListViewModel)
        {
            var records = _repo.Orders
                .OrderByDescending(o => o.date)
                .Take(20)
                .ToList();
            var orders = new List<Order>();
            var predictions = new List<OrdersListViewModel>();

            var class_type_dict = new Dictionary<int, string>
    {
        {0, "Not Fraud" },
        {1, "Fraud" }
    };

            foreach (var record in records)
            {
                // preprocess features to make them compatible with the model
                var input = new List<float>
        {
            (float)record.time,
            // fix amount if it's null
            (float)(record.amount ?? 0),

            // check the dummy coded data
            record.day_of_week == "Mon" ? 1:0,
            record.day_of_week == "Sat" ? 1:0,
            record.day_of_week == "Sun" ? 1:0,
            record.day_of_week == "Thu" ? 1:0,
            record.day_of_week == "Tue" ? 1:0,
            record.day_of_week == "Wed" ? 1:0,

            record.country_of_transaction == "India" ? 1:0,
            record.country_of_transaction == "Russia" ? 1:0,
            record.country_of_transaction == "USA" ? 1:0,
            record.country_of_transaction == "UnitedKingdom" ? 1:0,

            record.shipping_address == "India" ? 1:0,
            record.shipping_address == "Russia" ? 1:0,
            record.shipping_address == "USA" ? 1:0,
            record.shipping_address == "UnitedKingdom" ? 1:0,

            record.bank == "HSBC" ? 1:0,
            record.bank == "Halifax" ? 1:0,
            record.bank == "Lloyds" ? 1:0,
            record.bank == "Metro" ? 1:0,
            record.bank == "Monzo" ? 1:0,
            record.bank == "RBS" ? 1:0,

            record.type_of_card == "Visa" ? 1:0
        };

                var inputTensor = new DenseTensor<float>(input.ToArray(), new[] { 1, input.Count });
                var inputs = new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", inputTensor)
            };

                string predictionResult;
                using (var results = _session.Run(inputs))
                {
                    var prediction = results.FirstOrDefault(item => item.Name == "output_label")?.AsTensor<long>().ToArray();
                    predictionResult = prediction != null && prediction.Length > 0 ? class_type_dict.GetValueOrDefault((int)prediction[0], "Unknown") : "Error in prediction";
                }
                predictions.Add(new OrdersListViewModel { Orders = (IQueryable<Order>)record, predictionResult = predictionResult });
            }
            return View(predictions);
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
        public IActionResult EditProduct(Product updatedInfo)
        {
            _repo.Update(updatedInfo);

            return RedirectToAction("EditProduct");
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
            _repo.Delete(deletedInfo);

            return RedirectToAction("DeleteProduct");
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
