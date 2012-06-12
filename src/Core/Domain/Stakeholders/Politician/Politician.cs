using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class Politician : DomainEntity
    {
        public virtual string Name { get; set; }
        public virtual string Capacity { get; set; }
        public virtual string Location { get; set; }
        public virtual string Email { get; set; }
        public virtual string Url { get; set; }
    }
}
