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
    public partial class ApplicClient : Form
    {
        Lombard lombard;
        Client activeuser;
        //Form papa;
        public ApplicClient(ref Lombard lombard, Client user)
        {
            InitializeComponent();
            this.lombard = lombard;
            this.activeuser = user;
            //this.papa = papa;
        }

        private void Applic_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form CustomerAutor = System.Windows.Forms.Application.OpenForms[1];
            CustomerAutor.Left = this.Left;
            CustomerAutor.Top = this.Top;
            CustomerAutor.Show();
            this.Close();
        }

        private void buttonSendAppl_Click(object sender, EventArgs e)
        {
            #region correctcheck
            int number;
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxPriceDesired.Text) )
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    textBoxName.BackColor = Color.Red;
                }
                if (string.IsNullOrWhiteSpace(textBoxPriceDesired.Text))
                {

                    textBoxPriceDesired.BackColor = Color.Red;
                }
                
                MessageBox.Show("Fill in the blank space, please");
                textBoxName.BackColor = Color.White;
                textBoxPriceDesired.BackColor = Color.White;
                
            }
            else if (textBoxName.Text.Length <= 2 )
            {
                textBoxName.BackColor = Color.Red;
                MessageBox.Show("Name/Adress has inappropriate length, try again");
                textBoxName.BackColor = Color.White;
                textBoxName.Text = string.Empty;
            }
            else if (!int.TryParse(textBoxPriceDesired.Text, out number))
            {
                textBoxPriceDesired.BackColor = Color.Red;
                MessageBox.Show("Price is not  number, try again");
                textBoxPriceDesired.BackColor = Color.White;
                textBoxPriceDesired.Text = string.Empty;
              
            }
#endregion
            //filled and long enough
            else
            {
                string text = textBoxName.Text;
                int price = Convert.ToInt32(textBoxPriceDesired.Text);
  

                if (radioButtonItemName.Checked == true)
                {

                }

                //MyApplication applic= new MyApplication (  ,activeUser );
                // lombard.ApplicationsToAdmin.Add(applic);
                MessageBox.Show("Application added succesfully!");
                lombard.Save();
                Form CustomerMain = System.Windows.Forms.Application.OpenForms[1];
                CustomerMain.Left = this.Left;
                CustomerMain.Top = this.Top;
                CustomerMain.Show();

                this.Close();

                


            }
        }

       

        private void ApplicClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form CustomerMain = System.Windows.Forms.Application.OpenForms[1];
            CustomerMain.Left = this.Left;
            CustomerMain.Top = this.Top;
            CustomerMain.Show();
        }
    }
}
