namespace CompanyManagementSystem.ModelMapping.Abstraction
{
    using DataTransferModels.Position;
    using DbModels;
    using System;
    using System.Linq.Expressions;

    public interface IPossitionMapper
    {
        Expression<Func<Position, PositionReadModel>> MapDbModelToDtm();
    }
}
