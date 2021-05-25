using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theSneakerDon.Models;
using theSneakerDon.ViewModels;

namespace theSneakerDon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISneakerRepository _sneakerRepository;
        public HomeController(ISneakerRepository sneakerRepository)
        {
            _sneakerRepository = sneakerRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                SneakerOnSale = _sneakerRepository.GetSneakerOnSale
            };
            return View(homeViewModel);
        }
    }
}
