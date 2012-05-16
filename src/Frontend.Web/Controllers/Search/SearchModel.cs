using System.Collections.Generic;
using System.Linq;
using GwoDb;

public class SearchModel
{
    public SearchModel(){}

    public SearchModel(IEnumerable<Organisation> organisations, PagerModel pagerModel)
    {

        Organisations = organisations.Select(org => 
                            new SearchModelOrganisationDetail
                                {
                                    Name = org.Name
                                }).ToList();

        Pager = pagerModel;
    }

    public Message Message;
    public PagerModel Pager { get; set; }

    public string SearchTerm;
    public int ResultCount;

    public List<SearchModelOrganisationDetail> Organisations;
}

public class SearchModelOrganisationDetail
{
    public string Name;
}