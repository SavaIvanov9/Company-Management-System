namespace CompanyManagementSystem.DataTransferModels.Employee
{
    using System.Collections.Generic;
    using Team;

    public interface IEmployeeModel
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        int Age { get; set; }

        string Email { get; set; }

        long? ManagerId { get; set; }

        IEmployeeModel Manager { get; set; }

        long PositionId { get; set; }

        IEmployeeModel Position { get; set; }

        ICollection<ITeamModel> Teams { get; set; }
    }
}
