
namespace CompanyManagementSystem.DataTransferModels.Position
{
    using Employee;
    using Permission;
    using System.Collections.Generic;

    public interface IPositionModel
    {
        string Name { get; set; }

        ICollection<EmployeeReadModel> Employees { get; set; }
        ICollection<PermissionReadModel> Permissions { get; set; }
    }
}
