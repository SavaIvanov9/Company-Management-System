namespace CompanyManagementSystem.Services.Abstraction
{
    using System.Collections.Generic;
    using DbModels;

    public interface IDepartmentService
    {
        IEnumerable<Department> GetAll();

        Department GetById(long id);
    }
}
