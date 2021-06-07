using Microsoft.AspNetCore.Mvc;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theSneakerDon.Models;

namespace theSneakerDon.Controllers
{
    public class CustomerOrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        public CustomerOrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(CustomerOrder order)
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your Cart is Empty");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thank You for Your Order";
            return View();
        }
        public IActionResult Charge(string stripeEmail, string stripeToken)
        {
            var customers = new CustomerService();
            var charges = new ChargeService();

            var customer = customers.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                Source = stripeToken
            });

            var charge = charges.Create(new ChargeCreateOptions
            {
                Amount = 50000,
                Description = "Amount Due",
                Currency = "USD",
                Customer = customer.Id,
                ReceiptEmail = stripeEmail,
                Metadata = new Dictionary<string, string>()
                {
                    {"OrderId", "01" },
                    {"PostCode", "53202" }
                }
            });
            if (charge.Status == "succeeded")
            {
                string BalanceTransactionId = charge.BalanceTransactionId; // if successful give balance transaction #
                return View();
            }
            else
            {

            }
            return View();
        }
    }
}
