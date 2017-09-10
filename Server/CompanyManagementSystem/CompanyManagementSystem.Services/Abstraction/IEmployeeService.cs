namespace CompanyManagementSystem.Services.Abstraction
{
    using DbModels;
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public interface IEmployeeService
    {
        IQueryable<Employee> GetAll();
        IQueryable<EmployeeViewModel> GetEmployeesByTeam(long id);
        IQueryable<EmployeeViewModel> GetEmployeesByDepartment(long id);
        long CreateEmployee(Employee newEmployee, IEnumerable<long> teamIds);
        Employee GetById(long id);
    }
}
