using Lombard_Project.UserClasses;
using System;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class EditionForm : Form
    {
        public MyApplication work;

        public EditionForm(MyApplication toedit)
        {
            InitializeComponent();
            this.work = toedit;
        }

        private void buttonSendAppl_Click(object sender, EventArgs e)
        {
          
        }

        private void EditionForm_Load(object sender, EventArgs e)
        {
            textBoxName.DataBindings.Add(new Binding("Text", work.Prod, "Name"));
            textBoxPrice.DataBindings.Add(new Binding("Text", work.Prod, "Value"));
            textBoxDescription.DataBindings.Add(new Binding("Text", work.Prod, "Description"));

            textBoxClientName.Text = work.Giver.Name;
            labelClientName.Text = work.Giver.Name;
            textBoxProductType.Text = work.Prod.Type;
        }

        private void EditionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            if (DialogResult != DialogResult.OK)
                return;
        }
    }
}