namespace CompanyManagementSystem.Services.Abstraction
{
    using DbModels;
    using System.Collections.Generic;

    public interface IPositionService
    {
        IEnumerable<Position> GetAll();
    }
}
