using System.Collections.Generic;
using System.Linq;
using GwoDb;

public class SearchModel
{
    public Message Message;
    public PagerModel Pager { get; set; }

    public string SearchTerm { get; set; }
    public int ResultCount { get; set; }

    public List<SearchModelOrganisationDetail> Organisations;

    public SearchModel()
    {
        SearchTerm = "";
    }

    public void Init(IEnumerable<Organisation> orgas, PagerModel pagerModel)
    {
        Organisations = orgas.Select(org =>
                            new SearchModelOrganisationDetail
                            {
                                Name = org.Name
                            }).ToList();

        Pager = pagerModel;
    }
}

public class SearchModelOrganisationDetail
{
    public string Name;
}