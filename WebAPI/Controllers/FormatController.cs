using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormatController : ControllerBase
    {
        private IFormatService _formatService;

        public FormatController(IFormatService formatService)
        {
            _formatService = formatService;
        }
        [HttpGet("formats")]
        public ActionResult<IQueryable<Format>> GetAllFormats()
        {
            return Ok(_formatService.GetAllFormats());
        }
    }
}
