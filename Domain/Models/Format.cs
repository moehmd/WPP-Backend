using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Format
    {
        public int FormatId { get; set; }
        public string Name { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
