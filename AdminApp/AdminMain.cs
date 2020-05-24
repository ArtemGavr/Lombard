using Lombard_Project.UserClasses;
using System;
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lombard.Save();
            MessageBox.Show("Information is saved", "Artem", MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewApplics_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var toedit = dataGridViewApplics.Rows[e.RowIndex].DataBoundItem as MyApplication;
            if (toedit != null)
            {
                var edit = new ApplicEditionAdmin(toedit);
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridViewProducts.Rows.GetRowCount(DataGridViewElementStates.Selected);
            for (int i = 0; i < selectedRowCount; i++)
            {
                var toDel = dataGridViewProducts.SelectedRows[i].DataBoundItem as Product;
                var res = MessageBox.Show($"Delete {toDel.Name} ?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    lombard.Products.Remove(toDel);
                    //productBindingSource.ResetBindings(false);
                    lombard.IsDirty = true;
                }
            }
            productBindingSource.ResetBindings(false);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridViewProducts.Rows.GetRowCount(DataGridViewElementStates.Selected);
            for (int i = 0; i < selectedRowCount; i++)
            {
                var toEdit = dataGridViewProducts.SelectedRows[0].DataBoundItem as Product;
                var pf = new ProductEditForm(toEdit);
                if (pf.ShowDialog() == DialogResult.OK)
                {
                    productBindingSource.ResetBindings(false);
                    lombard.IsDirty = true;
                }
            }
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            var adding = new ProductAddForm(ref lombard);
            if (adding.ShowDialog() == DialogResult.OK)
            {
                productBindingSource.ResetBindings(false);
                lombard.IsDirty = true;
            }
            productBindingSource.ResetBindings(false);
        }
    }
}