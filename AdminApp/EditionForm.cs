using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lombard_Project.FilesWorkk;
using Lombard_Project.UserClasses;

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
            

            //Form AdminMain = System.Windows.Forms.Application.OpenForms[0];
            //AdminMain.Left = this.Left;
            //AdminMain.Top = this.Top;
            //this.Close();
            //AdminMain.Show();


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
            //Form AdminMain = System.Windows.Forms.Application.OpenForms[0];
            //AdminMain.Left = this.Left;
            //AdminMain.Top = this.Top;
            //AdminMain.Show();
            if (DialogResult != DialogResult.OK)
                return;
        }
    }
}
