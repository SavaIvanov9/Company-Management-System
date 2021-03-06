﻿namespace CompanyManagementSystem.Services
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

        public IQueryable<EmployeeViewModel> GetAll()
        {
            var result = this.data.EmployeeRepository
                .All()
                .Where(x => !x.IsDeleted)
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

        public EmployeeViewModel GetById(long id)
        {
            var result = this.data.EmployeeRepository
                .All()
                .Where(x => x.Id == id && x.IsDeleted == false)
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
                    CreatedOn = x.CreatedOn,
                    ManagerName = String.Concat(x.Manager.FirstName, " ", x.Manager.LastName),
                    Teams = x.Teams.Select(t => t.Name)
                })
                .FirstOrDefault();

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

        public EmployeeViewModel CreateEmployee(Employee newEmployee, IEnumerable<long> teamIds)
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

            return new EmployeeViewModel()
            {
                Id = newEmployee.Id,
                Username = newEmployee.Username,
                FirstName = newEmployee.FirstName,
                LastName = newEmployee.LastName,
                Age = newEmployee.Age,
                Email = newEmployee.Email,
                ManagerId = newEmployee.ManagerId,
                PositionId = newEmployee.PositionId,
                CreatedOn = newEmployee.CreatedOn
            };
        }

        public long DoesEmployeeExists(string userName, string passWord)
        {
            var employee = this.data.EmployeeRepository
                .All()
                .FirstOrDefault(x => x.Username == userName && x.Password == passWord);

            return employee != null ? employee.Id : -1;
        }
    }
}
