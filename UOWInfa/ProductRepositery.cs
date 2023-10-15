using HostUOWCore;
using ModelUOW;

namespace UOWInfa
{
    public class ProductRepositery : GenericRepositery<ProductDetails>, IProductRepositery
    {
        public ProductRepositery(DbContextClass dbContext) : base(dbContext)
        {

        }
    }
}
