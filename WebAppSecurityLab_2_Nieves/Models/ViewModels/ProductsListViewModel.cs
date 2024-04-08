namespace Intex2_Bricks.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IQueryable<Products> Products { get; set;}

        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();

        public string? Category { get; set;}
    }
}
