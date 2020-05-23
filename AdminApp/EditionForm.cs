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
        //Lombard lombard;
        MyApplication work;
        int index;

        Lombard lombard;
        public EditionForm(ref Lombard lombard,MyApplication toedit, int index)
        {
            InitializeComponent();
            this.lombard = lombard;
            this.work = toedit;
            this.index = index;
        }

        

        private void buttonSendAppl_Click(object sender, EventArgs e)
        {
            lombard.ApplicationsToAdmin.RemoveAt(index);
            lombard.ApplicationsToUser.Add(work);
            lombard.Save();
        }

        private void EditionForm_Load(object sender, EventArgs e)
        {
            if (work.Prod.Type == "item")
            {
                textBoxName.DataBindings.Add(new Binding("Text", work.Prod, "Name"));
            }
            else
            {
                textBoxName.DataBindings.Add(new Binding("Text", work.Prod, "Adress"));
            }
            textBoxPrice.DataBindings.Add(new Binding("Text", work.Prod, "Value"));
            textBoxDescription.DataBindings.Add(new Binding("Text", work.Prod, "Description"));

            textBoxClientName.Text = work.Giver.Name;
            labelClientName.Text = work.Giver.Name;
            textBoxProductType.Text = work.Prod.Type;
        }

        private void EditionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form AdminMain = System.Windows.Forms.Application.OpenForms[0];
            AdminMain.Left = this.Left;
            AdminMain.Top = this.Top;
            AdminMain.Show();
        }
    }
}
