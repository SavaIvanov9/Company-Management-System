namespace CompanyManagementSystem.DataTransferModels.Abstraction
{
    using System;

    public interface ICreateModel
    {
        string CreatedBy { get; set; }
        DateTime CreatedOn { get; set; }

        bool IsDeleted { get; set; }
        DateTime? DeletedOn { get; set; }
    }
}
