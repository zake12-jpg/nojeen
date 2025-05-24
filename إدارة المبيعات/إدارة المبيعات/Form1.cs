using System;
using System.Windows.Forms;
using إدارة_المبيعات.Models;


namespace إدارة_المبيعات
{
    public partial class Form1 : Form
    {
        static int cnt = 0;
         int n = 0;
         public Form1()
        {
            InitializeComponent();
            /* SharedData.Items { 
             new Items{Name = "w1" , Price = 10},
             new Items{Name = "w2" , Price = 20},
             };*/
          
            if(cnt == 0)
            {
                SharedData.categories.Add(new Category { Name = "Electrical tools" });
                SharedData.categories.Add(new Category { Name = "Medical tools" });
                SharedData.Items.Add(new Items { Name = "w1", Price = 10 , Category = SharedData.categories[1],Total=13 });
                SharedData.Items.Add(new Items { Name = "w2", Price = 20 , Category = SharedData.categories[1],Total=10 });
                SharedData.Items.Add(new Items { Name = "w3", Price = 30 , Category = SharedData.categories[1],Total=5 });
              
                cnt++;
            }
            
            foreach (Items item in SharedData.Items) {
            listBox1.Items.Add(n.ToString() + "- " + item.ToString());
                n++;
            }
            foreach (Category i in SharedData.categories)
            {
                listBox2.Items.Add( i.ToString());
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            ItemsManagment itemsManagment = new ItemsManagment();
            itemsManagment.Show();
            this.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            CategoryMangment C = new CategoryMangment();
            C.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            CartManagment cart = new CartManagment();
            cart.Show();
            this.Hide();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(var item in SharedData.Items)
            {
                i += item.Total;
            }
            MessageBox.Show($"Quantity of all Items: {i}");
        }
    }
}
