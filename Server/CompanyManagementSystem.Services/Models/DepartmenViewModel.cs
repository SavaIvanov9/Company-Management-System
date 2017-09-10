using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Services.Models
{
    public class DepartmenViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public IEnumerable<TeamViewModel> Teams { get; set; }
    }
}
