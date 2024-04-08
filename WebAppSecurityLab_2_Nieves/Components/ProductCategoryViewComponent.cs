using Microsoft.AspNetCore.Mvc;
using Intex2_Bricks.Models;

namespace Intex2_Bricks.Components
{
    public class ProductCategoryViewComponent : ViewComponent
    {
        private IBricksRepository _bricksRepo;
        public ProductCategoryViewComponent(IBricksRepository temp)
        {
            _bricksRepo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedProductCategories = RouteData?.Values["productCategories"];

            var productCategories = _bricksRepo.Products
                .Select(x => x.ProductCategories)
                .Distinct()
                .OrderBy(x => x);

            return View(productCategories);
        }
    }
}
