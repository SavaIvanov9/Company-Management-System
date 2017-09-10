namespace CompanyManagementSystem.Services
{
    using Abstraction;
    using Base;
    using Data.Abstraction;
    using DbModels;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class PositionService : BaseService, IPositionService
    {
        public PositionService(IUnitOfWork data) : base(data)
        {
        }

        public IQueryable<PositionViewModel> GetAll()
        {
            var result = this.data.PositionRepository
                .All()
                .Where(x => !x.IsDeleted)
                .Select(x => new PositionViewModel()
                {
                    Id = x.Id,
                    Name = x.Name
                });

            return result;
        }
    }
}
