namespace CompanyManagementSystem.Data.Repositories
{
    using Abstraction;
    using DbModels;

    public class CookieRepository : GenericRepository<Cookie>, IRepository<Cookie>
    {
        public CookieRepository(IManagementSystemDbContext context)
            : base(context)
        {
        }
    }
}
