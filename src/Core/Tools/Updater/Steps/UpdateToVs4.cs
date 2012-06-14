using GwoDb.Infrastructure.Persistence;

namespace GwoDb.Updates
{
    public class UpdateToVs4
    {
        public static void Run()
        {
            Sl.Resolve<ExecuteSqlFile>().Run(ScriptPath.Get("4-add-table-politician-and-person.sql"));
        }
    }
}