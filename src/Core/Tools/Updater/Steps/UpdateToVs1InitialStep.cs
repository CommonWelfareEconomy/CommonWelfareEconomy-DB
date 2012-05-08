using GwoDb.Infrastructure;
using GwoDb.Infrastructure.Persistence;

namespace GwoDb.Updates
{
    public static class UpdateToVs1InitialStep
    {
        public static void Run()
        {
            ServiceLocator.Resolve<ExecuteSqlFile>().Run("Tools/Updater/Scripts/1-initial.sql");
            CreateInitialRecord();
        }

        private static void CreateInitialRecord()
        {
            var dbSettingsRepository = ServiceLocator.Resolve<DbSettingsRepository>();
            var dbSettings = new DbSettings { AppVersion = 1 };
            dbSettingsRepository.Create(dbSettings);
        }
    }
}