using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GwoDb;
using GwoDb.Infrastructure.Persistence;
using GwoDb.Tools.Import;
using GwoDb.Updates;

namespace Frontend.Web.Controllers.Admin
{
    public class AdminController : Controller
    {
        private readonly Importer _importer;
        private readonly Update _update;
        private readonly ExecuteSqlFile _executeSqlFile;

        public AdminController(Importer importer, 
                               Update update, 
                               ExecuteSqlFile executeSqlFile)
        {
            _importer = importer;
            _update = update;
            _executeSqlFile = executeSqlFile;
        }

        public ActionResult Welcome()
        {
            var adminWelcomeModel = new AdminWelcomeModel();

            if (TempData["Msg"] != null)
                adminWelcomeModel.Message = (Message) TempData["Msg"];

            return View(adminWelcomeModel);
        }

        [HttpGet]
        public ActionResult Import()
        {
            _executeSqlFile.Run("Tools/Updater/Scripts/1-initial.sql");
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
