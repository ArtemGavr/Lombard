using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lombard_Project.UserClasses;

namespace AdminApp
{
    public partial class ProductAddForm : Form
    {
        Lombard lombard;
        public ProductAddForm()
        {
            InitializeComponent();
        }

        public ProductAddForm(ref Lombard lombard) : this() 
        {
            this.lombard = lombard;
        }

        private void ProductAddForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxDescription.Text) || string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    textBoxName.BackColor = Color.Red;
                }
                if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
                {
                    textBoxDescription.BackColor = Color.Red;
                }
                if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
                {
                    textBoxPrice.BackColor = Color.Red;
                }
                MessageBox.Show("Fill in the blank space, please");
                textBoxName.BackColor = Color.White;
                textBoxDescription.BackColor = Color.White;
                textBoxPrice.BackColor = Color.White;
            }
            else if (textBoxName.Text.Length <= 3)
            {
                textBoxName.BackColor = Color.Red;
                MessageBox.Show("Name has inappropriate length(less than 3), try again");
                textBoxName.BackColor = Color.White;
                textBoxName.Text = string.Empty;
            }
            else if (!int.TryParse(textBoxPrice.Text, out number))
            {
                textBoxPrice.BackColor = Color.Red;
                MessageBox.Show("Price is not  number, try again");
                textBoxPrice.BackColor = Color.White;
                textBoxPrice.Text = string.Empty;
            }
            else if (pictureBox.Image == null)
            {
                MessageBox.Show("Picture not added, try again");
            }
            //filled and long enough
            else
            {
                string name = textBoxName.Text;
                string description = textBoxDescription.Text;
                int price = Convert.ToInt32(textBoxPrice.Text);
                Image image = pictureBox.Image;

                if (listBoxType.SelectedIndex == 0)
                {
                    Item item = new Item()
                    {
                        Name = name,
                        Description = description,
                        Value = price,
                        Image = image,
                        Type = "item",
                        DateTime = DateTime.Now,
                        Giver = new Client(-1,"lombard","0")
                    };
                    lombard.Products.Add((Product)item);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    Property prop = new Property() 
                    {
                        Name = name,
                        Description = description,
                        Value = price,
                        Image = image,
                        Type = "property",
                        DateTime = DateTime.Now,
                        Giver = new Client(-1,"lombard","0")
                    };
                    lombard.Products.Add((Product)prop);
                    DialogResult = DialogResult.OK;
                };

            }
        }
           
    

        private void RequiredValidate(Control c, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(c.Text))
            {
                c.BackColor = Color.Pink;
                e.Cancel = true;
            }
        }

        private void ProductAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                return;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openFileDialog1.FileName);
                 
            }
        }
    }
}
