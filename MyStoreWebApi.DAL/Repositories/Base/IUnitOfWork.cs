namespace MyStoreWebApi.DAL.Repositories.Base
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; set; }
        IOrderRepository OrderRepository { get; set; }
        IPhotoRepository PhotoRepository { get; set; }
        IProductRepository ProductRepository { get; set; }
        IUserRepository UserRepository { get; set; }
    }
}
