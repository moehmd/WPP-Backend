using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Helper
{
    public class ItemParams
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }

        // Search
        private string _search;
        public string Search
        {
            get => _search;
            set => _search = value.ToLower();
        }

        // Filter 
        public List<int> Categories { get; set; }
        public List<int> Formats { get; set; }
    }
}
