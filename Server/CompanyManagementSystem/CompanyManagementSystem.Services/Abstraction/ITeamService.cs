namespace CompanyManagementSystem.Services.Abstraction
{
    using DbModels;
    using Models;
    using System.Linq;

    public interface ITeamService
    {
        IQueryable<Team> GetAll();

        Team GetById(long id);

        long CreateTeam(TeamCreateModel teamData);
    }
}
