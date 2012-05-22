using System.Collections.Generic;
using System.Linq;
using GwoDb;
using GwoDb.Web.Context;

public class SearchModel
{
    public Message Message;
    public PagerModel Pager { get; set; }

    public string SearchTerm { get; set; }
    public int ResultCount { get; set; }

    public List<SearchModelOrganisationDetail> Organisations;

    public SearchModel()
    {
    }

    public void Init(IEnumerable<Organisation> orgas, OrganisationSearchSpec searchSpec)
    {
        Organisations = orgas.Select(org =>
                            new SearchModelOrganisationDetail
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
        SearchTerm = searchSpec.Filter.Name.Value;
        ResultCount = searchSpec.TotalItems;
    }
}