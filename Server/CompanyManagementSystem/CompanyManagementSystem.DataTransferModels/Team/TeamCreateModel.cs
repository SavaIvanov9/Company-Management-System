namespace CompanyManagementSystem.DataTransferModels.Team
{
    using Abstraction;
    using Department;
    using Employee;
    using System;
    using System.Collections.Generic;

    public class TeamCreateModel : BaseCreateModel, ITeamModel
    {
        public TeamCreateModel(string createdBy) : base(createdBy)
        {
        }

        public TeamCreateModel(string createdBy, DateTime createdOn, bool isDeleted) : base(createdBy, createdOn, isDeleted)
        {
        }

        public string Name { get; set; }

        public long DepartmentId { get; set; }

        public IDepartmentModel Department { get; set; }

        public ICollection<IEmployeeModel> Employees { get; set; }
    }
}
