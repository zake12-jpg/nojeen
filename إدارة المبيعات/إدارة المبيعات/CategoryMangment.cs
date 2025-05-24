using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace إدارة_المبيعات
{
    public partial class CategoryMangment : Form
    {
        public CategoryMangment()
        {
            InitializeComponent();
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
            Models.Category newcate = new Models.Category
            {
                Name = guna2TextBox1.Text,
            };
            SharedData.categories.Add(newcate);
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SharedData.categories.RemoveAt((int)guna2NumericUpDown1.Value);
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int index = (int)guna2NumericUpDown1.Value;
            if (index >= 0 && index < SharedData.Items.Count)
            {
                SharedData.categories[index].Name = guna2TextBox1.Text;
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
            }
            else
            {
                MessageBox.Show("الفهرس غير صحيح");
            }
        }

        private void CategoryMangment_Load(object sender, EventArgs e)
        {

        }
    }
}
