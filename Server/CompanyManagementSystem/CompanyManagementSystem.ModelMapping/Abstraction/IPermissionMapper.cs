namespace CompanyManagementSystem.ModelMapping.Abstraction
{
    using DataTransferModels.Permission;
    using DbModels;
    using System;
    using System.Linq.Expressions;

    public interface IPermissionMapper
    {
        Expression<Func<Permission, PermissionReadModel>> MapDbModelToDtm();
    }
}
