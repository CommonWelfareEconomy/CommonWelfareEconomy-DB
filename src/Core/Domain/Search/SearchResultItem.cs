using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GwoDb
{
    public class SearchResultItem
    {
        public string Name;
        public string Url;

        public Organisation Organisation;

        public SearchResultItem(){}

        public SearchResultItem(Organisation organisation)
        {
            Organisation = organisation;
        }
    }
}
