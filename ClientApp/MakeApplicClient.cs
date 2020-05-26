using Lombard_Project.UserClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class MakeApplicClient : Form
    {
        private Lombard lombard;
        private Client activeuser;

        //Product intake;
        //Form papa;
        public MakeApplicClient(ref Lombard lombard, Client user)
        {
            InitializeComponent();
            this.lombard = lombard;
            this.activeuser = user;
            //this.papa = papa;
        }

        private void Applic_Load(object sender, EventArgs e)
        {
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Form CustomerAutor = System.Windows.Forms.Application.OpenForms[1];
            CustomerAutor.Left = this.Left;
            CustomerAutor.Top = this.Top;
            CustomerAutor.Show();
            this.Close();
        }

        private void ButtonSendAppl_Click(object sender, EventArgs e)
        {
            #region correctcheck

            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxPriceDesired.Text))
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
            else if (textBoxName.Text.Length <= 2)
            {
                textBoxName.BackColor = Color.Red;
                MessageBox.Show("Name/Adress has inappropriate length, try again");
                textBoxName.BackColor = Color.White;
                textBoxName.Text = string.Empty;
            }
            else if (!int.TryParse(textBoxPriceDesired.Text, out int number))
            {
                textBoxPriceDesired.BackColor = Color.Red;
                MessageBox.Show("Price is not  number, try again");
                textBoxPriceDesired.BackColor = Color.White;
                textBoxPriceDesired.Text = string.Empty;
            }

            #endregion correctcheck

            //filled and long enough
            else
            {
                string text = textBoxName.Text;
                int price = Convert.ToInt32(textBoxPriceDesired.Text);
                string description = textBoxDescription.Text;

                Image noImage = pictureBox.Image;

                if (radioButtonItemName.Checked == true)
                {
                    Product intake = new Item(text, price, activeuser, description, noImage);
                    MyApplication applic = new MyApplication((Product)intake, activeuser);
                    lombard.ApplicationsToAdmin.Add(applic);
                    // MessageBox.Show(intake.ToString(),"",MessageBoxButtons.OK);
                }

                if (radioButtonProperty.Checked == true)
                {
                    Product intake = new Property(text, price, activeuser, description) { Image = noImage };
                    MyApplication applic = new MyApplication((Product)intake, activeuser);
                    lombard.ApplicationsToAdmin.Add(applic);
                    //MessageBox.Show(intake.ToString(), "", MessageBoxButtons.OK);
                }

                //MessageBox.Show((lombard.ApplicationsToAdmin[lombard.ApplicationsToAdmin.Count()-1].Prod.ToString()), "", MessageBoxButtons.OK);
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

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
    }
}