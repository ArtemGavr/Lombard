﻿using Lombard_Project.UserClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Purchasing : Form
    {
        public Cart cart;
        public Purchasing()
        {
            InitializeComponent();
        }
        public Purchasing(ref Cart cart):this()
        {
            this.cart = cart;
            productBindingSource.DataSource = this.cart.LikedProducts;
            productBindingSourcePurchased.DataSource = this.cart.Buyer.PurchasedGoods;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (cart.LikedProducts.Count > 0)
            {
                var res = MessageBox.Show($"Are you sure about the purchase?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    DialogResult = DialogResult.Yes;
                }
            }
            else
            {
                MessageBox.Show($"You have nothing to buy", "", MessageBoxButtons.OK);
            }
        }

        private void Purchasing_Load(object sender, EventArgs e)
        {
            productBindingSource.ResetBindings(false);
            productBindingSourcePurchased.ResetBindings(false);
            if (cart.LikedProducts.Count < 1)
            {
                tabControl1.Select();
               tabControl1.DeselectTab("tabPageBuy");
            }
        }
    }
}
