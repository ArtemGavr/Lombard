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

namespace ClientApp
{
    public partial class ClientVerification : Form
    {
        //Lombard lombard;
       

        Lombard lombard;
        Client client;
        MyApplication work;
        int index;
        public ClientVerification(ref Lombard lombard, MyApplication toedit,int index, Client client)
        {
            InitializeComponent();
            this.lombard = lombard;
            this.client = client;
            this.work = toedit;
            this.index = index;

        }

        

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            lombard.ApplicationsToUser.Remove(work);
            //lombard.ApplicationsToUser.Add(work);
            Product prod = work.Prod;
            prod.DateTime = DateTime.Now;
            lombard.Products.Add(prod);
            lombard.Save();
            Form CustomerMain = System.Windows.Forms.Application.OpenForms[1];
            CustomerMain.Left = this.Left;
            CustomerMain.Top = this.Top;
            this.Close();
            CustomerMain.Show();


        }

        private void buttonDecline_Click(object sender, EventArgs e)
        {
            lombard.ApplicationsToUser.Remove(work);
            MessageBox.Show("You declined the lombard offer","Decline", MessageBoxButtons.OK);
            lombard.Save();
            Form CustomerMain = System.Windows.Forms.Application.OpenForms[1];
            CustomerMain.Left = this.Left;
            CustomerMain.Top = this.Top;
            this.Close();
            CustomerMain.Show();
        }

        private void ClientVerification_Load(object sender, EventArgs e)
        {
            

            
                textBoxName.Text= work.Prod.Name;
            textBoxPrice.Text=(work.Prod.Value).ToString();
            textBoxDescription.Text=work.Prod.Description;

           
            textBoxProductType.Text = work.Prod.Type;
        }

        private void ClientVerification_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form CustomerMain = System.Windows.Forms.Application.OpenForms[1];
            CustomerMain.Left = this.Left;
            CustomerMain.Top = this.Top;
            CustomerMain.Show();
        }

        

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form CustomerMain = System.Windows.Forms.Application.OpenForms[1];
            CustomerMain.Left = this.Left;
            CustomerMain.Top = this.Top;
            CustomerMain.Show();
        }
    }
}
