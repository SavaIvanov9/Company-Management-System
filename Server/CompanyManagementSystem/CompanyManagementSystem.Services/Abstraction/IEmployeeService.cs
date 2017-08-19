namespace CompanyManagementSystem.Services.Abstraction
{
    using DataTransferModels.Employee;
    using System.Collections.Generic;

    public interface IEmployeeService
    {
        IEnumerable<EmployeeReadModel> GetAll();
    }
}
