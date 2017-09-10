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
            Database.SetInitializer(new DropCreateDatabaseAlways<ManagementSystemDbContext>());
            this.InsertTestData();
            this.DisplayStatus();

            Console.WriteLine(this.data.EmployeeRepository.All().FirstOrDefault().Teams.Count);
        }

        public void InsertTestData()
        {
            this.AddDefaults();
            this.AddDepartments(10);
            this.AddTeams(10);
            this.AddEmployees(10);

            Console.WriteLine(this.data.PermissionRepository.All().ToList().Count);
            Console.WriteLine(this.data.PositionRepository.All().ToList().Count);
            Console.WriteLine(this.data.EmployeeRepository.All().ToList().Count);
        }

        private void AddDefaults()
        {
            var db = new UnitOfWork();

            Console.WriteLine(db.PermissionRepository.All().ToList().Count);
            Console.WriteLine(db.PositionRepository.All().ToList().Count);
            Console.WriteLine(db.EmployeeRepository.All().ToList().Count);

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
                Name = "Regular Developer",
                CreatedBy = "S"
            };

            possition1.Permissions.Add(per1);
            possition1.Permissions.Add(per2);

            db.PositionRepository.Add(possition1);

            var possition2 = new Position()
            {
                Name = "Senior Developer",
                CreatedBy = "S"
            };

            possition2.Permissions.Add(per1);
            possition2.Permissions.Add(per2);

            db.PositionRepository.Add(possition2);

            db.EmployeeRepository
                .Add(new Employee()
                {
                    Username = "User1",
                    Password = "12345",
                    FirstName = "Test first name",
                    LastName = "Test last name",
                    Age = 100,
                    Email = "Email",
                    Position = possition2,
                    CreatedBy = "S"
                });

            db.SaveChanges();

        }

        private void AddDepartments(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var department = new Department()
                {
                    Name = $"Department {i}",
                    Description = $"This is test department number: {i}",
                    CreatedBy = "S"
                };

                this.data.DepartmentRepository.Add(department);
            }

            this.data.SaveChanges();
        }

        private void AddTeams(int count)
        {
            var department1 = this.data.DepartmentRepository
                .All()
                .FirstOrDefault();

            var department2 = this.data.DepartmentRepository
                .All()
                .OrderBy(x => x.Id)
                .Skip(1)
                .FirstOrDefault();

            for (int i = 0; i < count; i++)
            {
                var team = new Team()
                {
                    Name = $"Team {i}",
                    DepartmentId = i % 2 == 0 ? department1.Id : department2.Id,
                    CreatedBy = "S"
                };

                this.data.TeamRepository.Add(team);
            }

            this.data.SaveChanges();
        }

        public void AddEmployees(int count)
        {
            var team1 = this.data.TeamRepository
                .All()
                .FirstOrDefault();

            var team2 = this.data.TeamRepository
                .All()
                .OrderBy(x => x.Id)
                .Skip(1)
                .FirstOrDefault();

            var manager = this.data.EmployeeRepository
                .All()
                .FirstOrDefault();

            var possition1 = this.data.PositionRepository
                .All()
                .FirstOrDefault();

            var possition2 = this.data.PositionRepository
                .All()
                .OrderBy(x => x.Id)
                .Skip(1)
                .FirstOrDefault();
            
            for (int i = 0; i < count; i++)
            {
                var employee = new Employee()
                {
                    ManagerId = manager.Id,

                    Username = "User1",
                    Password = "12345",
                    FirstName = "Test first name",
                    LastName = "Test last name",
                    Age = 20 + i,
                    Email = $"Email {i}",
                    PositionId = i % 2 == 0 ? possition1.Id : possition2.Id,
                    CreatedBy = "S",
                };

                employee.Teams.Add(i % 2 == 0 ? team1 : team2);

                if (i % 2 == 0)
                {
                    team1.Employees.Add(employee);
                    this.data.TeamRepository.Update(team1);
                }
                else
                {
                    team2.Employees.Add(employee);
                    this.data.TeamRepository.Update(team2);
                }

                this.data.EmployeeRepository.Add(employee);
            }

            this.data.SaveChanges();
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
