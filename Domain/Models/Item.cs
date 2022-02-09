using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public int CategoryId { get; set; }
        public int FormatId { get; set; }
        public Category Category { get; set; }
        public Format Format { get; set; }

    }
}
