using System.Collections.Generic;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class Company : DomainEntity
    {
        public virtual string Name { get; set; }
        public virtual string Industry { get; set; }

        public virtual string Size { get; set; }
        public virtual string Url { get; set; }
        public virtual string Location { get; set; }
        public virtual string ZipCode { get; set; }

        public virtual string Email { get; set; }
        public virtual string Password { get; set; }

        public virtual string CountryIso3 { get; set; }
        
        public virtual bool WelfareBalanceFor2011 { get; set; }
        public virtual bool WelfareBalanceFor2012 { get; set; }

        public virtual IList<Person> Users { get; set; }

        public Company()
        {
            Users = new List<Person>();
        }
    }
}
