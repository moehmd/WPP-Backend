using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class FormatService: IFormatService
    {
        private IFormatRepository _fromatRepository;

        public FormatService(IFormatRepository fromatRepository)
        {
            _fromatRepository = fromatRepository;
        }

        public IQueryable<Format> GetAllFormats()
        {
            IQueryable<Format> formats = _fromatRepository.GetFormats();
            return formats;

        }
    }
}