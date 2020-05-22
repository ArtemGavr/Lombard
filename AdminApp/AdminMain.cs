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
    public partial class AdminMain : Form
    {
        Lombard lombard;
        public AdminMain()
        {
            InitializeComponent();
            lombard = new Lombard();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            lombard.Load();
        }

        private void buttonApplications_Click(object sender, EventArgs e)
        {
            Form aplics = new ApplicsAdmin(ref lombard);
            this.Hide();
            aplics.Show();
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
            if (!lombard.IsDirty)
                this.Close();
            var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    
                    break;
                case DialogResult.Yes:
                    lombard.Save();
                    this.Close();
                    break;
                case DialogResult.No:
                    this.Close();
                    break;
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lombard.Save();
            MessageBox.Show("Information is saved", "Artem", MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!lombard.IsDirty)
                this.Close();
            var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:

                    break;
                case DialogResult.Yes:
                    lombard.Save();
                    this.Close();
                    break;
                case DialogResult.No:
                    this.Close();
                    break;
            }
        }
    



        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string login = "user2";
        //    string password = "123456";
        //    int iD = 123456789;
        //    // unique users

        //    {


        //        Client user = new Client(iD, login, password);
        //        lombard.Clients.Add(user);
        //        MessageBox.Show("We are glad to hear you joined us!");
        //        lombard.Save();
        //    }
        //}
    }
}
