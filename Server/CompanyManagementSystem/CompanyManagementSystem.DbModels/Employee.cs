namespace CompanyManagementSystem.DbModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Abstraction;

    public class Employee : DataModel
    {
        private ICollection<Team> teams;

        public Employee()
        {
            this.teams = new HashSet<Team>();
        }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [Index("Email", IsUnique = true)]
        [MaxLength(30)]
        public string Email { get; set; }

        public long? ManagerId { get; set; }

        public Employee Manager { get; set; }

        [Required]
        [ForeignKey("Position")]
        public long PositionId { get; set; }

        [Required]
        public Position Position { get; set; }

        public virtual ICollection<Team> Teams
        {
            get => this.teams;
            set => this.teams = value;
        }
    }
}
