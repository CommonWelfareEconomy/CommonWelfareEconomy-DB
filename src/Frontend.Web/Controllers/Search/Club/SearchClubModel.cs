using System.Collections.Generic;
using System.Linq;
using GwoDb;

public class SearchClubModel : SearchModelBase
{
    public List<SearchClubModelDetail> Clubs;

    public void Init(IEnumerable<Club> clubs, ClubSearchSpec searchSpec)
    {
        Clubs = clubs.Select(org =>
                            new SearchClubModelDetail
                            {
                                Name = org.Name,
                                Location = org.Location,
                                Url = org.Url,
                                AreaOfWork = org.AreaOfWork, 
                                Email = org.Email
                            }).ToList();

        Pager = new PagerModel(searchSpec);
        if (searchSpec.Filter.TextSearch.Items.Any())
            SearchTerm = searchSpec.Filter.TextSearch.Items.Aggregate((current, next) => current + " " + next);
        ResultCount = searchSpec.TotalItems;
    }
}