using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace theSneakerDon.Models
{
    public interface ISneakerRepository
    {
        IEnumerable<Sneaker> GetAllSneaker
        {
            get;
        }
        IEnumerable<Sneaker> GetSneakerOnSale
        {
            get;
        }
        Sneaker GetSneakerById(int sneakerId);
    }
}
