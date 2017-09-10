namespace CompanyManagementSystem.DataTransferModels.Employee
{
    using Abstraction;
    using Position;
    using System;
    using System.Collections.Generic;
    using Team;

    public class EmployeeCreateModel : BaseCreateModel, IEmployeeModel
    {
        public EmployeeCreateModel(string createdBy) : base(createdBy)
        {
        }

        public EmployeeCreateModel(string createdBy, DateTime createdOn, bool isDeleted) : base(createdBy, createdOn, isDeleted)
        {
        }

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
