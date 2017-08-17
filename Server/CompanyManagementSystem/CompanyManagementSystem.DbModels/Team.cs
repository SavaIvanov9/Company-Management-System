namespace CompanyManagementSystem.DbModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Team
    {
        private ICollection<Employee> employees;

        public Team()
        {
            this.employees = new HashSet<Employee>();
        }

        [Key]
        public long Id { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("Department")]
        public long DepartmentId { get; set; }

        [Required]
        public Department Department { get; set; }

        public virtual ICollection<Employee> Employees
        {
            get { return this.employees; }
            set { this.employees = value; }
        }
    }
}
