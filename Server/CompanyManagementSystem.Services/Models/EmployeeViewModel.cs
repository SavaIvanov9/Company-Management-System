namespace CompanyManagementSystem.Services.Models
{
    using System;

    public class EmployeeViewModel
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public long? ManagerId { get; set; }
        public long PositionId { get; set; }
        public string PositionName { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
