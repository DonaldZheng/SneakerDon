using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace theSneakerDon.Models
{
    public class ShoppingCartItem //item inside shopping cart
    {
        public int ShoppingCartItemId
        {
            get; set;
        }
        public string ShoppingCartId
        {
            get; set;
        }
        public Sneaker Sneaker
        {
            get; set;
        }
        public int Amount
        {
            get; set;
        }
    }
}
