namespace Intex2_Bricks.Models.ViewModels
{
    public class OrdersListViewModel
    {
        internal string predictionResult;

        public IQueryable<Order> Orders { get; set; }

        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();

    }
}
