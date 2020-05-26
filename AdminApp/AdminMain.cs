using Lombard_Project.UserClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class AdminMain : Form
    {
        private Lombard lombard;

        public AdminMain()
        {
            InitializeComponent();
            lombard = new Lombard();

            productBindingSource.DataSource = lombard.Products;
            myApplicationBindingSource1.DataSource = lombard.ApplicationsToAdmin;
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            lombard.Load();
            //lombard.FillTestData(10);
            //lombard.IsDirty = true;
            productBindingSource.ResetBindings(false);
            myApplicationBindingSource1.ResetBindings(false);
        }

        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!lombard.IsDirty)
                return;
            var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;

                case DialogResult.Yes:
                    lombard.Save();
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lombard.Save();
            MessageBox.Show("Information is saved", "Artem", MessageBoxButtons.OK);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewApplics_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var toedit = dataGridViewApplics.Rows[e.RowIndex].DataBoundItem as MyApplication;
            if (toedit != null)
            {
                var edit = new EditApplicAdmin(toedit);
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    lombard.ApplicationsToAdmin.Remove(edit.work);///
                    lombard.ApplicationsToUser.Add(edit.work);
                    lombard.Save();
                    myApplicationBindingSource1.ResetBindings(false);
                }
                myApplicationBindingSource1.ResetBindings(false);
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridViewProducts.Rows.GetRowCount(DataGridViewElementStates.Selected);
            List<Product> deletion = new List<Product>();
            for (int i = 0; i < selectedRowCount; i++)
            {
                var toDel = dataGridViewProducts.SelectedRows[i].DataBoundItem as Product;
                var res = MessageBox.Show($"Delete {toDel.Name} ?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    deletion.Add(toDel);
                }
            }
            for (int i = 0; i < deletion.Count; i++) 
            {
                lombard.Products.Remove(deletion[i]);
                lombard.IsDirty = true;
            }
            
            productBindingSource.ResetBindings(false);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridViewProducts.Rows.GetRowCount(DataGridViewElementStates.Selected);
            for (int i = 0; i < selectedRowCount; i++)
            {
                var toEdit = dataGridViewProducts.SelectedRows[0].DataBoundItem as Product;
                var pf = new EditProductForm(toEdit);
                if (pf.ShowDialog() == DialogResult.OK)
                {
                    productBindingSource.ResetBindings(false);
                    lombard.IsDirty = true;
                }
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var adding = new AddProductForm(ref lombard);
            if (adding.ShowDialog() == DialogResult.OK)
            {
                productBindingSource.ResetBindings(false);
                lombard.IsDirty = true;
            }
            productBindingSource.ResetBindings(false);
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "To get help click help",
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