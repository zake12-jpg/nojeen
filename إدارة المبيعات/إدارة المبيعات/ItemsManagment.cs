using System;
using System.Windows.Forms;

namespace إدارة_المبيعات
{
    public partial class ItemsManagment : Form
    {
        public ItemsManagment()
        {
            InitializeComponent();
        }

        private void ItemsManagment_Load(object sender, EventArgs e)
        {

        }

        // Adding Btn Lazy to rename it
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Models.Items newitems = new Models.Items
            {
                Name = guna2TextBox1.Text,
            };
            if ((int)guna2NumericUpDown2.Value >= 0 && (int)guna2NumericUpDown2.Value < SharedData.categories.Count)
            {
                newitems.Category = SharedData.categories[(int)guna2NumericUpDown2.Value];
            }
            else
            {
                MessageBox.Show("مؤشر خاطئ ):");
            }
            newitems.Total =(int)guna2NumericUpDown3.Value;
            if (decimal.TryParse(guna2TextBox2.Text, out decimal res) && res >= 0)
            {
                newitems.Price = res;
                SharedData.Items.Add(newitems);
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("الرجاء ادخال رقم صحيح");
            }

        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {

               SharedData.Items.RemoveAt((int)guna2NumericUpDown1.Value);
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }


        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }


        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            int index = (int)guna2NumericUpDown1.Value;
            int C = (int)guna2NumericUpDown2.Value;
            if (index >= 0 && index < SharedData.Items.Count)
            {
                SharedData.Items[index].Name = guna2TextBox1.Text;
                if (C>= 0 && C < SharedData.categories.Count)
                {
                    SharedData.Items[index].Category = SharedData.categories[C];
                }
                else
                {
                    MessageBox.Show("مؤشر خاطئ ):");
                }
                SharedData.Items[index].Total = (int)guna2NumericUpDown3.Value;
                if (decimal.TryParse(guna2TextBox2.Text, out decimal res) && res >= 0)
                {
                    SharedData.Items[index].Price = res;
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("الرجاء ادخال رقم صحيح للسعر");
                    return;
                }
            }
            else
            {
                MessageBox.Show("الفهرس غير صحيح");
            }
        }
    }

}
