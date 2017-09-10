namespace CompanyManagementSystem.Data.Abstraction
{
    using Repositories;

    public interface IUnitOfWork
    {
        CookieRepository CookieRepository { get; }

        EmployeeRepository EmployeeRepository { get; }

        PositionRepository PositionRepository { get; }

        PermissionRepository PermissionRepository { get; }

        TeamRepository TeamRepository { get; }

        DepartmentRepository DepartmentRepository { get; }

        int SaveChanges();
    }
}
