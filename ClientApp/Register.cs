using Lombard_Project.UserClasses;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Register : Form
    {
        private Lombard lombard;

        public Register(ref Lombard lombard)
        {
            InitializeComponent();
            this.lombard = lombard;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegName.Text) || string.IsNullOrWhiteSpace(RegPassword.Text) || string.IsNullOrWhiteSpace(IDbox.Text))
            {
                if (string.IsNullOrWhiteSpace(RegName.Text))
                {
                    RegName.BackColor = Color.Red;
                }
                if (string.IsNullOrWhiteSpace(RegPassword.Text))
                {
                    RegPassword.BackColor = Color.Red;
                }
                if (string.IsNullOrWhiteSpace(IDbox.Text))
                {
                    RegPassword.BackColor = Color.Red;
                }
                MessageBox.Show("Fill in the blank space, please");
                RegName.BackColor = Color.White;
                RegPassword.BackColor = Color.White;
                IDbox.BackColor = Color.White;
            }
            else if (RegName.Text.Length <= 2 || RegName.Text.Length >= 10)
            {
                RegName.BackColor = Color.Red;
                MessageBox.Show("Name has inappropriate length, try again");
                RegName.BackColor = Color.White;
                RegName.Text = string.Empty;
            }
            else if (RegPassword.Text.Length <= 4 || RegPassword.Text.Length >= 10)
            {
                RegPassword.BackColor = Color.Red;
                RegPassReenter.BackColor = Color.Red;
                MessageBox.Show("Password has inappropriate length, try again");
                RegPassword.BackColor = Color.White;
                RegPassword.Text = string.Empty;
                RegPassReenter.BackColor = Color.White;
                RegPassReenter.Text = string.Empty;
            }
            else if (RegPassReenter.Text != RegPassword.Text)
            {
                RegPassword.BackColor = Color.Red;
                RegPassReenter.BackColor = Color.Red;
                MessageBox.Show("Passwords don't match, try again");
                RegPassword.BackColor = Color.White;
                RegPassword.Text = string.Empty;
                RegPassReenter.BackColor = Color.White;
                RegPassReenter.Text = string.Empty;
            }
            else if (IDbox.Text.Length != 9)
            {
                IDbox.BackColor = Color.Red;
                MessageBox.Show("id has inappropriate length, try again");
                IDbox.BackColor = Color.White;
                IDbox.Text = string.Empty;
            }
            //filled and long enough
            else
            {
                string login = RegName.Text;
                string password = (RegPassword.Text);
                int iD = Convert.ToInt32(IDbox.Text);
                // unique users
                if (lombard.Clients.FirstOrDefault(u => u.Name == login && u.ID == iD) != null)
                {
                    MessageBox.Show("Sorry, such Client already exist...Change your login");
                    RegName.Text = string.Empty;
                    RegPassword.Text = string.Empty;
                }
                else
                {
                    Client user = new Client(iD, login, password);
                    lombard.Clients.Add(user);
                    MessageBox.Show("We are glad to hear you joined us!");
                    lombard.Save();
                    Form main = new ClientMain(ref lombard, user);
                    main.Show();

                    this.Close();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form CustomerAutor = System.Windows.Forms.Application.OpenForms[0];
            CustomerAutor.Left = this.Left;
            CustomerAutor.Top = this.Top;
            CustomerAutor.Show();
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                Form CustomerAutor = System.Windows.Forms.Application.OpenForms[0];
                CustomerAutor.Left = this.Left;
                CustomerAutor.Top = this.Top;
                CustomerAutor.Show();
            }
        }
    }
}