using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theSneakerDon.Models;
using theSneakerDon.ViewModels;

namespace theSneakerDon.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ISneakerRepository _sneakerRepository;
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartController(ISneakerRepository sneakerRepository, ShoppingCart shoppingCart)
        {
            _sneakerRepository = sneakerRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()

            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int sneakerId)
        {
            var selectedSneaker = _sneakerRepository.GetAllSneaker.FirstOrDefault(c => c.SneakerId == sneakerId);
            if (selectedSneaker != null)
            {
                _shoppingCart.AddToCart(selectedSneaker, 1);
            }
            return RedirectToAction("Index");

        }
        public RedirectToActionResult RemoveFromShoppingCart(int sneakerId)
        {
            var selectedSneaker = _sneakerRepository.GetAllSneaker.FirstOrDefault(s => s.SneakerId == sneakerId);
            if (selectedSneaker != null)
            {
                _shoppingCart.RemoveFromCart(selectedSneaker);
            }

            return RedirectToAction("Index");
        }

    }
}
