﻿using GwoDb.Infrastructure.Persistence;

namespace GwoDb.Updates
{
    public static class UpdateToVs2
    {
        public static void Run()
        {
            Sl.Resolve<ExecuteSqlFile>().Run(ScriptPath.Get("2-rename-table-organisation.sql"));
        }
    }
}
