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

namespace ClientApp
{
    public partial class VerifyView : Form
    {

        Lombard lombard;
        Client activeUser;
        public VerifyView(ref Lombard lombard, Client client)
        {
            InitializeComponent();
            this.lombard = lombard;
            this.activeUser = client;
            myApplicationBindingSource.DataSource = lombard.ApplicationsToUser.Where(o => o.Giver==activeUser);
        }

        private void VerifyView_Load(object sender, EventArgs e)
        {
            myApplicationBindingSource.ResetBindings(false);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form CustomerMain = System.Windows.Forms.Application.OpenForms[1];
            CustomerMain.Left = this.Left;
            CustomerMain.Top = this.Top;
            CustomerMain.Show();
        }

        private void VerifyView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form CustomerMain = System.Windows.Forms.Application.OpenForms[1];
            CustomerMain.Left = this.Left;
            CustomerMain.Top = this.Top;
            CustomerMain.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
                MyApplication toaccept = dataGridView1.Rows[e.RowIndex].DataBoundItem as MyApplication;
                Form accept = new ClientVerification(ref lombard, toaccept, e.RowIndex, activeUser);
                this.Hide();
                accept.Show();
            
        }
    }
}
