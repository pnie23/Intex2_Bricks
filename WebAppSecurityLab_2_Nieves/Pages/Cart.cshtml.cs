using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Intex2_Bricks.Infrastructure;
using Intex2_Bricks.Models;

namespace Intex2_Bricks.Pages
{
    public class CartModel : PageModel
    {
        public IBricksRepository _repo;

        public CartModel(IBricksRepository temp, Cart cartService)
        {
            _repo = temp;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; } = "/";

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(int product_Id, string returnUrl)
        {
            Product product = _repo.Products.FirstOrDefault(p => p.product_Id == product_Id);

            if (product != null)
            {
                Cart.AddItem(product, 1);
            }

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int product_Id, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(x => x.Product.product_Id == product_Id).Product);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
