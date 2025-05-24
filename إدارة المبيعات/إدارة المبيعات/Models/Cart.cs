using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace إدارة_المبيعات.Models
{
    internal class Cart
    {
        public  List<CartItem> CartItems = new List<CartItem>();
        public decimal TotalPrices { get; set; }
        public override string ToString()
        {
            return CartItems.ToString();
        }
    }
   
}
