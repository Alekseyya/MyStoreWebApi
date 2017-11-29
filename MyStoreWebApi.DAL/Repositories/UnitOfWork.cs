using MyStoreWebApi.DAL.Repositories.Base;
using MyStoreWebApi.DL.Context;

namespace MyStoreWebApi.DAL.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly MyStoreContext _context;
        public UnitOfWork()
        {
            _context = new MyStoreContext();
            CategoryRepository = new CategoryRepository(_context);
            OrderRepository = new OrderRepository(_context);
            PhotoRepository = new PhotoRepository(_context);
            ProductRepository = new ProductRepository(_context);
            UserRepository = new UserRepository(_context);
            MarkRepository = new MarkRepository(_context);

        }

        public ICategoryRepository CategoryRepository { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public IPhotoRepository PhotoRepository { get; set; }
        public IProductRepository ProductRepository { get; set; }
        public IUserRepository UserRepository { get; set; }
        public IMarkRepository MarkRepository { get; set; }
    }
}
