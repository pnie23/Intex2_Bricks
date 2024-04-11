namespace Intex2_Bricks.Models.ViewModels
{
    public class IBRecommendationViewModel
    {
        public IQueryable<Product> Products { get; set; }
        public PaginationInfo PaginationInfo { get; set; }
        public IQueryable<IBRecommendation> IBRecommendations { get; set; }
        public Product Product { get; internal set; }
    }
}
