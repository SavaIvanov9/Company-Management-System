namespace CompanyManagementSystem.Data.Repositories
{
    using Abstraction;
    using DbModels;

    public class DepartmentRepository : GenericRepository<Department>, IRepository<Department>
    {
        public DepartmentRepository(IManagementSystemDbContext context)
            : base(context)
        {
        }
    }
}
