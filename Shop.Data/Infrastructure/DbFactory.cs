namespace Shop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopDbContext dbContext;

        public ShopDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopDbContext());
        }

        public override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}