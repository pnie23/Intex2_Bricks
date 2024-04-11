//using Intex2_Bricks.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace Intex2_Bricks.Components
//{
//    public class ProductColorViewComponent
//    {
//        private IBricksRepository _repo;
//        public ProductColorViewComponent(IBricksRepository temp)
//        {
//            _repo = temp;
//        }

//        public IViewComponentResult Invoke()
//        {
//            ViewBag.SelectedProductPrimaryColor = RouteData?.Values["productPrimaryColor"];

//            var productPrimaryColor = _repo.Products
//                .Select(x => x.category)
//                .Distinct()
//                .OrderBy(x => x);

//            return View(productPrimaryColor);
//        }
//    }
//}
