namespace CompanyManagementSystem.Services.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

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
        public DateTime CreatedOn { get; set; }
        public string ManagerName { get; set; }
        public string PositionName { get; set; }
        public IEnumerable<string> Teams { get; set; }

    }
}
