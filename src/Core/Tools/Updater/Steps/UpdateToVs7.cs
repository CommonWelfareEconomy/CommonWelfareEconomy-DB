using GwoDb.Infrastructure.Persistence;
using GwoDb.Updates;

namespace GwoDb.Tools.Updater.Steps
{
    public class UpdateToVs7
    {
        public static void Run()
        {
            Sl.Resolve<ExecuteSqlFile>().Run(ScriptPath.Get("7-new-field-country-Iso3-in-tbl-company.sql"));
        }
    }
}
