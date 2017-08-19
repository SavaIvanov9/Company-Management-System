namespace CompanyManagementSystem.DataTransferModels.Position
{
    using Abstraction;
    using Employee;
    using Permission;
    using System.Collections.Generic;

    public class PositionReadModel : BaseReadModel, IPositionModel
    {
        public string Name { get; set; }

        public ICollection<IEmployeeModel> Employees { get; set; }

        public ICollection<IPermissionModel> Permissions { get; set; }
    }
}
