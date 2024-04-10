using Microsoft.EntityFrameworkCore;

namespace Intex2_Bricks.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private BricksContext _context;

        public EFOrderRepository(BricksContext ctx)
        {
            _context = ctx;
        }

        public IQueryable<Order> Orders => _context.Orders
                            .Include(o => o.Lines)
                            .ThenInclude(l => l.Product);

        public void SaveOrder(Order order)
        {
            _context.AttachRange(order.Lines.Select(l => l.Product));
            if (order.transaction_Id == 0)
            {
                _context.Orders.Add(order);
            }
            _context.SaveChanges();
        }
    }
}