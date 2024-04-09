namespace Intex2_Bricks.Models.ViewModels
{
    public class CustomersListViewModel
    {
        public IQueryable<Customer> Customers { get; set; }

        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();

        public string? Category { get; set; }
    }
}
