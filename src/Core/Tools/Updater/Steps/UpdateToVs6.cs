using GwoDb.Infrastructure.Persistence;
using GwoDb.Updates;

namespace GwoDb.Tools.Updater.Steps
{
    public class UpdateToVs6
    {
        public static void Run()
        {
            Sl.Resolve<ExecuteSqlFile>().Run(ScriptPath.Get("6-countries.sql"));
        }
    }
}
