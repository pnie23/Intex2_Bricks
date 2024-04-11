namespace Intex2_Bricks.Models.ViewModels
{
    public class ProductRecommendationViewModel
    {
        public IQueryable<Product> Products { get; set; }
        public IQueryable<IBRecommendation> IBRecommendations { get; set; }
    }
}
