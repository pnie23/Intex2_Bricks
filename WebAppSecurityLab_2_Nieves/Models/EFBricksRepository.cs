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
    }
}
