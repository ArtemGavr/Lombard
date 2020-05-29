using Lombard_Project.UserClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class EditProductForm : Form
    {
        public Product prod;

        public EditProductForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        public EditProductForm(Product toedit) : this()
        {
            this.prod = toedit;
        }

        private void ButtonSendAppl_Click(object sender, EventArgs e)
        {
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            DaysToStore.DataBindings.Add(new Binding("Value", prod, "StoreDays"));
            textBoxName.DataBindings.Add(new Binding("Text", prod, "Name"));
            textBoxPrice.DataBindings.Add(new Binding("Text", prod, "Value"));
            textBoxDescription.DataBindings.Add(new Binding("Text", prod, "Description"));
            // textBoxProductType.DataBindings.Add(new Binding("Text", prod, "Type"));
            //pictureBox.DataBindings.Add(new Binding("Image", prod, "Image"));

            pictureBox.Image = prod.Image;
            if (prod.Type == "item") listBoxType.SelectedIndex = 0;
            else listBoxType.SelectedIndex = 1;
            //textBoxClientName.Text = prod.Giver.Name;
            labelClientName.Text = prod.Giver.Name;
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                return;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                prod.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox.Image = prod.Image;
            }
        }

        private void ListBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxType.SelectedIndex == 0) prod.Type = "item";
            else prod.Type = "property";
        }
    }
}