namespace CompanyManagementSystem.DataTransferModels.Permission
{
    using Abstraction;
    using System;
    using System.Collections.Generic;
    using Position;

    class PermissionCreateModel : BaseCreateModel, IPermissionModel
    {
        public PermissionCreateModel(string createdBy) : base(createdBy)
        {
        }

        public PermissionCreateModel(string createdBy, DateTime createdOn, bool isDeleted) : base(createdBy, createdOn, isDeleted)
        {
        }

        public string Code { get; set; }

        public ICollection<PositionReadModel> Positions { get; set; }
    }
}
