using GwoDb.Infrastructure.Persistence;

namespace GwoDb.Updates
{
    public class UpdateToVs3
    {
        public static void Run()
        {
            Sl.Resolve<ExecuteSqlFile>().Run(ScriptPath.Get("3-add-club-table.sql"));            
        }
    }
}
