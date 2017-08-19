namespace ConsoleTestGround
{
    using System;
    using System.Linq;
    using CompanyManagementSystem.Data;
    using CompanyManagementSystem.ModelMapping;
    using CompanyManagementSystem.Services;
    using CompanyManagementSystem.Services.Abstraction;

    class Launcher
    {
        static void Main(string[] args)
        {
            IEmployeeService service = new EmployeeService(
                new UnitOfWork(),
                new EmployeeMapper(
                    new PositionMapper(
                        new PermissionMapper())));

            var query = service.GetAll();
            Console.WriteLine(query);
            var result = query.ToList();
        }
    }
}
