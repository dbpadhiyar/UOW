using HostUOWCore;

namespace UOWInfa
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContextClass _dbContext;
        public IProductRepositery Products { get; }

        public UnitOfWork(DbContextClass dbContext,IProductRepositery productRepository)
        {
            _dbContext = dbContext;
            Products = productRepository;
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
