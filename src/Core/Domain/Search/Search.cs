using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GwoDb.Domain.Search
{
    public class Search
    {
        private readonly OrganisationRepository _organisationRepository;

        public Search(OrganisationRepository organisationRepository)
        {
            _organisationRepository = organisationRepository;
        }

        public SearchResult Run()
        {
            var searchSpec = new OrganisationSearchSpec();
            var organisations =  _organisationRepository.GetBy(searchSpec);

            var result = new SearchResult();
            result.Items = from orga in organisations
                           select new SearchResultItem(orga);

            return result;
        }
    }
}
