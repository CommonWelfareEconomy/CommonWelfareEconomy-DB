using System.Collections.Generic;
using System.Linq;
using GwoDb;

public class SearchPersonModel : SearchModelBase
{
    public List<SearchPersonModelDetail> Persons;

    public void Init(IEnumerable<Person> persons, PersonSearchSpec searchSpec)
    {
        Persons = persons.Select(person =>
                            new SearchPersonModelDetail
                            {
                                Name = person.Name,
                                Location = person.Location,
                                Url = person.Url,
                                Job = person.Job,
                                Email = person.Email
                            }).ToList();

        Pager = new PagerModel(searchSpec);
        if (searchSpec.Filter.TextSearch.Items.Any())
            SearchTerm = searchSpec.Filter.TextSearch.Items.Aggregate((current, next) => current + " " + next);
        ResultCount = searchSpec.TotalItems;
    }
}