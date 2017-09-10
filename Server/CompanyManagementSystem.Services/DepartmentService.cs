namespace CompanyManagementSystem.Services
{
    using Abstraction;
    using Base;
    using Data.Abstraction;
    using DbModels;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class DepartmentService : BaseService, IDepartmentService
    {
        public DepartmentService(IUnitOfWork data) : base(data)
        {
        }

        public IQueryable<DepartmenViewModel> GetAll()
        {
            var result = this.data.DepartmentRepository
                .All()
                .Where(x => !x.IsDeleted)
                .Select(x => new DepartmenViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    CreatedOn = x.CreatedOn,
                    CreatedBy = x.CreatedBy
                });
            //.Select(x => new EmployeeReadModel()
            //{
            //   
            //});
            //.Select(this.mapper.MapDbModelToDtm());

            return result;
        }

        public DepartmenViewModel GetById(long id)
        {
            var result = this.data.DepartmentRepository
                .All()
                .Where(x => x.Id == id && x.IsDeleted == false)
                .Select(x => new DepartmenViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    CreatedOn = x.CreatedOn,
                    CreatedBy = x.CreatedBy,
                    //Teams = x.Teams.Select(t => new TeamViewModel()
                    //{
                    //    Id = t.Id,
                    //    Name = t.Name
                    //})
                })
                .FirstOrDefault();

            return result;
        }
    }
}
