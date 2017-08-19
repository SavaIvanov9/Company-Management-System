namespace CompanyManagementSystem.ModelMapping.Abstraction
{
    using DataTransferModels.Team;
    using DbModels;
    using System;
    using System.Linq.Expressions;

    public interface ITeamMapper
    {
        Expression<Func<Team, TeamReadModel>> MapDbModelToDtm();
    }
}
