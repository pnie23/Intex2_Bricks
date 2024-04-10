using Intex2_Bricks.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

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

        public void Delete(Product deletedInfo)
        {
            _context.Remove(deletedInfo);
            _context.SaveChanges();
        }


        public void Update(Product updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
        }

        public void Update(CustomersListViewModel updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
        }

        public void Update(Customer updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(Customer deletedInfo)
        {
            _context.Remove(deletedInfo);
            _context.SaveChanges();
        }
    }
}
