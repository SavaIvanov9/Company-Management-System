namespace CompanyManagementSystem.Services.Abstraction
{
    using DbModels;
    using System.Collections.Generic;
    using System.Linq;

    public interface IPermissionService
    {
        IQueryable<Permission> GetAll();
    }
}
