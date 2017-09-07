namespace CompanyManagementSystem.DataImporter
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Data;
    using Data.Abstraction;
    using DbModels;

    public class ImporterEngine
    {
        private readonly IUnitOfWork data = new UnitOfWork();

        public void Start()
        {
            // Database.SetInitializer(new DropCreateDatabaseAlways<ManagementSystemDbContext>());
            // this.InsertTestData();
            this.DisplayStatus();
        }

        public void InsertTestData()
        {
            var db = new UnitOfWork();

            Console.WriteLine(db.PermissionRepository.All().ToList().Count);
            Console.WriteLine(db.PositionRepository.All().ToList().Count);
            Console.WriteLine(db.EmployeeRepository.All().ToList().Count); ;

            var per1 = new Permission()
            {
                Code = "Write",
                CreatedBy = "S"
            };

            db.PermissionRepository
                .Add(per1);

            var per2 = new Permission()
            {
                Code = "Read",
                CreatedBy = "S"
            };

            db.PermissionRepository
                .Add(per2);

            var possition1 = new Position()
            {
                Name = "Developer",
                CreatedBy = "S"
            };

            possition1.Permissions.Add(per1);
            possition1.Permissions.Add(per2);

            db.PositionRepository
                .Add(possition1);

            db.EmployeeRepository
                .Add(new Employee()
                {
                    FirstName = "Test first name",
                    LastName = "Test last name",
                    Age = 100,
                    Email = "Email",
                    Position = possition1,
                    CreatedBy = "S"
                });

            db.SaveChanges();

            Console.WriteLine(db.PermissionRepository.All().ToList().Count);
            Console.WriteLine(db.PositionRepository.All().ToList().Count);
            Console.WriteLine(db.EmployeeRepository.All().ToList().Count);
        }

        public void DisplayStatus()
        {
            var permissions = this.data.PermissionRepository.All().ToList();
            foreach (var p in permissions)
            {
                Console.WriteLine(p.Id);
                Console.WriteLine(p.Code);
                Console.WriteLine(p.Positions.Count);
            }

            Console.WriteLine();

            var positions = this.data.PositionRepository.All().ToList();
            foreach (var p in positions)
            {
                Console.WriteLine(p.Id);
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Permissions.Count);
                Console.WriteLine(p.Employees.Count);
            }

            Console.WriteLine();

            var employees = this.data.EmployeeRepository.All().ToList();
            foreach (var e in employees)
            {
                Console.WriteLine(e.Id);
                Console.WriteLine(e.FirstName);
                Console.WriteLine(e.LastName);
                Console.WriteLine(e.Age);
                Console.WriteLine(e.Email);
                Console.WriteLine(e.PositionId);
            }
        }
    }
}
