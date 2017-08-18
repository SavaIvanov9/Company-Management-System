namespace CompanyManagementSystem.DbModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Abstraction;

    public class Department : DataModel
    {
        private ICollection<Team> teams;

        public Department()
        {
            this.teams = new HashSet<Team>();
        }

        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Index("Name", IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Team> Teams
        {
            get => this.teams;
            set => this.teams = value;
        }
    }
}
