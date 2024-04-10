using Intex2_Bricks.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Intex2_Bricks.Models
{
    public interface IBricksRepository
    {
        public IQueryable<Product> Products { get; }
        public IQueryable<Customer> Customers { get ;}
        public IQueryable<LineItem> LineItems { get; }
        public IQueryable<Order> Orders { get; }
        public IQueryable<IBRecommendation> IBRecommendations { get; }
        public IQueryable<UBRecommendation> UBRecommendations { get; }

        void Delete(Product products);
        void Update(ProductsListViewModel updatedInfo);
        void Update(Product updatedInfo);
        void AddProduct(Product products);
        void Update(Customer updatedInfo);
        void Delete(Customer deletedInfo);
    }
}
