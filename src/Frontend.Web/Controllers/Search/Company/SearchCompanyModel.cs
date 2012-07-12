using System.Collections.Generic;
using System.Linq;
using GwoDb;

public class SearchCompanyModel : SearchModelBase
{
    public List<SearchCompanyModelDetail> Organisations;

    public void Init(IEnumerable<Company> orgas, CompanySearchSpec searchSpec)
    {
        Organisations = orgas.Select(org =>
                            new SearchCompanyModelDetail
                            {
                                Name = org.Name, 
                                Location = org.Location, 
                                Url = org.Url, 
                                Industry =  org.Industry, 
                                Size =  org.Size, 
                                Balance2011 = org.WelfareBalanceFor2011,
                                Balance2012 = org.WelfareBalanceFor2012,
                                Id = org.Id
                            }).ToList();

        Pager = new PagerModel(searchSpec);
        if (searchSpec.Filter.TextSearch.Items.Any())
            SearchTerm = searchSpec.Filter.TextSearch.Items.Aggregate((current, next) => current + " " + next);
        ResultCount = searchSpec.TotalItems;
    }
}