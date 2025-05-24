using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace إدارة_المبيعات.Models
{
    internal class Items
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Total { get; set; }
        public Category Category { get; set; }
        public Items()
        {
            
        }
        public Items(string name , decimal price , int tot )
        {
            Name = name;
            Price = price;
            Total = tot;
        }
        public Items(string name, decimal price)
        {
            Name = name;
            Price = price;
            Total = 1;
        }
        public override string ToString()
        {
            return "Category: " + Category.Name + "  Name: "+ Name + "  Price: " + Price + "  Total: "+Total;
        }

        // Mangment By Array I dont like to use it Soooo i use the Generic List
       /* public Items[] AddItem(Items[] arr, Items newItem)
        {
            Items[] newArr = new Items[arr.Length + 1];
            Array.Copy(arr, newArr, arr.Length);
            newArr[newArr.Length - 1] = newItem;
            return newArr;
        }
        public Items[] UpdateItem(Items[] arr, int index, Items newItem)
        {
            if (index >= 0 && index < arr.Length)
            {
                arr[index] = newItem;
            }
            else
            {
                Console.WriteLine("مؤشر غير صحيح");
            }
            return arr;
        }
        public Items[] DeleteItem(Items[] arr, int index)
        {
            if (index >= 0 && index < arr.Length)
            {
                Items[] newArr = new Items[arr.Length - 1];
                for (int i = 0, j = 0; i < arr.Length; i++)
                {
                    if (i != index)
                    {
                        newArr[j] = arr[i];
                        j++;
                    }
                }
                return newArr;
            }
            else
            {
                MessageBox.Show("!ادخلت مؤشر خاطئ");
                return arr;
            }
        }
*/
    }
}
