using System;
using System.Web.Mvc;
using GwoDb;
using GwoDb.Web.Context;

public class SearchPersonController : Controller
{
    private readonly PersonRepository _PersonRepository;
    private readonly SessionSearch _sessionSearch;

    public SearchPersonController(PersonRepository PersonRepository, 
                                SessionSearch sessionSearch)
    {
        _PersonRepository = PersonRepository;
        _sessionSearch = sessionSearch;
    }

    [HttpGet]
    public ActionResult Search(SearchPersonModel searchPersonModel, int? page)
    {
        _sessionSearch.PersonSearchSpec.PageSize = 20;

        if (Request["page"] != null)
            _sessionSearch.PersonSearchSpec.CurrentPage = Convert.ToInt32(Request["page"]);

        return GetView(searchPersonModel);
    }

    [HttpPost]
    public ActionResult Search(SearchPersonModel searchPersonModel)
    {
        _sessionSearch.PersonSearchSpec.CurrentPage = 1;

        _sessionSearch.PersonSearchSpec.Filter.TextSearch.Clear();
        if (searchPersonModel.SearchTerm != null)
            _sessionSearch.PersonSearchSpec.Filter.TextSearch.AddTerms(searchPersonModel.SearchTerm);

        return GetView(searchPersonModel);
    }

    private ActionResult GetView(SearchPersonModel searchPersonModel)
    {
        var Persons = _PersonRepository.GetBy(_sessionSearch.PersonSearchSpec);

        searchPersonModel.Init(Persons, _sessionSearch.PersonSearchSpec);
        return View(searchPersonModel);
    }

    public ActionResult Details(int id)
    {
        return View();
    }
}
