using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace theSneakerDon.Models
{
    public class SneakerRepository : ISneakerRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository(); // get access the CategoryRepo of all the Category names
        public IEnumerable<Sneaker> GetAllSneaker => new List<Sneaker>
        {
             new Sneaker{ SneakerId = 1, Name =" Jordan 1", Price = 170.00M, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elite"
                 , Category = _categoryRepository.GetAllCategories.ToList()[0], ImageUrl="jordan4.jpg", IsInStock=true, IsOnSale= false, ImageThumbnailUrl = "https://sneakernews.com/wp-content/uploads/2019/02/travis-scott-jordan-1-CD4487-100-6.jpg" },
             new Sneaker{ SneakerId = 2, Name =" Jordan 3", Price = 170.00M, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elite"
                 , Category = _categoryRepository.GetAllCategories.ToList()[0], ImageUrl="jordan4.jpg", IsInStock=true, IsOnSale= false, ImageThumbnailUrl = "https://sneakernews.com/wp-content/uploads/2021/05/A-Ma-Maniere-Air-Jordan-3-DH3434-110-Global-Release-Info-4.jpg" },
             new Sneaker{ SneakerId = 3, Name =" Jordan 4", Price = 170.00M, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elite"
                 , Category = _categoryRepository.GetAllCategories.ToList()[0], ImageUrl="jordan4.jpg", IsInStock=true, IsOnSale= false, ImageThumbnailUrl = "https://sneakernews.com/wp-content/uploads/2021/03/Air-Jordan-4-UNC-CT8527-400.jpg" }
        };

        public IEnumerable<Sneaker> GetSneakerOnSale => throw new NotImplementedException();

        public Sneaker GetSneakerById(int sneakerId)
        {
            return GetAllSneaker.FirstOrDefault(s => s.SneakerId == sneakerId); 
        }
    }
}
