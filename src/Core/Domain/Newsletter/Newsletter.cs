using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class Newsletter : IPersistable, WithDateModified
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<Person> Subscribers { get; set; }

        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime DateModified { get; set; }

        public Newsletter()
        {
            Subscribers = new List<Person>();
        }

    }
}
