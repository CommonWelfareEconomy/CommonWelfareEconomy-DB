using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GwoDb.Infrastructure;

namespace GwoDb.Tools.Import
{
    public class ImporterAggregatedRows : IRegisterAsInstancePerLifetime
    {
        private readonly Importer _importer;

        public ImporterAggregatedRows(Importer importer)
        {
            _importer = importer;
        }

        public List<ImporterResultRowsAggregated> Run()
        {
            return Run(_importer.Run());
        }

        private List<ImporterResultRowsAggregated> Run(IEnumerable<ImporterResultRow> rows)
        {
            var result = new List<ImporterResultRowsAggregated>();
            foreach(var row in rows)
            {
                var aggregatedRow = result.Find(x => x.SubId == row.SubId);
                if(aggregatedRow == null){
                    aggregatedRow = new ImporterResultRowsAggregated();
                    result.Add(aggregatedRow);
                }
                aggregatedRow.SubId = row.SubId;
                aggregatedRow.Rows.Add(row);
            }

            return result;
        } 
    }
}
