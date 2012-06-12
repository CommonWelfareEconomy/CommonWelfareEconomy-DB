using System;
using System.Collections.Generic;
using GwoDb.Infrastructure;

namespace GwoDb.Tools.Import
{
    public class GetOldDbAsModel : IRegisterAsInstancePerLifetime
    {
        private readonly GetOldDbAsAggregatedRows _getOldDbAsAggregatedRows;

        public GetOldDbAsModel(GetOldDbAsAggregatedRows getOldDbAsAggregatedRows)
        {
            _getOldDbAsAggregatedRows = getOldDbAsAggregatedRows;
        }

        public GetOldDbAsModelResult Run()
        {
            var organisations = new List<Company>();
            var clubs = new List<Club>();
            var politicians = new List<Politician>();
            var persons = new List<Person>();

            var aggregatedRows = _getOldDbAsAggregatedRows.Run();
            foreach(var aggregatedRow in aggregatedRows)
            {
                if (aggregatedRow.IsCompany())
                    organisations.Add(GetCompany(aggregatedRow));

                if (aggregatedRow.IsClub())
                    clubs.Add(GetClub(aggregatedRow));

                if (aggregatedRow.IsPolitician())
                    politicians.Add(GetPolitician(aggregatedRow));

                if(aggregatedRow.IsPerson())
                    persons.Add(GetPerson(aggregatedRow));
            }

            return new GetOldDbAsModelResult
                       {
                           Organisations = organisations,
                           Clubs = clubs,
                           Politicians = politicians, 
                           Persons = persons
                       };
        }

        private static Company GetCompany(ImporterResultRowsAggregated aggregatedRow)
        {
            var organisation = new Company();
            organisation.Name = aggregatedRow.GetName();
            organisation.Location = aggregatedRow.GetLocation();
            organisation.Url = aggregatedRow.GetUrl();
            organisation.Industry = aggregatedRow.GetBranche();
            organisation.Size = aggregatedRow.GetBeschaeftigte();
            organisation.WelfareBalanceFor2011 = aggregatedRow.IsBilanz2011();
            organisation.WelfareBalanceFor2012 = aggregatedRow.IsBilanz2012();
            organisation.Email = aggregatedRow.GetEmail();
            return organisation;
        }

        private static Club GetClub(ImporterResultRowsAggregated aggregatedRow)
        {
            var club = new Club();
            club.Url = aggregatedRow.GetUrl();
            club.Email = aggregatedRow.GetEmail();
            club.Location = aggregatedRow.GetLocation();
            club.AreaOfWork = aggregatedRow.GetTaetigkeitsfeld();
            club.Name = aggregatedRow.GetName();
            return club;
        }

        private Person GetPerson(ImporterResultRowsAggregated aggregatedRow)
        {
            var person = new Person();
            person.Name = aggregatedRow.GetName();
            person.Email = aggregatedRow.GetEmail();
            person.Job = aggregatedRow.GetBeruf();
            person.Location = aggregatedRow.GetLocation();
            person.Url = aggregatedRow.GetUrl();
            return person;
        }

        private Politician GetPolitician(ImporterResultRowsAggregated aggregatedRow)
        {
            var politician = new Politician();
            politician.Capacity = aggregatedRow.GetPoliticalFunction();
            politician.Email = aggregatedRow.GetEmail();
            politician.Location = aggregatedRow.GetLocation();
            politician.Name = aggregatedRow.GetName();
            politician.Url = aggregatedRow.GetUrl();
            return politician;
        }
    }
}
