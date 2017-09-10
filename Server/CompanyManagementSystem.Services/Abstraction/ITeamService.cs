namespace CompanyManagementSystem.Services.Abstraction
{
    using DbModels;
    using Models;
    using System.Linq;

    public interface ITeamService
    {
        IQueryable<Team> GetAll();

        IQueryable<TeamViewModel> GetTeamsByDepartment(long id);

        Team GetById(long id);

        long CreateTeam(TeamCreateModel teamData);
    }
}
