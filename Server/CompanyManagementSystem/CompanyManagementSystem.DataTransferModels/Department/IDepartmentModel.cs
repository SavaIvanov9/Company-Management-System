namespace CompanyManagementSystem.DataTransferModels.Department
{
    using System.Collections.Generic;
    using Team;

    public interface IDepartmentModel
    {
        string Name { get; set; }

        ICollection<ITeamModel> Teams { get; set; }
    }
}
