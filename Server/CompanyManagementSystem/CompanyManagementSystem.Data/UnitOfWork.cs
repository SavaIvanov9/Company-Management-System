namespace CompanyManagementSystem.Data
{
    using System;
    using System.Collections.Generic;
    using Abstraction;
    using DbModels;
    using Repositories;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly IManagementSystemDbContext context;
        private readonly IDictionary<Type, object> repositories;

        public UnitOfWork()
            : this(new ManagementSystemDbContext())
        {
        }

        public UnitOfWork(IManagementSystemDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public CookieRepository CookieRepository =>
            (CookieRepository)this.GetRepository<Cookie>();

        public EmployeeRepository EmployeeRepository =>
            (EmployeeRepository)this.GetRepository<Employee>();

        public PositionRepository PositionRepository =>
            (PositionRepository)this.GetRepository<Position>();

        public PermissionRepository PermissionRepository =>
            (PermissionRepository)this.GetRepository<Permission>();

        public TeamRepository TeamRepository =>
            (TeamRepository)this.GetRepository<Team>();

        public DepartmentRepository DepartmentRepository =>
            (DepartmentRepository)this.GetRepository<Department>();

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var repositoryType = typeof(T);

            if (!this.repositories.ContainsKey(repositoryType))
            {
                var type = typeof(GenericRepository<T>);

                this.SetType(repositoryType, ref type);

                this.repositories.Add(repositoryType, Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[repositoryType];
        }

        private void SetType(Type repositoryType, ref Type type)
        {
            if (repositoryType.IsAssignableFrom(typeof(Employee)))
                type = typeof(EmployeeRepository);
            else if (repositoryType.IsAssignableFrom(typeof(Position)))
                type = typeof(PositionRepository);
            else if (repositoryType.IsAssignableFrom(typeof(Permission)))
                type = typeof(PermissionRepository);
            else if (repositoryType.IsAssignableFrom(typeof(Team)))
                type = typeof(TeamRepository);
            else if (repositoryType.IsAssignableFrom(typeof(Department)))
                type = typeof(DepartmentRepository);
            else if (repositoryType.IsAssignableFrom(typeof(Cookie)))
                type = typeof(CookieRepository);
        }
    }
}
