using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GwoDb;
using GwoDb.Infrastructure.Persistence;
using GwoDb.Tools.Import;

namespace Frontend.Web.Controllers.Admin
{
    public class AdminController : Controller
    {
        private readonly Importer _importer;
        private readonly ExecuteSqlFile _executeSqlFile;

        public AdminController(Importer importer, ExecuteSqlFile executeSqlFile)
        {
            _importer = importer;
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
            var importerResult = _importer.Run();
            TempData["Msg"] = new SuccessMessage(String.Format("Die DB wurde neu erstellt. {0} Organisationen wurden importiert.",
                                                                importerResult.ImportedCompaniesCount));
            return RedirectToAction("Welcome");
        }
    }
}
