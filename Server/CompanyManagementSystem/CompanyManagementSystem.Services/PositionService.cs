namespace CompanyManagementSystem.Services
{
    using Abstraction;
    using Base;
    using Data.Abstraction;
    using DbModels;
    using System.Collections.Generic;
    using System.Linq;

    public class PositionService : BaseService, IPositionService
    {
        public PositionService(IUnitOfWork data) : base(data)
        {
        }

        public IEnumerable<Position> GetAll()
        {
            var result = this.data.PositionRepository
                .All()
                .Where(x => !x.IsDeleted);

            return result;
        }
    }
}
