using Microsoft.AspNetCore.Mvc;
using Intex2_Bricks.Models;

namespace Intex2_Bricks.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBricksRepository _repo;

        public NavigationMenuViewComponent(IBricksRepository temp)
        {
            _repo = temp;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(_repo.Products.Select(x => x.category).Distinct().OrderBy(x => x));
        }
    }
}
