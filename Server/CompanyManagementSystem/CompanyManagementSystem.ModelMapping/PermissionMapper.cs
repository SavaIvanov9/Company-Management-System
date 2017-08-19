namespace CompanyManagementSystem.ModelMapping
{
    using Abstraction;
    using DataTransferModels.Permission;
    using DbModels;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Linq.Expressions;

    public class PermissionMapper : IPermissionMapper
    {
        //private readonly IPositionMapper possitionMapper;

        //public PermissionMapper(IPositionMapper possitionMapper)
        //{
        //    this.possitionMapper = possitionMapper;
        //}

        public Expression<Func<Permission, PermissionReadModel>> MapDbModelToDtm()
        {
            Expression<Func<Permission, PermissionReadModel>> expression =
                (e) => (new PermissionReadModel()
                {
                    Id = e.Id,
                    CreatedOn = e.CreatedOn,
                    CreatedBy = e.CreatedBy,
                    ModifiedOn = e.ModifiedOn,
                    ModifiedBy = e.ModifiedBy,
                    IsDeleted = e.IsDeleted,
                    DeletedOn = e.DeletedOn,

                    Code = e.Code,
                    //Positions = this.possitionMapper.MapDbCollectionToDtm()
                    //    .Compile()
                    //    .Invoke(e.Positions)
                });

            return expression;
        }

        public Expression<Func<ICollection<Permission>, ICollection<PermissionReadModel>>> MapDbCollectionToDtm()
        {
            Expression<Func<ICollection<Permission>, ICollection<PermissionReadModel>>> expression =
                (pc) => new Collection<PermissionReadModel>(
                    pc.Select(p => this.MapDbModelToDtm().Compile().Invoke(p))
                        .ToList());

            return expression;
        }
    }
}
