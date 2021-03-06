﻿using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class Club : DomainEntity
    {
        public virtual string Name { get; set; }
        public virtual string AreaOfWork { get; set; }
        public virtual string Location { get; set; }
        public virtual string Email { get; set; }
        public virtual string Url { get; set; }
    }
}
