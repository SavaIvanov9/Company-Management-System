namespace CompanyManagementSystem.DataTransferModels.Team
{
    using Department;
    using Employee;
    using System.Collections.Generic;

    public interface ITeamModel
    {
        string Name { get; set; }

        long DepartmentId { get; set; }

        IDepartmentModel Department { get; set; }

        ICollection<IEmployeeModel> Employees { get; set; }
    }
}
