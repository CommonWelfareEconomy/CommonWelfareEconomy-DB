using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GwoDb
{
    public class SearchResult
    {
        public string SearchTerm;
        public IEnumerable<SearchResultItem> Items; 
    }
}
