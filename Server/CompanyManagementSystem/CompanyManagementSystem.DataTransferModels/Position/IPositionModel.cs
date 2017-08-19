
namespace CompanyManagementSystem.DataTransferModels.Position
{
    using Employee;
    using Permission;
    using System.Collections.Generic;

    public interface IPositionModel
    {
        string Name { get; set; }

        ICollection<IEmployeeModel> Employees { get; set; }
        ICollection<IPermissionModel> Permissions { get; set; }
    }
}
