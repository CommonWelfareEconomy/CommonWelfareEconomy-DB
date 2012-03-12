using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GwoDb.Infrastructure;

namespace GwoDb.Tools.Import
{
    public class ImporterOrganisations : IRegisterAsInstancePerLifetime
    {
        private readonly ImporterAggregatedRows _importerAggregatedRows;

        public ImporterOrganisations(ImporterAggregatedRows importerAggregatedRows)
        {
            _importerAggregatedRows = importerAggregatedRows;
        }

        public List<Organisation> Run()
        {
            var result = new List<Organisation>();
            var aggregatedRows = _importerAggregatedRows.Run();
            foreach(var aggregatedRow in aggregatedRows)
            {
                if (!aggregatedRow.IsCompany())
                    continue;

                var organisation = new Organisation();
                organisation.Name = aggregatedRow.GetName();
                organisation.Location = aggregatedRow.GetLocation();
                organisation.Url = aggregatedRow.GetUrl();
                organisation.Industry = aggregatedRow.GetBranche();
                organisation.Size = aggregatedRow.GetBeschaeftigte();
                organisation.WelfareBalanceFor2011 = aggregatedRow.IsBilanz2011();
                organisation.WelfareBalanceFor2012 = aggregatedRow.IsBilanz2012();
                organisation.Email = aggregatedRow.GetEmail();

                result.Add(organisation);
            }

            return result;
        }

    }
}
