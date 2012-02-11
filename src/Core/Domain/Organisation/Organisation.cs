using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class Organisation : DomainEntity
    {
        public virtual string Name { get; set; }
        public virtual string Industry { get; set; }

        public virtual string ContributorsCountInfo { get; set; }
        public virtual string Url { get; set; }
        public virtual string Location { get; set; }
        public virtual string ZipCode { get; set; }

        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        
        public virtual bool WelfareBalanceFor2011 { get; set; }
        public virtual bool WelfareBalanceFor2012 { get; set; }

        public virtual IList<Person> Users { get; set; }

        public Organisation()
        {
            Users = new List<Person>();
        }
    }
}
