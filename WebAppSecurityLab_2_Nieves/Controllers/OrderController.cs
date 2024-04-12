using Microsoft.AspNetCore.Mvc;
using Intex2_Bricks.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.ML.OnnxRuntime.Tensors;
using Microsoft.ML.OnnxRuntime;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
namespace Intex2_Bricks.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;
        private int transactionIdCounter = 801765; // Initialize the transactionIdCounter
        private readonly InferenceSession _session;
        private readonly string _onnxModelPath;
        public OrderController(IOrderRepository repoService, Cart cartService, IHostEnvironment hostEnvironment)
        {
            repository = repoService;
            cart = cartService;
            _onnxModelPath = System.IO.Path.Combine(hostEnvironment.ContentRootPath, "fraud.onnx");
            _session = new InferenceSession(_onnxModelPath);
        }
        public ViewResult Checkout() => View(new Order());
        [Authorize]
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var input = new List<float>
      {
        (float)order.time,
        // fix amount if it's null
        (float)(order.amount ?? 0),
        // check the dummy coded data
        order.day_of_week == "Mon" ? 1:0,
        order.day_of_week == "Sat" ? 1:0,
        order.day_of_week == "Sun" ? 1:0,
        order.day_of_week == "Thu" ? 1:0,
        order.day_of_week == "Tue" ? 1:0,
        order.day_of_week == "Wed" ? 1:0,
        order.country_of_transaction == "India" ? 1:0,
        order.country_of_transaction == "Russia" ? 1:0,
        order.country_of_transaction == "USA" ? 1:0,
        order.country_of_transaction == "UnitedKingdom" ? 1:0,
        order.shipping_address == "India" ? 1:0,
        order.shipping_address == "Russia" ? 1:0,
        order.shipping_address == "USA" ? 1:0,
        order.shipping_address == "UnitedKingdom" ? 1:0,
        order.bank == "HSBC" ? 1:0,
        order.bank == "Halifax" ? 1:0,
        order.bank == "Lloyds" ? 1:0,
        order.bank == "Metro" ? 1:0,
        order.bank == "Monzo" ? 1:0,
        order.bank == "RBS" ? 1:0,
        order.type_of_card == "Visa" ? 1:0
      };
            var inputTensor = new DenseTensor<float>(input.ToArray(), new[] { 1, input.Count });
            var inputs = new List<NamedOnnxValue>
      {
        NamedOnnxValue.CreateFromTensor("float_input", inputTensor)
      };
            var view = "Completed"; // Default view name
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                using (var results = _session.Run(inputs))
                {
                    var prediction = results.FirstOrDefault(item => item.Name == "output_label")?.AsTensor<long>().ToArray();
                    if (prediction != null)
                    {
                        var fraudPrediction = (int)prediction[0];
                        if (fraudPrediction == 0)
                        {
                            view = "/Completed";
                            order.fraud = 0;
                        }
                        else
                        {
                            view = "/FraudConfirmation";
                            order.fraud = 1;
                        }
                    }
                    else
                    {
                        order.fraud = 0;
                    }
                    order.customer_Id = 57;
                    // Assign the current value of the counter to transaction_id
                    order.transaction_Id = transactionIdCounter;
                    // Increment the counter for the next transaction
                    transactionIdCounter++;
                    repository.SaveOrder(order);
                    cart.Clear();
                }
                // Redirect to the appropriate view based on the fraud prediction
                return RedirectToPage(view);
            }
            else
            {
                // Return to the Checkout view with validation errors
                return View(order);
            }
        }
    }
}