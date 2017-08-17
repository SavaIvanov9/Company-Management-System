namespace CompanyManagementSystem.Data.Repositories
{
    using Abstraction;
    using DbModels;

    public class EmployeeRepository : GenericRepository<Employee>, IRepository<Employee>
    {
        public EmployeeRepository(IManagementSystemDbContext context)
            : base(context)
        {
        }
    }
}
