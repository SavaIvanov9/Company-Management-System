namespace CompanyManagementSystem.DataTransferModels.Team
{
    using Abstraction;
    using Department;
    using Employee;
    using System.Collections.Generic;

    public class TeamReadModel : BaseReadModel, ITeamModel
    {
        public string Name { get; set; }

        public long DepartmentId { get; set; }

        public IDepartmentModel Department { get; set; }

        public ICollection<IEmployeeModel> Employees { get; set; }
    }
}
