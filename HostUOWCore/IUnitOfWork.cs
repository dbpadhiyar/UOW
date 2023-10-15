namespace HostUOWCore
{
    public interface IUnitOfWork
    {
        IProductRepositery Products { get; }
        int Save();
    }
}