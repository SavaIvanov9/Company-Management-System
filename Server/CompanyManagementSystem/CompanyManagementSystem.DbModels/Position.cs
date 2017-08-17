namespace CompanyManagementSystem.DbModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Position
    {
        private ICollection<Employee> employees;

        public Position()
        {
            this.employees = new HashSet<Employee>();
        }

        [Key]
        public long Id { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees
        {
            get => this.employees;
            set => this.employees = value;
        }
    }
}
