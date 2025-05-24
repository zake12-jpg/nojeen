using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using إدارة_المبيعات.Models;

namespace إدارة_المبيعات
{
     static class SharedData
    {
        public static List<Category> categories  = new List<Category>();
        public static List<Items> Items = new List<Items>() ;
    }
}
