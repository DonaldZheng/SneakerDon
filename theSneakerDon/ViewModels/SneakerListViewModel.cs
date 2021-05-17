using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theSneakerDon.Models;

namespace theSneakerDon.ViewModels
{
    public class SneakerListViewModel
    {
        public IEnumerable<Sneaker> Sneakers
        {
            get; set;
        }
        public string CurrentCategory
        {
            get; set;
        }
    }
}
