using Lombard_Project.UserClasses;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class VerifyView : Form
    {
        private Lombard lombard;
        private Client activeUser;

        public VerifyView(ref Lombard lombard, Client client)
        {
            InitializeComponent();
            this.lombard = lombard;
            this.activeUser = client;
            myApplicationBindingSource.DataSource = lombard.ApplicationsToUser.Where(o => o.Giver == activeUser);
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
            this.Close();
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
            var accept = new ClientVerification(toaccept);
            DialogResult res = accept.ShowDialog();
            if (res == DialogResult.Yes)
            {
                lombard.ApplicationsToUser.Remove(accept.work);
                Product prod = accept.work.Prod;
                prod.DateTime = DateTime.Now;
                lombard.Products.Add(prod);

                myApplicationBindingSource.DataSource = lombard.ApplicationsToUser.Where(o => o.Giver == activeUser);
                myApplicationBindingSource.ResetBindings(false);
                MessageBox.Show("You accepted the lombard offer", "accept", MessageBoxButtons.OK);
                lombard.Save();
            }
            if (res == DialogResult.No)
            {
                lombard.ApplicationsToUser.Remove(accept.work);
                myApplicationBindingSource.DataSource = lombard.ApplicationsToUser.Where(o => o.Giver == activeUser);
                myApplicationBindingSource.ResetBindings(false);
                MessageBox.Show("You declined the lombard offer", "Decline", MessageBoxButtons.OK);
                lombard.Save();
            }
        }
    }
}