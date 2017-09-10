namespace CompanyManagementSystem.ModelMapping
{
    using System;
    using System.Linq.Expressions;
    using Abstraction;
    using DataTransferModels.Employee;
    using DataTransferModels.Position;
    using DbModels;

    public class EmployeeMapper : IEmployeeMapper
    {
        private IPositionMapper positionMapper;

        public EmployeeMapper(IPositionMapper positionMapper)
        {
            this.positionMapper = positionMapper;
        }

        public Expression<Func<Employee, EmployeeReadModel>> MapDbModelToDtm()
        {
            Expression<Func<Employee, EmployeeReadModel>> expression =
                (e) => (new EmployeeReadModel()
                {
                    Id = e.Id,
                    CreatedOn = e.CreatedOn,
                    CreatedBy = e.CreatedBy,
                    ModifiedOn = e.ModifiedOn,
                    ModifiedBy = e.ModifiedBy,
                    IsDeleted = e.IsDeleted,
                    DeletedOn = e.DeletedOn,

                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Age = e.Age,
                    Email = e.Email,
                    ManagerId = e.ManagerId,
                    PositionId = e.PositionId,
                    //Manager = e.Manager
                    //Teams = e.Teams
                    //Position = this.positionMapper.MapDbModelToDtm()
                    //    .Compile().Invoke(e.Position)
                    Position = this.x().Invoke(e.Position)
                });

            return expression;
        }

        private Func<Position, PositionReadModel> x()
        {
            Func<Position, PositionReadModel> expression =
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
                    //Permissions = this.permissionMapper.MapDbCollectionToDtm()
                    //    .Compile()
                    //    .Invoke(p.Permissions)
                });

            return expression;
        }
    }
}
