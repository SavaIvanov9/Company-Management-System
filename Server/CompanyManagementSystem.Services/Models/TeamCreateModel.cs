using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Services.Models
{
    public class TeamCreateModel
    {
        //private string name;

        //public TeamCreateModel(string name)
        //{
        //    this.name = name;
        //}

        public long DepartmentId { get; set; }
        public List<long> EmployeeIds { get; set; }
        public string TeamName { get; set; }
        //{
        //    get { return this.name; } set { this.name = value; }
        //}
    }
}
