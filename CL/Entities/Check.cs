using System;
using System.Linq;

namespace CL
{
    /// <summary>
    /// Чек/Продажа
    /// </summary>
    public class Check
    {
        public int Number { get; set; }
        public Buyer Buyer { get; set; }
        public Employee Employee { get; set; }
        public Cart Cart { get; set; }
        public DateTime SaleDate { get; set; }

        public decimal GetCheckSum() => Cart.Items.Sum(i => i.GoodsCount * i.Goods.Cost);
    }
}