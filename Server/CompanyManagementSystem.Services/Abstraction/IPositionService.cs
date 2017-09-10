namespace CompanyManagementSystem.Services.Abstraction
{
    using DbModels;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public interface IPositionService
    {
        IQueryable<PositionViewModel> GetAll();
    }
}
