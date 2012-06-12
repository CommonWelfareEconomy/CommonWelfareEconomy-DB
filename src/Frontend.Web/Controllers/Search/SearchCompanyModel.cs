using System.Collections.Generic;
using System.Linq;
using GwoDb;
using GwoDb.Web.Context;

public class SearchCompanyModel
{
    public Message Message;
    public PagerModel Pager { get; set; }

    public string SearchTerm { get; set; }
    public int ResultCount { get; set; }

    public List<SearchModelCompanyDetail> Organisations;

    public SearchCompanyModel()
    {
    }

    public void Init(IEnumerable<Company> orgas, CompanySearchSpec searchSpec)
    {
        Organisations = orgas.Select(org =>
                            new SearchModelCompanyDetail
                            {
                                Name = org.Name, 
                                Location = org.Location, 
                                Url = org.Url, 
                                Industry =  org.Industry, 
                                Size =  org.Size, 
                                Balance2011 = org.WelfareBalanceFor2011,
                                Balance2012 = org.WelfareBalanceFor2012
                            }).ToList();

        Pager = new PagerModel(searchSpec);
        if (searchSpec.Filter.TextSearch.Items.Any())
            SearchTerm = searchSpec.Filter.TextSearch.Items.Aggregate((current, next) => current + " " + next);
        ResultCount = searchSpec.TotalItems;
    }
}