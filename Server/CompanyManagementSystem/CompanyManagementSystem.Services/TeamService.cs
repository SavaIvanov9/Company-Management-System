namespace CompanyManagementSystem.Services
{
    using Abstraction;
    using Base;
    using Data.Abstraction;
    using DbModels;
    using System.Collections.Generic;
    using System.Linq;

    public class TeamService : BaseService, ITeamService
    {
        public TeamService(IUnitOfWork data) : base(data)
        {
        }

        public IEnumerable<Team> GetAll()
        {
            var result = this.data.TeamRepository
                .All()
                .Where(x => !x.IsDeleted);

            return result;
        }
    }
}
