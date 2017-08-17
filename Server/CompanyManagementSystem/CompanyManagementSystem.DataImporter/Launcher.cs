namespace CompanyManagementSystem.DataImporter
{
    class Launcher
    {
        static void Main(string[] args)
        {
            var engine = new ImporterEngine();
            engine.Start();
        }
    }
}
