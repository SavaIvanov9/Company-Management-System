﻿namespace CompanyManagementSystem.DbModels.Abstraction
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public abstract class DataModel : IDataModel
    {
        protected DataModel()
        {
            this.CreatedOn = DateTime.Now;
            this.IsDeleted = false;
        }

        [Key]
        public long Id { get; set; }

        [Required]
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
