namespace CompanyManagementSystem.Services.Abstraction
{
    using System.Collections.Generic;
    using System.Linq;
    using DbModels;

    public interface IDepartmentService
    {
        IQueryable<Department> GetAll();

        Department GetById(long id);
    }
}
