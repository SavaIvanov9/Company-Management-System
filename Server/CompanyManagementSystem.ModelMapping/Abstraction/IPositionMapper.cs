namespace CompanyManagementSystem.ModelMapping.Abstraction
{
    using DataTransferModels.Position;
    using DbModels;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IPositionMapper
    {
        Expression<Func<Position, PositionReadModel>> MapDbModelToDtm();

        Expression<Func<ICollection<Position>, ICollection<PositionReadModel>>> MapDbCollectionToDtm();
    }
}
