using Lombard_Project.UserClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class ClientMain : Form
    {
        private Lombard lombard;

        private Client activeUser;

        private List<Product> presentList;

        public ClientMain(ref Lombard lombard, Client user)
        {
            InitializeComponent();
            this.lombard = lombard;
            this.activeUser = user;

            presentList = new List<Product>();
            // Додаємо здані клієнтом предмети.
            presentList.AddRange(lombard.Products.Where(
                o => o.Giver == activeUser &&
                Convert.ToInt32(
                    (DateTime.Now - o.DateTime).TotalDays) <= o.StoreDays));
            // Додаємо предмети додані адміном.
            presentList.AddRange(lombard.Products.Where(o => o.Giver.ID == -1));
            // Додаємо всі предмети у продажу.
            presentList.AddRange(lombard.Products.Where(
                o => Convert.ToInt32(
                    (DateTime.Now - o.DateTime).TotalDays) > o.StoreDays));
            productBindingSource.DataSource = presentList;


        }

        private void ClientMain_Load(object sender, EventArgs e)
        {
            
            productBindingSource.ResetBindings(false);
            if (presentList.Count > 0)
                dataGridViewProducts.Rows[0].Selected = true;
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

        private void ButtonApplications_Click(object sender, EventArgs e)
        {
            Form applics = new MakeApplicClient(ref lombard, activeUser);
            this.Hide();
            applics.Show();
        }

        private void ButtonVerify_Click(object sender, EventArgs e)
        {
            Form acceptVies = new ApplicIncomeToClient(ref lombard, activeUser);
            this.Hide();

            acceptVies.Show();
        }

        private void ClientMain_VisibleChanged(object sender, EventArgs e)
        {
            presentList.Clear();
            presentList.AddRange(lombard.Products.Where(
                o => o.Giver == activeUser &&
                Convert.ToInt32(
                    (DateTime.Now - o.DateTime).TotalDays) <= o.StoreDays));
            presentList.AddRange(lombard.Products.Where(o => o.Giver.ID == -1));
            presentList.AddRange(lombard.Products.Where(
                o => Convert.ToInt32(
                    (DateTime.Now - o.DateTime).TotalDays) > o.StoreDays));
            productBindingSource.DataSource = presentList; productBindingSource.ResetBindings(false);
        }

        private void ButtonPurchase_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridViewProducts.Rows.GetRowCount(DataGridViewElementStates.Selected);
            Cart cart = new Cart
            {
                Buyer = activeUser
            };
            for (int i = 0; i < selectedRowCount; i++)
            {
                var toBuy = dataGridViewProducts.SelectedRows[i].DataBoundItem as Product;

                cart.LikedProducts.Add(toBuy);
            }

            var buying = new Purchasing(ref cart);
            if (buying.ShowDialog() == DialogResult.Yes)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    activeUser.PurchasedGoods.Add(cart.LikedProducts[0]);
                    lombard.Products.Remove(cart.LikedProducts[0]);
                    cart.LikedProducts.RemoveAt(0);
                }

                lombard.Clients.Find(o => o.ID == activeUser.ID).PurchasedGoods = activeUser.PurchasedGoods;

                presentList.Clear();
                presentList.AddRange(lombard.Products.Where(
                    o => o.Giver == activeUser &&
                    Convert.ToInt32(
                        (DateTime.Now - o.DateTime).TotalDays) <= o.StoreDays));
                presentList.AddRange(lombard.Products.Where(o => o.Giver.ID == -1));
                presentList.AddRange(lombard.Products.Where(
                    o => Convert.ToInt32(
                        (DateTime.Now - o.DateTime).TotalDays) > o.StoreDays));
                productBindingSource.DataSource = presentList; productBindingSource.ResetBindings(false);

                lombard.IsDirty = true;

                buying = new Purchasing(ref cart);
                buying.ShowDialog();
            }
        }

        private void DataGridViewProducts_BindingContextChanged(object sender, EventArgs e)
        {
        }

        private void DataGridViewProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                var toColor = row.DataBoundItem as Product;
                int days = Convert.ToInt32((DateTime.Now - toColor.DateTime).TotalDays);
                if (days <= 20 && toColor.Giver.ID!=-1)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(32, 92, 86);
                }
            }
        }

        private void pictureBoxHelp_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show(
            "To buy product - select row and click purchase.",
            "Help",
            MessageBoxButtons.OK,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1,
            0,
            "https://github.com/ArtemGavr/Lombard/tree/master/Docs",
            "keyword");
        }
    }
}