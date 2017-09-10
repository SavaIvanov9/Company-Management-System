namespace CompanyManagementSystem.Services.Abstraction
{
    using System.Collections.Generic;
    using System.Linq;
    using DbModels;
    using Models;

    public interface IDepartmentService
    {
        IQueryable<DepartmenViewModel> GetAll();

        DepartmenViewModel GetById(long id);
    }
}
