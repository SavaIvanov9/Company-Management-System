namespace CompanyManagementSystem.DataTransferModels.Abstraction
{
    using System;

    public class BaseCreateModel : ICreateModel
    {
        public BaseCreateModel(string createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedOn = DateTime.Now;
            this.IsDeleted = false;
        }

        public BaseCreateModel(string createdBy, DateTime createdOn, bool isDeleted)
        {
            this.CreatedBy = createdBy;
            this.CreatedOn = createdOn;
            this.IsDeleted = isDeleted;

            if (this.IsDeleted)
            {
                this.DeletedOn = DateTime.Now;
            }
        }

        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
