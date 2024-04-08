using Microsoft.AspNetCore.Mvc;
using Intex2_Bricks.Models;

namespace TheWaterProject.Components
{
    public class ProductCategoryViewComponent : ViewComponent
    {
        private IWaterRepository _waterRepo;
        public ProductCategoryViewComponent(IWaterRepository temp)
        {
            _waterRepo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedProjectType = RouteData?.Values["projectType"];

            var projectTypes = _waterRepo.Projects
                .Select(x => x.ProjectType)
                .Distinct()
                .OrderBy(x => x);

            return View(projectTypes);
        }
    }
}
