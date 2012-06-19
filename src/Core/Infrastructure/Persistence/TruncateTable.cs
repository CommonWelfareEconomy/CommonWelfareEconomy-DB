using System.Collections.Generic;
using NHibernate;

namespace GwoDb.Infrastructure.Persistence
{
    public class TruncateTable : IRegisterAsInstancePerLifetime
    {
        private readonly ISession _session;

        public TruncateTable(ISession session){
            _session = session;
        }

        public void Run(IEnumerable<string> tableNames){
            foreach(var tableName in tableNames)
                Run(tableName);
        }

        public void Run(string tableName){
            _session.CreateSQLQuery("truncate table " + tableName).ExecuteUpdate();
        }
    }
}
