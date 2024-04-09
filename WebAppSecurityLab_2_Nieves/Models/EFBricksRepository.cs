namespace Intex2_Bricks.Models
{
    public class EFBricksRepository : IBricksRepository
    {
        private BricksContext _context;

        public EFBricksRepository(BricksContext temp)
        {
            _context = temp;
        }
        public IQueryable<Product> Products => _context.Products;
        public IQueryable<Customer> Customers => _context.Customers;
        public IQueryable<LineItem> LineItems => _context.LineItems;
        public IQueryable<Order> Orders => _context.Orders;
        public IQueryable<IBRecommendation> IBRecommendations => _context.IBRecommendations;
        public IQueryable<UBRecommendation> UBRecommendations => _context.UBRecommendations;
    }
}
