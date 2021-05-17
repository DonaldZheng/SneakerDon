using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace theSneakerDon.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category{ CategoryId = 1, CategoryName =" Jordan 1", CategoryDescription = "Classic Jordans"},
            new Category{ CategoryId = 2, CategoryName =" Jordan 3", CategoryDescription = "Classic Jordans"},
            new Category{ CategoryId = 3, CategoryName =" Jordan 4", CategoryDescription = "Classic Jordans"}
        };
    }
}
