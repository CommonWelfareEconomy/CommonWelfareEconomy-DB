using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class Newsletter : DomainEntity
    {
        public virtual string Name { get; set; }

        public virtual IList<Person> Subscribers { get; set; }

        public Newsletter()
        {
            Subscribers = new List<Person>();
        }

    }
}
