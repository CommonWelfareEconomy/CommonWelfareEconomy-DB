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

        public Company Company;

        public SearchResultItem(){}

        public SearchResultItem(Company company)
        {
            Company = company;
        }
    }
}
