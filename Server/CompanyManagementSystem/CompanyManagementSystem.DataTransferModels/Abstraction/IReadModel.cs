namespace CompanyManagementSystem.DataTransferModels.Abstraction
{
    using System;

    public interface IReadModel : ICreateModel
    {
        long Id { get; set; }

        string ModifiedBy { get; set; }
        DateTime? ModifiedOn { get; set; }
    }
}