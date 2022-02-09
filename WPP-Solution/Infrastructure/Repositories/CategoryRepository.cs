using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public WPPContext wPPContext;
        public CategoryRepository(WPPContext wPPContext)
        {
            this.wPPContext = wPPContext;
        }
        public IQueryable<Category> GetCategories()
        {
            IQueryable<Category> categories = wPPContext.Category.OrderBy(x => x.CategoryId);
            return categories;
        }

    }
}
