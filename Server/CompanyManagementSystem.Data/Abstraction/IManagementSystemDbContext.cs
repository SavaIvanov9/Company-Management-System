namespace CompanyManagementSystem.Data.Abstraction
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using DbModels;

    public interface IManagementSystemDbContext : IDisposable
    {
        IDbSet<Employee> Employees { get; set; }

        IDbSet<Position> Positions { get; set; }

        IDbSet<Permission> Permissions { get; set; }

        IDbSet<Team> Teams { get; set; }

        IDbSet<Department> Departments { get; set; }

        int SaveChanges();

        IDbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;
    }
}
