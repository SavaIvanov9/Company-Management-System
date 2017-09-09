﻿namespace CompanyManagementSystem.Services
{
    using Abstraction;
    using Base;
    using Data.Abstraction;
    using DbModels;
    using System.Collections.Generic;
    using System.Linq;
    using DataTransferModels.Team;
    using Models;

    public class TeamService : BaseService, ITeamService
    {
        public TeamService(IUnitOfWork data) : base(data)
        {
        }

        public IQueryable<Team> GetAll()
        {
            var result = this.data.TeamRepository
                .All()
                .Where(x => !x.IsDeleted);

            return result;
        }

        public Team GetById(long id)
        {
            var result = this.data.TeamRepository
                .All()
                .FirstOrDefault(x => x.Id == id && x.IsDeleted == false);

            return result;
        }

        public long CreateTeam(TeamCreateModel teamData)
        {
            var department = this.data.DepartmentRepository
                .All()
                .FirstOrDefault(x => x.IsDeleted == false && x.Id == teamData.DepartmentId);

            //var employees = this.data.EmployeeRepository
            //    .All()
            //    .Where(x => x.IsDeleted == false && teamData.EmployeeIds.Any(e => e == x.Id))
            //    .ToList();

            var employees = this.FindEmployees(teamData.EmployeeIds).ToList();

            var newTeam = new Team()
            {
                CreatedBy = "S",
                Name = teamData.TeamName,
                Department = department,
                DepartmentId = department.Id,
                Employees = employees
            };

            //employees.ForEach(x =>
            //{
            //    x.Teams.Add(newTeam);
            //    this.data.EmployeeRepository.Update(x);
            //});

            this.data.TeamRepository.Add(newTeam);
            this.data.SaveChanges();

            return newTeam.Id;
        }

        private IEnumerable<Employee> FindEmployees(List<long> ids)
        {
            for (int i = 0; i < ids.Count; i++)
            {
                var id = ids[i];
                yield return this.data.EmployeeRepository
                    .All()
                    .FirstOrDefault(e => e.Id == id);
            }

            //ids.ForEach(id =>
            //{
            //    yield return this.data.EmployeeRepository
            //        .All()
            //        .FirstOrDefault(e => e.Id == id);
            //});
        }
    }
}
