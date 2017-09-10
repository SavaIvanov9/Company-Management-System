namespace CompanyManagementSystem.DataTransferModels.Permission
{
    using System.Collections.Generic;
    using Abstraction;
    using Position;

    public class PermissionReadModel : BaseReadModel, IPermissionModel
    {
        public string Code { get; set; }

        public ICollection<PositionReadModel> Positions { get; set; }
    }
}
