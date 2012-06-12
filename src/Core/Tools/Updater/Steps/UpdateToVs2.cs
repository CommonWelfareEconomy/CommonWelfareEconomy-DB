using GwoDb.Infrastructure.Persistence;

namespace GwoDb.Updates
{
    public static class UpdateToVs2
    {
        public static void Run()
        {
            ServiceLocator.Resolve<ExecuteSqlFile>().Run("Tools/Updater/Scripts/2-rename-table-organisation.sql");
        }
    }
}
