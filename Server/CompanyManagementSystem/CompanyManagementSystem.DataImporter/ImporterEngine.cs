namespace CompanyManagementSystem.DataImporter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Data;
    using DbModels;

    public class ImporterEngine
    {
        public void Start()
        {
            var db = new ManagementSystemDbContext();
            Console.WriteLine(db.Permissions.Count());

            db.Permissions.Add(new Permission()
            {
                Code = "Read"
            });

            db.SaveChanges();

            Console.WriteLine(db.Permissions.Count());
        }
    }
}
