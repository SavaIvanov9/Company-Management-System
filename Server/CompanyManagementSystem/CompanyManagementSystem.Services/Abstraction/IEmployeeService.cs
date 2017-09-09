namespace CompanyManagementSystem.Services.Abstraction
{
    using DbModels;
    using Models;
    using System.Linq;

    public interface IEmployeeService
    {
        IQueryable<Employee> GetAll();
        IQueryable<EmployeeViewModel> GetEmployeesByTeam(long id);
        Employee GetById(long id);
    }
}
