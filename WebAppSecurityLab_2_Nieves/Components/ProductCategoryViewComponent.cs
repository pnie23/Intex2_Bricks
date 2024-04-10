using Microsoft.AspNetCore.Mvc;
using Intex2_Bricks.Models;

namespace Intex2_Bricks.Components
{
    public class ProductCategoryViewComponent : ViewComponent
    {
        private IBricksRepository _repo;
        public ProductCategoryViewComponent(IBricksRepository temp)
        {
            _repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedProductCategory = RouteData?.Values["productCategory"];

            var productCategory = _repo.Products
                .Select(x => x.category)
                .Distinct()
                .OrderBy(x => x);

            return View(productCategory);
        }
    }
}
