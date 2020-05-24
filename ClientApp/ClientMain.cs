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
            Form applics = new ApplicMakeClient(ref lombard, activeUser);
            this.Hide();
            applics.Show();
           
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            Form acceptVies = new ApplicIncomeToClient(ref lombard, activeUser);
            this.Hide();
            
            acceptVies.Show();
        }

        private void ClientMain_VisibleChanged(object sender, EventArgs e)
        {
            productBindingSource.ResetBindings(false);
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridViewProducts.Rows.GetRowCount(DataGridViewElementStates.Selected);
            Cart cart = new Cart();
            cart.Buyer = activeUser;
            for (int i = 0; i < selectedRowCount; i++)
            {
                var toBuy = dataGridViewProducts.SelectedRows[i].DataBoundItem as Product;
                cart.LikedProducts.Add(toBuy);
            }

            var buying = new Purchasing(cart);
            if (buying.ShowDialog() == DialogResult.Yes)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    lombard.Products.Remove(cart.LikedProducts[i]);
                    activeUser.PurchasedGoods.Add(cart.LikedProducts[i]);
                }
                lombard.Clients.Find(o => o.ID == activeUser.ID).PurchasedGoods = activeUser.PurchasedGoods;
                productBindingSource.ResetBindings(false);
                lombard.IsDirty = true;
            }
        }
    }
}