using System;
using System.Web.Mvc;
using GwoDb;
using GwoDb.Web.Context;

namespace Frontend.Web.Controllers
{
    public class SearchCompanyController : Controller
    {
        private readonly CompanyRepository _companyRepo;
        private readonly SessionSearch _sessionSearch;

        public SearchCompanyController(CompanyRepository companyRepo, 
                                       SessionSearch sessionSearch)
        {
            _companyRepo = companyRepo;
            _sessionSearch = sessionSearch;
        }

        [HttpGet]
        public ActionResult Search(SearchCompanyModel searchCompanyModel, int? page)
        {
            _sessionSearch.OrgaSearchSpec.PageSize = 20;

            if (Request["page"] != null)
                _sessionSearch.OrgaSearchSpec.CurrentPage = Convert.ToInt32(Request["page"]);

            return GetView(searchCompanyModel);
        }

        [HttpPost]
        public ActionResult Search(SearchCompanyModel searchCompanyModel)
        {
            _sessionSearch.OrgaSearchSpec.CurrentPage = 1;

            _sessionSearch.OrgaSearchSpec.Filter.TextSearch.Clear();
            if (searchCompanyModel.SearchTerm != null)
                _sessionSearch.OrgaSearchSpec.Filter.TextSearch.AddTerms(searchCompanyModel.SearchTerm);
            
            return GetView(searchCompanyModel);
        }

        private ActionResult GetView(SearchCompanyModel searchCompanyModel)
        {
            var orgas = _companyRepo.GetBy(_sessionSearch.OrgaSearchSpec);

            searchCompanyModel.Init(orgas, _sessionSearch.OrgaSearchSpec);
            return View(searchCompanyModel);
        }


        [HttpGet]
        public ActionResult Details(int id)
        {
            var company = _companyRepo.GetById(id);
            return View(new CompanyDetailsModel(company));
        }

        [HttpPost]
        public ActionResult Details(CompanyDetailsModel searchCompanyModel, int id)
        {
            var company = ServiceLocator.Resolve<CompanyDetailsModel2Entity>().Run(searchCompanyModel, id);
            _companyRepo.Update(company);

            searchCompanyModel.Message = new SuccessMessage("\""+ company.Name +"\" wurde gespeichert");

            return View(searchCompanyModel);
        }

        [HttpPost]
        [AccessOnlyLoggedIn]
        public JsonResult DeleteDetails(int id)
        {
            var company = _companyRepo.GetById(Convert.ToInt32(id));

            return new JsonResult
            {
                Data = new
                {
                    companyName = company.Name
                }
            };
        }

        [HttpPost]
        [AccessOnlyLoggedIn]
        public void DeleteCompany(int id)
        {
            _companyRepo.Delete(id);
        }

    }
}
