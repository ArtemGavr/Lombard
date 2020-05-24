using Lombard_Project.UserClasses;
using System;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class ClientMain : Form
    {
        private Lombard lombard;

        private Client activeUser;

        public ClientMain(ref Lombard lombard, Client user)
        {
            InitializeComponent();
            this.lombard = lombard;
            this.activeUser = user;

            productBindingSource.DataSource = lombard.Products;
        }

        private void ClientMain_Load(object sender, EventArgs e)
        {
            productBindingSource.ResetBindings(false);
        }

        private void ClientMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form CustomerAutor = System.Windows.Forms.Application.OpenForms[0];

            if (!lombard.IsDirty)
            {
                CustomerAutor.Close();
                return;
            }
            var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    CustomerAutor.Close();

                    break;

                case DialogResult.Yes:
                    lombard.Save();
                    CustomerAutor.Close();

                    break;

                case DialogResult.No:
                    CustomerAutor.Close();

                    break;
            }
        }

        private void buttonApplications_Click(object sender, EventArgs e)
        {
            Form applics = new ApplicClient(ref lombard, activeUser);
            this.Hide();
            applics.Show();
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            Form acceptVies = new VerifyView(ref lombard, activeUser);
            this.Hide();
            acceptVies.Show();
        }
    }
}