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

    public class EmployeeService : BaseService, IEmployeeService
    {
        public EmployeeService(IUnitOfWork data) : base(data)
        {
        }

        public IEnumerable<EmployeeReadModel> GetAll()
        {
            var result = this.data.EmployeeRepository
                    .All()
                    .Where(x => !x.IsDeleted)
                //.Select(x => new EmployeeReadModel()
                //{
                //    Id = x.Id,
                //    FirstName = x.FirstName,
                //    LastName = x.LastName,
                //    Age = x.Age,
                //    Email = x.Email,
                //    ManagerId = x.ManagerId,
                //    //Manager = x.Manager
                //});
               .Select(Expressions.ExpressionC);

            return result;
        }
    }

    public static class Expressions
    {
        public static Expression<Func<Employee, EmployeeReadModel>> ExpressionC =
            (e) => (new EmployeeReadModel()
            {
                FirstName = e.FirstName
            });

        public static Expression<Func<Employee, EmployeeReadModel>> Convert(Employee employee)
        {
            Expression<Func<Employee, EmployeeReadModel>> expression =
                (e) => (new EmployeeReadModel()
                {
                    FirstName = e.FirstName
                });

            return expression;
        }

        //public static AddressDTO Convert(Address source)
        //{
        //    if (source == null) return null;
        //    return new AddressDTO()
        //    {
        //        ID = source.ID,
        //        City = source.City
        //    }
        //}
    }
}
