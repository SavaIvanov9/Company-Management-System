namespace CompanyManagementSystem.DataTransferModels.Employee
{
    using Abstraction;
    using Position;
    using System.Collections.Generic;
    using Team;

    public class EmployeeReadModel : BaseReadModel, IEmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public long? ManagerId { get; set; }
        public IEmployeeModel Manager { get; set; }
        public long PositionId { get; set; }
        public PositionReadModel Position { get; set; }
        public ICollection<ITeamModel> Teams { get; set; }
    }
}
