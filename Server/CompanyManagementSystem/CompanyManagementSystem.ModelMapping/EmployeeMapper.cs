namespace CompanyManagementSystem.ModelMapping
{
    using System;
    using System.Linq.Expressions;
    using Abstraction;
    using DataTransferModels.Employee;
    using DbModels;

    public class EmployeeMapper : IEmployeeMapper
    {
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
                    //Position = e.Position
                    //Teams = e.Teams
                });

            return expression;
        }
    }
}
