namespace CompanyManagementSystem.DbModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Abstraction;

    public class Permission : DataModel
    {
        private ICollection<Position> positions;

        public Permission()
        {
            this.positions = new HashSet<Position>();
        }

        [Required]
        [MaxLength(20)]
        [Index("Code", IsUnique = true)]
        public string Code { get; set; }

        public virtual ICollection<Position> Positions
        {
            get => this.positions;
            set => this.positions = value;
        }
    }
}