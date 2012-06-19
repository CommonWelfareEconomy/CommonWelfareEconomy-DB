using System;
using System.Web.Mvc;
using GwoDb;
using GwoDb.Web.Context;

public class SearchClubController : Controller
{
    private readonly ClubRepository _clubRepository;
    private readonly SessionSearch _sessionSearch;

    public SearchClubController(ClubRepository clubRepository, 
                                SessionSearch sessionSearch)
    {
        _clubRepository = clubRepository;
        _sessionSearch = sessionSearch;
    }

    [HttpGet]
    public ActionResult Search(SearchClubModel searchClubModel, int? page)
    {
        _sessionSearch.ClubSearchSpec.PageSize = 20;

        if (Request["page"] != null)
            _sessionSearch.ClubSearchSpec.CurrentPage = Convert.ToInt32(Request["page"]);

        return GetView(searchClubModel);
    }

    [HttpPost]
    public ActionResult Search(SearchClubModel searchClubModel)
    {
        _sessionSearch.ClubSearchSpec.CurrentPage = 1;

        _sessionSearch.ClubSearchSpec.Filter.TextSearch.Clear();
        if (searchClubModel.SearchTerm != null)
            _sessionSearch.ClubSearchSpec.Filter.TextSearch.AddTerms(searchClubModel.SearchTerm);

        return GetView(searchClubModel);
    }

    private ActionResult GetView(SearchClubModel searchClubModel)
    {
        var clubs = _clubRepository.GetBy(_sessionSearch.ClubSearchSpec);

        searchClubModel.Init(clubs, _sessionSearch.ClubSearchSpec);
        return View(searchClubModel);
    }


    public ActionResult Details(int id)
    {
        return View();
    }
}

