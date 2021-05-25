using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theSneakerDon.Models;

namespace theSneakerDon.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Sneaker> SneakerOnSale
        {
            get; set;
        }
    }
}
