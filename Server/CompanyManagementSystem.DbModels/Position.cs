namespace CompanyManagementSystem.DbModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Abstraction;

    public class Position : DataModel
    {
        private ICollection<Employee> employees;
        private ICollection<Permission> permissions;

        public Position()
        {
            this.employees = new HashSet<Employee>();
            this.permissions = new HashSet<Permission>();
        }

        [Required]
        [MaxLength(20)]
        [Index("Name", IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees
        {
            get => this.employees;
            set => this.employees = value;
        }

        public virtual ICollection<Permission> Permissions
        {
            get => this.permissions;
            set => this.permissions = value;
        }
    }
}
