namespace CompanyManagementSystem.DataTransferModels.Permission
{
    using System.Collections.Generic;
    using Position;

    public interface IPermissionModel
    {
        string Code { get; set; }

        ICollection<IPositionModel> Positions { get; set; }
    }
}
