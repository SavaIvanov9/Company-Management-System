namespace CompanyManagementSystem.Services.Abstraction
{
    using DbModels;
    using System.Collections.Generic;

    public interface ITeamService
    {
        IEnumerable<Team> GetAll();

        Team GetById(long id);
    }
}
