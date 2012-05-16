using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GwoDb;

namespace Frontend.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly OrganisationRepository _organisationRepo;

        public SearchController(OrganisationRepository organisationRepo)
        {
            _organisationRepo = organisationRepo;
        }

        public ActionResult Search()
        {
            var searchSpec = new OrganisationSearchSpec {PageSize = 20};

            if (Request["page"] != null)
                searchSpec.CurrentPage = Convert.ToInt32(Request["page"]);

            var orgas = _organisationRepo.GetBy(searchSpec);

            return View(new SearchModel(orgas,new PagerModel(searchSpec)));
        }


        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
