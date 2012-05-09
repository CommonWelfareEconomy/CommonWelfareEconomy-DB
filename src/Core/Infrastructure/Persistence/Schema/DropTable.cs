using System;
using NHibernate;

namespace GwoDb.Infrastructure.Persistence
{
    public class DropTable
    {
        private readonly ISession _session;

        public DropTable(ISession session) { _session = session; }

        public void Run(string tableName)
        {
            _session.CreateSQLQuery(
                String.Format("DROP TABLE {0}", tableName))
                .ExecuteUpdate();
        }
    }
}
