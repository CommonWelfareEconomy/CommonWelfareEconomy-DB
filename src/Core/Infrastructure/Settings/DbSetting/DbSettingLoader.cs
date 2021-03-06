﻿using NHibernate;
using Seedworks.Lib.Persistence;

namespace GwoDb.Infrastructure
{
    public class DbSettingsRepository : RepositoryDb<DbSettings>
    {
        public DbSettingsRepository(ISession session)
            : base(session)
        {
        }

        public DbSettings Get()
        {
            var result = base.GetById(1) ;
            if(result == null)
            {       
                result = new DbSettings();
                result.AppVersion = 0;
            }
            return result;
        }

        public void UpdateAppVersion(int newAppVersion)
        {
            var dbSettings = Get();
            if(dbSettings.Id == 0)
                Create(dbSettings);

            dbSettings.AppVersion = newAppVersion;
            base.Update(dbSettings);
            base.Flush();
        }
    }
}
