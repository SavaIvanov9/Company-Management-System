namespace CompanyManagementSystem.Services.Abstraction
{
    using DbModels;
    using System.Collections.Generic;
    using System.Linq;

    public interface ITeamService
    {
        IQueryable<Team> GetAll();

        Team GetById(long id);
    }
}
