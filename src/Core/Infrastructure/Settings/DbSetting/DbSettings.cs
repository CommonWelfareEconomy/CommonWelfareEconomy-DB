using Seedworks.Lib.Persistence;

namespace GwoDb.Infrastructure
{
    public class DbSettings : DomainEntity
    {
        public virtual int AppVersion { get; set; }
    }
}