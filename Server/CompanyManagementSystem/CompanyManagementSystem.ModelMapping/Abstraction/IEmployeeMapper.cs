namespace CompanyManagementSystem.ModelMapping.Abstraction
{
    using DataTransferModels.Employee;
    using DbModels;
    using System;
    using System.Linq.Expressions;

    public interface IEmployeeMapper
    {
        Expression<Func<Employee, EmployeeReadModel>> MapDbModelToDtm();
    }
}
