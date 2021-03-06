﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seedworks.Lib.Persistence;

namespace GwoDb.Infrastructure
{
    public class SpecOrderByBase : OrderByCriteria
    {
        public OrderBy Created;
        public OrderBy Modified;

        public SpecOrderByBase()
        {
            Created = new OrderBy("DateCreated", this);
            Modified = new OrderBy("DateModified", this);
        }
    }
}
