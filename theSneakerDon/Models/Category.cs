using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace theSneakerDon.Models
{
    public class Category
    {
        public int CategoryId
        {
            get; set;
        }
        public int CategoryName
        {
            get; set;
        }
        public int CategoryDescription
        {
            get; set;
        }
        public List<Sneaker> Sneakers
        {
            get; set;
        }
    }
}
