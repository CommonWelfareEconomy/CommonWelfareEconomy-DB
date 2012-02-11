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

        public virtual IList<Person> Users { get; set; }

        public Organisation()
        {
            Users = new List<Person>();
        }
    }
}
