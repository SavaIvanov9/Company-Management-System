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

        public Team GetById(long id)
        {
            var result = this.data.TeamRepository
                .All()
                .FirstOrDefault(x => x.Id == id && x.IsDeleted == false);

            return result;
        }
    }
}
