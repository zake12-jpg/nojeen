using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using إدارة_المبيعات.Models;

namespace إدارة_المبيعات
{
    public partial class CartManagment : Form
    {
        int n = 0; 
        Cart cart = new Cart();
       
         List<Items> Itm= new List<Items>();
        
        public CartManagment()
        {
            InitializeComponent();
            Itm = SharedData.Items.Select(i => new Items
            {
                Name = i.Name,
                Category = i.Category,
                Price = i.Price,
                Total = i.Total,
            }).ToList();
            foreach (Items item in Itm)    
            {
                listBox1.Items.Add(n.ToString() + "- " + item.ToString());
                n++;
            }
            if (cart.CartItems != null)
            {
                foreach (var item in cart.CartItems)
                {
                    listBox1.Items.Add(item.ToString());

                }
            }  
        }
        private void CartManagment_Load(object sender, EventArgs e)
        {
           
        }


        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void AddingBtn_Click(object sender, EventArgs e)
        {
            CartItem newCartItem = new CartItem();
            int GQ = (int)guna2NumericUpDown1.Value;
            int index = (int)guna2NumericUpDown2.Value;
            newCartItem.items = Itm[index];
            if (GQ > 0 && GQ <= Itm[index].Total) 
            {
            newCartItem.Quantity = GQ;
                
                Itm[index].Total -= newCartItem.Quantity;
                newCartItem.Prices = Itm[index].Price * newCartItem.Quantity;
                cart.CartItems.Add(newCartItem);
                listBox2.Items.Add(newCartItem);

                cart.TotalPrices += newCartItem.Prices;
                label6.Text = cart.TotalPrices.ToString();
                listBox1.Items.Clear();
                n = 0;
                foreach (Items item in Itm)
                {
                  
                    listBox1.Items.Add(n.ToString() + "- " + item.ToString());
                    n++;
                }
            }
            else
            {
                MessageBox.Show("!ادخل كمية مناسبة");
            }
               
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SharedData.Items = Itm;
            MessageBox.Show($"Total Amount: {cart.TotalPrices}");
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
