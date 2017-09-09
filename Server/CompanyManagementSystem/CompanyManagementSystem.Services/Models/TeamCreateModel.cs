using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Services.Models
{
    public class TeamCreateModel
    {
        public long DepartmentId { get; set; }
        public List<long> EmployeeIds { get; set; }
        public string TeamName { get; set; }
    }
}
