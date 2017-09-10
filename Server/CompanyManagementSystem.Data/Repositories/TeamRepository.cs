namespace CompanyManagementSystem.Data.Repositories
{
    using Abstraction;
    using DbModels;

    public class TeamRepository : GenericRepository<Team>, IRepository<Team>
    {
        public TeamRepository(IManagementSystemDbContext context)
            : base(context)
        {
        }
    }
}