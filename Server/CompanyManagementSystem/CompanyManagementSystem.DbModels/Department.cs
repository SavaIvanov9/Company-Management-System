namespace CompanyManagementSystem.DbModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Department
    {
        private ICollection<Team> teams;

        public Department()
        {
            this.teams = new HashSet<Team>();
        }

        [Key]
        public int Id { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Team> Teams
        {
            get => this.teams;
            set => this.teams = value;
        }
    }
}
