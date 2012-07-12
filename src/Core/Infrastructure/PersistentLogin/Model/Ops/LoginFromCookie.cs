using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GwoDb.Infrastructure;
using GwoDb.Web.Context;

namespace GwoDb
{
    public class LoginFromCookie : IRegisterAsInstancePerLifetime
    {
        private readonly GetPersistentLoginCookieValues _getPersistentLoginCookieValues;
        private readonly WritePersistentLoginToCookie _writePersistentLoginToCookie;
        private readonly PersistentLoginRepository _persistentLoginRepository;
        private readonly SessionUser _sessionUser;

        public LoginFromCookie(GetPersistentLoginCookieValues getPersistentLoginCookieValues,
                               WritePersistentLoginToCookie writePersistentLoginToCookie,
                               PersistentLoginRepository persistentLoginRepository, 
                               SessionUser sessionUser)
        {
            _getPersistentLoginCookieValues = getPersistentLoginCookieValues;
            _writePersistentLoginToCookie = writePersistentLoginToCookie;
            _persistentLoginRepository = persistentLoginRepository;
            _sessionUser = sessionUser;
        }

        public bool Run()
        {
            var cookieValues = _getPersistentLoginCookieValues.Run();

            if (!cookieValues.Exists())
                return false;

            var persistentLogin = _persistentLoginRepository.Get(cookieValues.UserId, cookieValues.LoginGuid);

            if (persistentLogin == null)
                return false;

            _persistentLoginRepository.Delete(persistentLogin);
            _writePersistentLoginToCookie.Run(cookieValues.UserId);

            _sessionUser.IsAdmin = true;
            _sessionUser.IsLoggedIn = true;

            return true;
        }
    }
}
