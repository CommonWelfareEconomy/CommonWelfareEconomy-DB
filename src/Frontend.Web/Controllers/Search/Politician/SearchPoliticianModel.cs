using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GwoDb;

public class SearchPoliticianModel : SearchModelBase
{
    public List<SearchPoliticianModelDetail> Politicians;

    public void Init(IEnumerable<Politician> politicians, PoliticianSearchSpec searchSpec)
    {
        Politicians = politicians.Select(politician =>
                            new SearchPoliticianModelDetail
                            {
                                Name = politician.Name,
                                Location = politician.Location,
                                Url = politician.Url,
                                Capacity = politician.Capacity,
                                Email = politician.Email
                            }).ToList();

        Pager = new PagerModel(searchSpec);
        if (searchSpec.Filter.TextSearch.Items.Any())
            SearchTerm = searchSpec.Filter.TextSearch.Items.Aggregate((current, next) => current + " " + next);
        ResultCount = searchSpec.TotalItems;
    }
}
