using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GwoDb.Domain.Search
{
    public class Search
    {
        private readonly CompanyRepository _companyRepository;

        public Search(CompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public SearchResult Run()
        {
            var searchSpec = new CompanySearchSpec();
            var organisations =  _companyRepository.GetBy(searchSpec);

            var result = new SearchResult();
            result.Items = from orga in organisations
                           select new SearchResultItem(orga);

            return result;
        }
    }
}
