namespace CompanyManagementSystem.Services.Abstraction
{
    using DataTransferModels.Employee;
    using System.Collections.Generic;
    using System.Linq;
    using DbModels;

    public interface IEmployeeService
    {
        IQueryable<Employee> GetAll();

        Employee GetById(long id);
    }
}
