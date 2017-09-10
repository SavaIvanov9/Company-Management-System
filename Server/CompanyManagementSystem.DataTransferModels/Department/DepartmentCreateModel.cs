namespace CompanyManagementSystem.DataTransferModels.Department
{
    using Abstraction;
    using System;
    using System.Collections.Generic;
    using Team;

    public class DepartmentCreateModel : BaseCreateModel, IDepartmentModel
    {
        public DepartmentCreateModel(string createdBy) : base(createdBy)
        {
        }

        public DepartmentCreateModel(string createdBy, DateTime createdOn, bool isDeleted) : base(createdBy, createdOn, isDeleted)
        {
        }

        public string Name { get; set; }

        public ICollection<ITeamModel> Teams { get; set; }
    }
}
