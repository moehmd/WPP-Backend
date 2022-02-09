using Domain;
using Domain.Helper;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ItemService : IItemService
    {
        private IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public ItemsResponse GetAllItems(ItemParams itemParams)
        {
            IQueryable<Item> items = _itemRepository.GetItems();
            if(itemParams.Search != "")
            {
                items = items.Where(x => x.Title.Contains(itemParams.Search) || x.Description.Contains(itemParams.Search));
            }

            if (itemParams.Categories.Count > 0)
            {
                foreach (var category in itemParams.Categories)
                {
                    if(items.Any(x => x.CategoryId == category))
                    {
                        items = items.Where(x => x.CategoryId == category);
                    }
                }
            };

            if (itemParams.Formats.Count > 0)
            {
                foreach (var format in itemParams.Formats)
                {
                    if (items.Any(x => x.FormatId == format))
                    {
                        items = items.Where(x => x.FormatId == format);
                    }
                }
            }

            PaginationFilter paginationFilter = new PaginationFilter(itemParams.PageIndex, itemParams.PageSize);
            return BuildResponse(items, paginationFilter);
        }

        private ItemsResponse BuildResponse(IQueryable<Item> items, PaginationFilter paginationFilter)
        {
            var results = new ItemsResponse();
            results.TotalRecord = items.Count();
            var totalPages = (double)results.TotalRecord /(double) paginationFilter.PageSize;
            int roundedTotalPages = Convert.ToInt16(Math.Ceiling(totalPages));
            results.TotalPages = roundedTotalPages;
            results.PageSize = paginationFilter.PageSize;
            results.PageNumber = paginationFilter.PageIndex;
            results.Items = items;

            return results;
        }
    }
}
