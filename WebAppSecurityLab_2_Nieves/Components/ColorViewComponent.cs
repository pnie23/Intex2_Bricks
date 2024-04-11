using Intex2_Bricks.Models;
using Microsoft.AspNetCore.Mvc;
namespace Intex2_Bricks.Components
{
    public class ColorViewComponent : ViewComponent
    {
        private IBricksRepository _repo;
        public ColorViewComponent(IBricksRepository temp)
        {
            _repo = temp;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["primary_color"];
            return View(_repo.Products.Select(x => x.primary_color).Distinct().OrderBy(x => x));
        }
    }
}