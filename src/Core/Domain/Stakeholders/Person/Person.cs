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

        public virtual string Job { get; set; }
        public virtual string Location { get; set; }
        public virtual string Email { get; set; }
        public virtual string Url { get; set; }

    }
}
