using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GwoDb;
using GwoDb.Web.Context;

public class SearchPoliticianController : Controller
{
    private readonly PoliticianRepository _PoliticianRepository;
    private readonly SessionSearch _sessionSearch;

    public SearchPoliticianController(PoliticianRepository PoliticianRepository, 
                                      SessionSearch sessionSearch)
    {
        _PoliticianRepository = PoliticianRepository;
        _sessionSearch = sessionSearch;
    }

    [HttpGet]
    public ActionResult Search(SearchPoliticianModel searchPoliticianModel, int? page)
    {
        _sessionSearch.PoliticianSearchSpec.PageSize = 20;

        if (Request["page"] != null)
            _sessionSearch.PoliticianSearchSpec.CurrentPage = Convert.ToInt32(Request["page"]);

        return GetView(searchPoliticianModel);
    }

    [HttpPost]
    public ActionResult Search(SearchPoliticianModel searchPoliticianModel)
    {
        _sessionSearch.PoliticianSearchSpec.CurrentPage = 1;

        _sessionSearch.PoliticianSearchSpec.Filter.TextSearch.Clear();
        if (searchPoliticianModel.SearchTerm != null)
            _sessionSearch.PoliticianSearchSpec.Filter.TextSearch.AddTerms(searchPoliticianModel.SearchTerm);

        return GetView(searchPoliticianModel);
    }

    private ActionResult GetView(SearchPoliticianModel searchPoliticianModel)
    {
        var Politicians = _PoliticianRepository.GetBy(_sessionSearch.PoliticianSearchSpec);

        searchPoliticianModel.Init(Politicians, _sessionSearch.PoliticianSearchSpec);
        return View(searchPoliticianModel);
    }

    public ActionResult Details(int id)
    {
        return View();
    }
}
