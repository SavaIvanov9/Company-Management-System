namespace CompanyManagementSystem.ModelMapping
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Linq.Expressions;
    using Abstraction;
    using DataTransferModels.Position;
    using DbModels;

    public class PositionMapper : IPositionMapper
    {
        private readonly IPermissionMapper permissionMapper;

        public PositionMapper(IPermissionMapper permissionMapper)
        {
            this.permissionMapper = permissionMapper;
        }

        public Expression<Func<Position, PositionReadModel>> MapDbModelToDtm()
        {
            Expression<Func<Position, PositionReadModel>> expression =
                (p) => (new PositionReadModel()
                {
                    Id = p.Id,
                    CreatedOn = p.CreatedOn,
                    CreatedBy = p.CreatedBy,
                    ModifiedOn = p.ModifiedOn,
                    ModifiedBy = p.ModifiedBy,
                    IsDeleted = p.IsDeleted,
                    DeletedOn = p.DeletedOn,

                    Name = p.Name,
                    Permissions = this.permissionMapper.MapDbCollectionToDtm()
                        .Compile()
                        .Invoke(p.Permissions)
                });

            return expression;
        }

        public Expression<Func<ICollection<Position>, ICollection<PositionReadModel>>> MapDbCollectionToDtm()
        {
            Expression<Func<ICollection<Position>, ICollection<PositionReadModel>>> expression =
                (pc) => new Collection<PositionReadModel>(
            //pc.Select(p => new PositionReadModel()
            //{
            //    Id = p.Id,
            //    CreatedOn = p.CreatedOn,
            //    CreatedBy = p.CreatedBy,
            //    ModifiedOn = p.ModifiedOn,
            //    ModifiedBy = p.ModifiedBy,
            //    IsDeleted = p.IsDeleted,
            //    DeletedOn = p.DeletedOn,

            //    Name = p.Name
            //})
            //.ToList());
            pc.Select(p => this.MapDbModelToDtm().Compile().Invoke(p))
            .ToList());


            return expression;
        }
    }
}
