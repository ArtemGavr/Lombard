using Lombard_Project.UserClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class ApplicEditionAdmin : Form
    {
        public MyApplication work;

        public ApplicEditionAdmin(MyApplication toedit)
        {
            InitializeComponent();
            this.work = toedit;
        }

        private void buttonSendAppl_Click(object sender, EventArgs e)
        {
          
        }

        private void EditionForm_Load(object sender, EventArgs e)
        {
            work.Prod.StoreDays = 20;
            DaysToStore.DataBindings.Add(new Binding("Value",work.Prod,"StoreDays"));
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

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                work.Prod.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox.Image = work.Prod.Image;
            }
        }

        private void listBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxType.SelectedIndex == 0) work.Prod.Type = "item";
            else work.Prod.Type = "property";
        }
    }
}