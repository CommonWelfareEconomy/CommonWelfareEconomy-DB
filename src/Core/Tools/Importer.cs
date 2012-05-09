using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GwoDb.Infrastructure;
using NHibernate;

namespace GwoDb.Tools
{
    public class Importer : IRegisterAsInstancePerLifetime
    {
        private readonly ISession _session;

        public Importer(ISession session){ _session = session; }

        public void Run()
        {
            var result = _session.CreateSQLQuery("select * from wp_gwo_cformsdata as form " +
                                                 "left join wp_gwo_cformssubmissions as submission " +
                                                 "on form.sub_Id = submission.id ").List();

            var listOfResultRow = new List<ImporterResultRows>();

            foreach(object[] resultItem in result)
            {
                var resultRow = new ImporterResultRows();
                listOfResultRow.Add(resultRow);

                resultRow.SubId = (int)resultItem[1];
                resultRow.FieldName = (string)resultItem[2];
                resultRow.FieldValue = (string)resultItem[3];
                resultRow.FormId = (int)resultItem[4];
            }

        }
    }

    public class ImporterResultRows
    {
        public int SubId;
        public string FieldName;
        public string FieldValue;
        public int FormId;
        public DateTime SubDate;
        public string Email;
        public string Ip;
    }



}
