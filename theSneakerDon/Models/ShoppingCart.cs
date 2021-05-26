using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theSneakerDon.Data;

namespace theSneakerDon.Models
{
    public class ShoppingCart
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public string ShoppingCartId
        {
            get; set;
        }
        public List<ShoppingCartItem> ShoppingCartItems
        {
            get; set;
        }

        public ShoppingCart(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<ApplicationDbContext>();
            string cartId = session.GetString("CardId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Sneaker sneaker, int amount)
        {
            var shoppingCartItem = _applicationDbContext.ShoppingCartItems.SingleOrDefault(s => s.Sneaker.SneakerId == sneaker.SneakerId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Sneaker = sneaker,
                    Amount = amount
                };
                _applicationDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _applicationDbContext.SaveChanges();
        }
        public int RemoveFromCart(Sneaker sneaker)
        {
            var shoppingCartItem = _applicationDbContext.ShoppingCartItems.SingleOrDefault(s => s.Sneaker.SneakerId == sneaker.SneakerId && s.ShoppingCartId == ShoppingCartId);
            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _applicationDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _applicationDbContext.SaveChanges();
            return localAmount;

        }
    }
}
