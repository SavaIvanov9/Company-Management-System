﻿namespace CompanyManagementSystem.DbModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Employee
    {
        private ICollection<Team> teams;

        public Employee()
        {
            this.teams = new HashSet<Team>();
        }

        [Key]
        public long Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
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