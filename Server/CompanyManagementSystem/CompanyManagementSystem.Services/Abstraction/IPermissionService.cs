namespace CompanyManagementSystem.Services.Abstraction
{
    using DbModels;
    using System.Collections.Generic;

    public interface IPermissionService
    {
        IEnumerable<Permission> GetAll();
    }
}
