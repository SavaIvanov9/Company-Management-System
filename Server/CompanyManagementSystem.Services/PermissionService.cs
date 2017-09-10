namespace CompanyManagementSystem.Services
{
    using Abstraction;
    using Base;
    using Data.Abstraction;
    using DbModels;
    using System.Collections.Generic;
    using System.Linq;

    public class PermissionService : BaseService, IPermissionService
    {
        public PermissionService(IUnitOfWork data) : base(data)
        {
        }

        public IQueryable<Permission> GetAll()
        {
            var result = this.data.PermissionRepository
                .All()
                .Where(x => !x.IsDeleted);

            return result;
        }
    }
}
