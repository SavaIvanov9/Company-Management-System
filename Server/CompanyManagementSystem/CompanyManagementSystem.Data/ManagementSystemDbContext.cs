namespace CompanyManagementSystem.Data
{
    using System.Data.Entity;
    using Abstraction;
    using DbModels;

    public class ManagementSystemDbContext : DbContext, IManagementSystemDbContext
    {
        public ManagementSystemDbContext() : base("CompanyManagementSystem")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ManagementSystemDbContext, Configuration>());

            //Database.SetInitializer(new DropCreateDatabaseAlways<ManagementSystemDbContext>());
        }

        public virtual IDbSet<Employee> Employees { get; set; }

        public virtual IDbSet<Position> Positions { get; set; }

        public virtual IDbSet<Permission> Permissions { get; set; }

        public virtual IDbSet<Team> Teams { get; set; }

        public virtual IDbSet<Department> Departments { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Manager)
                .WithMany()
                .HasForeignKey(m => m.ManagerId);

            modelBuilder.Entity<Employee>()
                .HasMany<Team>(e => e.Teams)
                .WithMany(t => t.Employees)
                .Map(cs =>
                {
                    cs.MapLeftKey("EmployeeId");
                    cs.MapRightKey("TeamId");
                    cs.ToTable("EmployeesTeams");
                });

            modelBuilder.Entity<Position>()
                .HasMany<Permission>(po => po.Permissions)
                .WithMany(pe => pe.Positions)
                .Map(cs =>
                {
                    cs.MapLeftKey("Positiond");
                    cs.MapRightKey("PermissionId");
                    cs.ToTable("PositionsPermissions");
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
