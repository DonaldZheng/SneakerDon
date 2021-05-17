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
                 , Category = _categoryRepository.GetAllCategories.ToList()[0], ImageUrl="https://en.wikipedia.org/wiki/Sneakers#/media/File:Air_jordan_XI_space_jam.jpg", IsInStock=true, IsOnSale= false, ImageThumbnailUrl = "https://en.wikipedia.org/wiki/Nike,_Inc.#/media/File:Airjordan1985-1st.JPG" },
             new Sneaker{ SneakerId = 2, Name =" Jordan 3", Price = 170.00M, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elite"
                 , Category = _categoryRepository.GetAllCategories.ToList()[0], ImageUrl="https://en.wikipedia.org/wiki/Sneakers#/media/File:Air_jordan_XI_space_jam.jpg", IsInStock=true, IsOnSale= false, ImageThumbnailUrl = "https://en.wikipedia.org/wiki/Nike,_Inc.#/media/File:Airjordan1985-1st.JPG" },
             new Sneaker{ SneakerId = 3, Name =" Jordan 4", Price = 170.00M, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elite"
                 , Category = _categoryRepository.GetAllCategories.ToList()[0], ImageUrl="https://en.wikipedia.org/wiki/Sneakers#/media/File:Air_jordan_XI_space_jam.jpg", IsInStock=true, IsOnSale= false, ImageThumbnailUrl = "https://en.wikipedia.org/wiki/Nike,_Inc.#/media/File:Airjordan1985-1st.JPG" }
        };

        public IEnumerable<Sneaker> GetSneakerOnSale => throw new NotImplementedException();

        public Sneaker GetSneakerById(int sneakerId)
        {
            return GetAllSneaker.FirstOrDefault(s => s.SneakerId == sneakerId); 
        }
    }
}
