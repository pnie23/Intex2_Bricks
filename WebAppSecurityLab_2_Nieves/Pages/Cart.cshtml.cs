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

        public IActionResult OnPost(int productId, string returnUrl)
        {
            Product p = _repo.Products
                .FirstOrDefault(x => x.product_Id == productId);

            if (p != null)
            {
                Cart.AddItem(p, 1);
            }

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long productId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(x => x.Product.product_Id == productId).Product);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
