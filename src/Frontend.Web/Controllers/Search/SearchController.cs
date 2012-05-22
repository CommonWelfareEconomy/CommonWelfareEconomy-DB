using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GwoDb;
using GwoDb.Web.Context;

namespace Frontend.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly OrganisationRepository _organisationRepo;
        private readonly SessionSearch _sessionSearch;

        public SearchController(OrganisationRepository organisationRepo, 
                                SessionSearch sessionSearch)
        {
            _organisationRepo = organisationRepo;
            _sessionSearch = sessionSearch;
        }

        public ActionResult Search(SearchModel searchModel, int? page)
        {
            _sessionSearch.OrgaSearchSpec = new OrganisationSearchSpec { PageSize = 20 };

            if (Request["page"] != null)
                _sessionSearch.OrgaSearchSpec.CurrentPage = Convert.ToInt32(Request["page"]);

            if (searchModel.SearchTerm != null)
                _sessionSearch.OrgaSearchSpec.Filter.Name.Like(searchModel.SearchTerm);

            var orgas = _organisationRepo.GetBy(_sessionSearch.OrgaSearchSpec);

            searchModel.Init(orgas, new PagerModel(_sessionSearch.OrgaSearchSpec));
            return View(searchModel);
        }


        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
