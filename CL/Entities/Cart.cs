using System.Collections.Generic;

namespace CL
{
    /// <summary>
    /// Корзина
    /// </summary>
    public class Cart
    {
        public List<CartItem> Items;

        public Cart()
        {
            Items = new List<CartItem>();
        }
    }
}