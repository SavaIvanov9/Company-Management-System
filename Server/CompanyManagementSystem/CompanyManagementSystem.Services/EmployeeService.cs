namespace CompanyManagementSystem.Services
{
    using Abstraction;
    using Base;
    using Data.Abstraction;
    using DataTransferModels.Employee;
    using DbModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using ModelMapping.Abstraction;
    using Models;

    public class EmployeeService : BaseService, IEmployeeService
    {
        private readonly IEmployeeMapper mapper;

        public EmployeeService(IUnitOfWork data, IEmployeeMapper mapper) : base(data)
        {
            this.mapper = mapper;
        }

        public IQueryable<Employee> GetAll()
        {
            var result = this.data.EmployeeRepository
                .All()
                .Where(x => !x.IsDeleted);

            return result;
        }

        public Employee GetById(long id)
        {
            var result = this.data.EmployeeRepository
                .All()
                .FirstOrDefault(x => x.Id == id && x.IsDeleted == false);

            return result;
        }

        public IQueryable<EmployeeViewModel> GetEmployeesByTeam(long id)
        {
            var result = this.data.EmployeeRepository
                .All()
                .Where(x => !x.IsDeleted && x.Teams.Any(t => t.Id == id))
                .Select(x => new EmployeeViewModel()
                {
                    Id = x.Id,
                    Username = x.Username,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Age = x.Age,
                    Email = x.Email,
                    ManagerId = x.ManagerId,
                    PositionId = x.PositionId,
                    PositionName = x.Position.Name,
                    CreatedOn = x.CreatedOn
                });

            return result;
        }

        public IQueryable<EmployeeViewModel> GetEmployeesByDepartment(long id)
        {
            var result = this.data.EmployeeRepository
                .All()
                .Where(x => !x.IsDeleted && x.Teams.Any(t => t.DepartmentId == id))
                .Select(x => new EmployeeViewModel()
                {
                    Id = x.Id,
                    Username = x.Username,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Age = x.Age,
                    Email = x.Email,
                    ManagerId = x.ManagerId,
                    PositionId = x.PositionId,
                    CreatedOn = x.CreatedOn
                });

            return result;
        }

        public long CreateEmployee(Employee newEmployee, IEnumerable<long> teamIds)
        {
            var teams = this.data.TeamRepository
                .All()
                .Where(t => t.IsDeleted == false && teamIds.Any(x => x == t.Id))
                .ToList();

            teams.ForEach(t =>
            {
                newEmployee.Teams.Add(t);
            });

            this.data.EmployeeRepository.Add(newEmployee);
            this.data.SaveChanges();

            return newEmployee.Id;
        }
    }
}
