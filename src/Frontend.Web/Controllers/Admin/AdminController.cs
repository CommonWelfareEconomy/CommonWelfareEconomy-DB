using System;
using System.Web.Mvc;
using GwoDb;
using GwoDb.Tools.Import;
using GwoDb.Updates;
using NHibernate;

namespace Frontend.Web.Controllers.Admin
{
    public class AdminController : Controller
    {
        private readonly Importer _importer;
        private readonly Update _update;
        private readonly ISession _session;

        public AdminController(Importer importer, 
                               Update update, 
                               ISession session)
        {
            _importer = importer;
            _update = update;
            _session = session;
        }

        [AccessOnlyLocalAttribute]
        public ActionResult Welcome()
        {
            var adminWelcomeModel = new AdminWelcomeModel();

            if (TempData["Msg"] != null)
                adminWelcomeModel.Message = (Message) TempData["Msg"];

            return View(adminWelcomeModel);
        }

        [HttpGet]
        [AccessOnlyLocalAttribute]
        public ActionResult Import()
        {
            _session.CreateSQLQuery("TRUNCATE table Club").ExecuteUpdate();
            _session.CreateSQLQuery("TRUNCATE table Company").ExecuteUpdate();
            _session.CreateSQLQuery("TRUNCATE table Person").ExecuteUpdate();
            _session.CreateSQLQuery("TRUNCATE table Politician").ExecuteUpdate();
            _update.Run();
            
            var importerResult = _importer.Run();
            TempData["Msg"] = new SuccessMessage(String.Format("Die DB wurde neu erstellt. <br/>" +
                                                               "{0} Firmen wurden importiert.<br/>" +
                                                               "{1} Personen wurden importiert.<br/>" +
                                                               "{2} Vereine wurden importiert.<br/>" +
                                                               "{3} Politiker wurden importiert.",
                                                                importerResult.ImportedCompaniesCount, 
                                                                importerResult.ImportedPersons, 
                                                                importerResult.ImportedClubs, 
                                                                importerResult.ImportedPoliticians));
            return RedirectToAction("Welcome");
        }
    }
}
