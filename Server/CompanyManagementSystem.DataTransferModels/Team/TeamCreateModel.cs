namespace CompanyManagementSystem.DataTransferModels.Team
{
    using Abstraction;
    using Department;
    using Employee;
    using System;
    using System.Collections.Generic;

    public class TeamCreateModel2 : BaseCreateModel, ITeamModel
    {
        public TeamCreateModel2(string createdBy) : base(createdBy)
        {
        }

        public TeamCreateModel2(string createdBy, DateTime createdOn, bool isDeleted) : base(createdBy, createdOn, isDeleted)
        {
        }

        public string Name { get; set; }

        public long DepartmentId { get; set; }

        public IDepartmentModel Department { get; set; }

        public ICollection<IEmployeeModel> Employees { get; set; }
    }
}
