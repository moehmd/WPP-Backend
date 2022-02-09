using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class FormatRepository : IFormatRepository
    {
        public WPPContext wPPContext;

        public FormatRepository(WPPContext wPPContext)
        {
            this.wPPContext = wPPContext;
        }

        public IQueryable<Format> GetFormats()
        {
            IQueryable<Format> formats = wPPContext.Format.OrderBy(x => x.FormatId);
            return formats;
        }
    }
}
