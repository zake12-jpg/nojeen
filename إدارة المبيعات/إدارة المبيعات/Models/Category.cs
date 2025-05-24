using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace إدارة_المبيعات.Models
{
    internal class Category
    {
        public string Name { get; set; }
        public Category( string name)
        {
            Name = name;   
        }
        public Category()
        {
            
        }
        public override string ToString()
        {
            return "Name: " + Name  ;
        }
    }
}
