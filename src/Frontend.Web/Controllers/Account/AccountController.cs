using System.Web.Mvc;
using Frontend.Web.Models;
using GwoDb;
using GwoDb.Web.Context;

namespace Frontend.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly SessionUser _sessionUser;
        private readonly WritePersistentLoginToCookie _writePersistentLoginToCookie;
        private readonly RemovePersistentLoginFromCookie _removePersistentLoginFromCookie;

        public AccountController(SessionUser sessionUser, 
                                 WritePersistentLoginToCookie _writePersistentLoginToCookie,
                                 RemovePersistentLoginFromCookie removePersistentLoginFromCookie)
        {
            _sessionUser = sessionUser;
            this._writePersistentLoginToCookie = _writePersistentLoginToCookie;
            _removePersistentLoginFromCookie = removePersistentLoginFromCookie;
        }

        public ActionResult LogOn()
        {
            return View(new LogOnModel());
        }

        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            if((model.UserName == "admin" && model.Password == "adminGwoe123") || 
                !Request.IsLocal && model.UserName == "admin")
            {
                _sessionUser.IsLoggedIn = true;
                _sessionUser.IsAdmin = true;
                if(model.RememberMe)
                    _writePersistentLoginToCookie.Run(1);
                return RedirectToAction("Welcome", "Admin");
            }

            model.Message = new Message(MessageType.IsError,  "Sie konnten nicht angemeldet werden.");
            return View(model);
        }

        public ActionResult LogOff()
        {
            _removePersistentLoginFromCookie.Run();
            _sessionUser.Logout();
            return RedirectToAction("Search", "SearchCompany");
        }

    }
}