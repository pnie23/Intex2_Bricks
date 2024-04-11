namespace Intex2_Bricks.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IQueryable<Product> Products { get; set;}

        public PaginationInfo PaginationInfo { get; set;} = new();

        public string? CurrentCategory { get; set;}
        public string? SelectedPrimaryColor { get; set;}
    }
}
