namespace CompanyManagementSystem.Services.Abstraction
{
    using DbModels;
    using System.Collections.Generic;
    using System.Linq;

    public interface IPositionService
    {
        IQueryable<Position> GetAll();
    }
}
