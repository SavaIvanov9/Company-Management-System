namespace CompanyManagementSystem.Services
{
    using Abstraction;
    using Base;
    using Data.Abstraction;
    using DbModels;
    using System.Collections.Generic;
    using System.Linq;

    public class DepartmentService : BaseService, IDepartmentService
    {
        public DepartmentService(IUnitOfWork data) : base(data)
        {
        }

        public IEnumerable<Department> GetAll()
        {
            var result = this.data.DepartmentRepository
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
