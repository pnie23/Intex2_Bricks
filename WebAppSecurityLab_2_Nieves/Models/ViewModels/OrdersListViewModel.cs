namespace Intex2_Bricks.Models.ViewModels
{
    public class OrdersListViewModel
    {
        public IQueryable<Order> Orders { get; set; }

        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();
        public string predictionResult { get; internal set; }
    }
}
