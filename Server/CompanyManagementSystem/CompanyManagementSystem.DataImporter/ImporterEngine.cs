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
            var db = new UnitOfWork();
            Console.WriteLine(db.PermissionRepository.All().ToList().Count);

            db.PermissionRepository
                .Add(new Permission()
                {
                    Code = "Write",
                    CreatedBy = "S"
                });

            db.SaveChanges();

            Console.WriteLine(db.PermissionRepository.All().ToList().Count);
        }
    }
}
