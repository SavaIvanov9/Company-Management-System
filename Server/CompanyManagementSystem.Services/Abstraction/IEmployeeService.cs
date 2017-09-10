namespace CompanyManagementSystem.Services.Abstraction
{
    using DbModels;
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public interface IEmployeeService
    {
        IQueryable<EmployeeViewModel> GetAll();
        IQueryable<EmployeeViewModel> GetEmployeesByTeam(long id);
        IQueryable<EmployeeViewModel> GetEmployeesByDepartment(long id);
        long CreateEmployee(Employee newEmployee, IEnumerable<long> teamIds);
        long DoesEmployeeExists(string userName, string passWord);
        EmployeeViewModel GetById(long id);
    }
}
