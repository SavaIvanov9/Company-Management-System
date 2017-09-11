namespace CompanyManagementSystem.Services.Abstraction
{
    using DbModels;
    using Models;
    using System.Linq;

    public interface ITeamService
    {
        IQueryable<TeamViewModel> GetAll();

        IQueryable<TeamViewModel> GetTeamsByDepartment(long id);

        TeamViewModel GetById(long id);

        TeamViewModel CreateTeam(TeamCreateModel teamData);
    }
}
