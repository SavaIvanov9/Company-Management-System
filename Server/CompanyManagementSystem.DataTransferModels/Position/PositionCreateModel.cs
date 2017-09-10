namespace CompanyManagementSystem.DataTransferModels.Position
{
    using Abstraction;
    using Employee;
    using Permission;
    using System;
    using System.Collections.Generic;

    public class PositionCreateModel : BaseCreateModel, IPositionModel
    {
        public PositionCreateModel(string createdBy) : base(createdBy)
        {
        }

        public PositionCreateModel(string createdBy, DateTime createdOn, bool isDeleted) : base(createdBy, createdOn, isDeleted)
        {
        }

        public string Name { get; set; }

        public ICollection<EmployeeReadModel> Employees { get; set; }

        public ICollection<PermissionReadModel> Permissions { get; set; }
    }
}
