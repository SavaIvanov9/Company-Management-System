namespace CompanyManagementSystem.Services.Abstraction
{
    using DataTransferModels.Employee;
    using System.Collections.Generic;
    using DbModels;

    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();

        Employee GetById(long id);
    }
}
