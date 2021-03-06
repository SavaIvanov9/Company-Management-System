﻿namespace CompanyManagementSystem.DbModels.Abstraction
{
    using System;

    public interface IDataModel
    {
        long Id { get; set; }

        string CreatedBy { get; set; }
        DateTime CreatedOn { get; set; }

        string ModifiedBy { get; set; }
        DateTime? ModifiedOn { get; set; }

        bool IsDeleted { get; set; }
        DateTime? DeletedOn { get; set; }
    }
}
