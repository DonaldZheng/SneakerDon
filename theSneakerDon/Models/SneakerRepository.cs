using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theSneakerDon.Data;

namespace theSneakerDon.Models
{
    public class SneakerRepository : ISneakerRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public SneakerRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Sneaker> GetAllSneaker
        {
            get
            {
                return _applicationDbContext.Sneakers.Include(s => s.Category);
            }
        }

        public IEnumerable<Sneaker> GetSneakerOnSale
        {
            get
            {
                return _applicationDbContext.Sneakers.Include(s => s.Category).Where(p => p.IsOnSale);
            }
        }

        public Sneaker GetSneakerById(int sneakerId)
        {
            return _applicationDbContext.Sneakers.FirstOrDefault(s => s.SneakerId == sneakerId); 
        }
    }
}
