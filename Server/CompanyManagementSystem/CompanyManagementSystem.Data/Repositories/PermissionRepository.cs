namespace CompanyManagementSystem.Data.Repositories
{
    using Abstraction;
    using DbModels;

    public class PermissionRepository : GenericRepository<Permission>, IRepository<Permission>
    {
        public PermissionRepository(IManagementSystemDbContext context)
            : base(context)
        {
        }
    }
}
