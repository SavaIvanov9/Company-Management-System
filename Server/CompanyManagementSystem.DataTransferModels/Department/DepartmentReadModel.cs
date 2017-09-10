namespace CompanyManagementSystem.DataTransferModels.Department
{
    using Abstraction;
    using System.Collections.Generic;
    using Team;

    public class DepartmentReadModel : BaseReadModel, IDepartmentModel
    {
        public string Name { get; set; }

        public ICollection<ITeamModel> Teams { get; set; }
    }
}
