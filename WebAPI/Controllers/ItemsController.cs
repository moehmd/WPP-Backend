using Domain;
using Domain.Helper;
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
    public class ItemsController : ControllerBase
    {
        private IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost("items")]
        public ActionResult<ItemsResponse> GetAllItems(ItemParams itemParam)
        {
            return Ok(_itemService.GetAllItems(itemParam));
        }
    }
}
