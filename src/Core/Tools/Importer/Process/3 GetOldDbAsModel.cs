using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GwoDb.Infrastructure;

namespace GwoDb.Tools.Import
{
    public class GetOldDbAsModelResult
    {
        public List<Organisation> Organisations;
    }

    public class GetOldDbAsModel : IRegisterAsInstancePerLifetime
    {
        private readonly GetOldDbAsAggregatedRows _getOldDbAsAggregatedRows;

        public GetOldDbAsModel(GetOldDbAsAggregatedRows getOldDbAsAggregatedRows)
        {
            _getOldDbAsAggregatedRows = getOldDbAsAggregatedRows;
        }

        public GetOldDbAsModelResult Run()
        {
            var organisations = new List<Organisation>();
            var aggregatedRows = _getOldDbAsAggregatedRows.Run();
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

                organisations.Add(organisation);
            }

            return new GetOldDbAsModelResult{Organisations = organisations};
        }

    }
}
