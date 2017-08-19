namespace CompanyManagementSystem.DataTransferModels.Position
{
    using Abstraction;
    using Employee;
    using Permission;
    using System.Collections.Generic;

    public class PositionReadModel : BaseReadModel, IPositionModel
    {
        public string Name { get; set; }

        public ICollection<EmployeeReadModel> Employees { get; set; }

        public ICollection<PermissionReadModel> Permissions { get; set; }
    }
}
