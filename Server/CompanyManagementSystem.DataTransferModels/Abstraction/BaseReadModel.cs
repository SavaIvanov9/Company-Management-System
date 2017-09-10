namespace CompanyManagementSystem.DataTransferModels.Abstraction
{
    using System;

    public abstract class BaseReadModel : IReadModel
    {
        public long Id { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}