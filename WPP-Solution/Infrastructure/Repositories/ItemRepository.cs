using Domain;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
   public class ItemRepository : IItemRepository
    {
        public WPPContext wPPContext;

        public ItemRepository(WPPContext wPPContext)
        {
            this.wPPContext = wPPContext;
        }

        public IQueryable<Item> GetItems() 
        {
            IQueryable<Item> items= wPPContext.Item.OrderBy(x => x.ItemId);
            return items;
        }
    }
}
