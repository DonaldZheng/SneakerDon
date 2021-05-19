using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theSneakerDon.Data;

namespace theSneakerDon.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Category> GetAllCategories => _applicationDbContext.Categories;
    }
}
