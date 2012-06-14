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
        _sessionSearch.OrgaSearchSpec.PageSize = 20;

        if (Request["page"] != null)
            _sessionSearch.OrgaSearchSpec.CurrentPage = Convert.ToInt32(Request["page"]);

        return GetView(searchClubModel);
    }

    [HttpPost]
    public ActionResult Search(SearchClubModel searchClubModel)
    {
        _sessionSearch.OrgaSearchSpec.CurrentPage = 1;

        _sessionSearch.OrgaSearchSpec.Filter.TextSearch.Clear();
        if (searchClubModel.SearchTerm != null)
            _sessionSearch.OrgaSearchSpec.Filter.TextSearch.AddTerms(searchClubModel.SearchTerm);

        return GetView(searchClubModel);
    }

    private ActionResult GetView(SearchClubModel searchClubModel)
    {
        var orgas = _clubRepository.GetBy(_sessionSearch.OrgaSearchSpec);

        searchClubModel.Init(orgas, _sessionSearch.OrgaSearchSpec);
        return View(searchClubModel);
    }


    public ActionResult Details(int id)
    {
        return View();
    }
}

