namespace CompanyManagementSystem.ModelMapping.Abstraction
{
    using DataTransferModels.Department;
    using DbModels;
    using System;
    using System.Linq.Expressions;

    public interface IDepartmentMapper
    {
        Expression<Func<Department, DepartmentReadModel>> MapDbModelToDtm();
    }
}
