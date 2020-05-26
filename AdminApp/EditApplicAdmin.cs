using Lombard_Project.UserClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class EditApplicAdmin : Form
    {
        public MyApplication work;

        public EditApplicAdmin(MyApplication toedit)
        {
            InitializeComponent();
            this.work = toedit;
        }

        private void ButtonSendAppl_Click(object sender, EventArgs e)
        {
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
            else if (textBoxName.Text.Length < 3)
            {
                textBoxName.BackColor = Color.Red;
                MessageBox.Show("Name has inappropriate length(less than 3), try again");
                textBoxName.BackColor = Color.White;
                textBoxName.Text = string.Empty;
            }
            else if (!int.TryParse(textBoxPrice.Text, out int number))
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
                DialogResult = DialogResult.OK;
            }
        }

        private void EditionForm_Load(object sender, EventArgs e)
        {
            work.Prod.StoreDays = 20;
            DaysToStore.DataBindings.Add(new Binding("Value", work.Prod, "StoreDays"));
            textBoxName.DataBindings.Add(new Binding("Text", work.Prod, "Name"));
            textBoxPrice.DataBindings.Add(new Binding("Text", work.Prod, "Value"));
            textBoxDescription.DataBindings.Add(new Binding("Text", work.Prod, "Description"));

            pictureBox.Image = work.Prod.Image;
            if (work.Prod.Type == "item") listBoxType.SelectedIndex = 0;
            else listBoxType.SelectedIndex = 1;

            labelClientName.Text = work.Prod.Giver.Name;
        }

        private void EditionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                return;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                work.Prod.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox.Image = work.Prod.Image;
            }
        }

        private void ListBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxType.SelectedIndex == 0) work.Prod.Type = "item";
            else work.Prod.Type = "property";
        }
    }
}