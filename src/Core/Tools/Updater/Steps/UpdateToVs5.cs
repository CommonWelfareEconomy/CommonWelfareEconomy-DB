using GwoDb.Infrastructure.Persistence;

namespace GwoDb.Updates
{
    public class UpdateToVs5
    {
        public static void Run()
        {
            Sl.Resolve<ExecuteSqlFile>().Run(ScriptPath.Get("5-create-tbl-persistentLogin.sql"));
        }
    }
}
