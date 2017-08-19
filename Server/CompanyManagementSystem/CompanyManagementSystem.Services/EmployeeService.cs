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

    public class EmployeeService : BaseService, IEmployeeService
    {
        private readonly IEmployeeMapper mapper;

        public EmployeeService(IUnitOfWork data, IEmployeeMapper mapper) : base(data)
        {
            this.mapper = mapper;
        }

        public IEnumerable<Employee> GetAll()
        {
            var result = this.data.EmployeeRepository
                .All()
                .Where(x => !x.IsDeleted);
               //.Select(x => new EmployeeReadModel()
               //{
               //   
               //});
               //.Select(this.mapper.MapDbModelToDtm());

            return result;
        }
    }
}
