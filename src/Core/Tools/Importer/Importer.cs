using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GwoDb.Infrastructure;
using NHibernate;

namespace GwoDb.Tools.Import
{
    public class Importer : IRegisterAsInstancePerLifetime
    {
        private readonly ISession _session;

        public Importer(ISession session){ _session = session; }

        public List<ImporterResultRow> Run()
        {
            var result = _session.CreateSQLQuery("select * from wp_gwo_cformsdata as form " +
                                                 "left join wp_gwo_cformssubmissions as submission " +
                                                 "on form.sub_Id = submission.id ").List();

            var listOfResultRow = new List<ImporterResultRow>();

            foreach(object[] resultItem in result)
            {
                var resultRow = new ImporterResultRow();
                listOfResultRow.Add(resultRow);

                resultRow.SubId = (int)resultItem[1];
                resultRow.FieldName = (string)resultItem[2];
                resultRow.FieldValue = (string)resultItem[3];
                resultRow.FormId = Convert.ToInt32(resultItem[5]);
            }

            return listOfResultRow;
        }
    }
}
