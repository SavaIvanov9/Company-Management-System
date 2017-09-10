namespace CompanyManagementSystem.Data.Repositories
{
    using Abstraction;
    using DbModels;

    public class PositionRepository : GenericRepository<Position>, IRepository<Position>
    {
        public PositionRepository(IManagementSystemDbContext context)
            : base(context)
        {
        }
    }
}