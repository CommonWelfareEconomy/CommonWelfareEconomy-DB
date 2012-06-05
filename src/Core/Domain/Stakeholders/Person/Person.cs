using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class Person : DomainEntity
    {
        public virtual string Name { get; set; }

        public virtual Organisation Organisation { get; set; }
        public virtual IList<Newsletter> Subscriptions { get; set; }

        public Person()
        {
            Subscriptions = new List<Newsletter>();
        }

    }
}
