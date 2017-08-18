namespace CompanyManagementSystem.DbModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Abstraction;

    public class Team : DataModel
    {
        private ICollection<Employee> employees;

        public Team()
        {
            this.employees = new HashSet<Employee>();
        }

        [Required]
        [MaxLength(20)]
        [Index("Name", IsUnique = true)]
        public string Name { get; set; }

        [Required]
        [ForeignKey("Department")]
        public long DepartmentId { get; set; }

        [Required]
        public Department Department { get; set; }

        public ICollection<Employee> Employees
        {
            get => this.employees;
            set => this.employees = value;
        }
    }
}
