﻿using System;
using System.Web;
using GwoDb.Infrastructure;

namespace GwoDb
{
    public class WritePersistentLoginToCookie : IRegisterAsInstancePerLifetime
    {
        private readonly CreatePersistentLogin _createPersistentLogin;

        public WritePersistentLoginToCookie(CreatePersistentLogin createPersistentLogin)
        {
            _createPersistentLogin = createPersistentLogin;
        }

        public void Run(int userId)
        {
            var loginGuid = _createPersistentLogin.Run(userId);

            var cookie = new HttpCookie("common-welfare-economy");
            cookie.Values.Add("persistentLogin", userId + "-x-" + loginGuid);
            cookie.Expires = DateTime.Now.AddDays(45);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }        
    }
}
