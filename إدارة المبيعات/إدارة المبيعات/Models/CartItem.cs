using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace إدارة_المبيعات.Models
{
    internal class CartItem
    {
     //   public static List<Items> Items = new List<Items>();
        public Items items { set; get; }
        public int Quantity { get; set; }

        public decimal Prices { get; set; }
        /*public decimal TotalPrice { get; set; }*/
        public override string ToString()
        {
            return "Name: " +items.Name + " Individual price: " + items.Price +" Quantity: " + Quantity + " TotalPrice: "+Prices;
        }
    }
}
