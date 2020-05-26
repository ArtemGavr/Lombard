using Lombard_Project.UserClasses;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class SignUpForm : Form
    {
        private Lombard lombard;

        public SignUpForm()
        {
            InitializeComponent();
            lombard = new Lombard();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            lombard.Load();

            //lombard.FillTestData(100);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.ForeColor = Color.Red;
        }

        private void ButtonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.ForeColor = Color.Black;
        }

        private Point lastPoint;

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            Form register = new Register(ref lombard);
            this.Hide();
            register.Show();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || string.IsNullOrWhiteSpace(textBoxPass.Text))
            {
                if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
                {
                    textBoxLogin.BackColor = Color.Red;
                }
                if (string.IsNullOrWhiteSpace(textBoxPass.Text))
                {
                    textBoxPass.BackColor = Color.Red;
                }

                MessageBox.Show("Fill in the blank space, please");
                textBoxLogin.BackColor = Color.White;
                textBoxPass.BackColor = Color.White;
            }
            else if (textBoxLogin.Text.Length <= 2 || textBoxLogin.Text.Length >= 10)
            {
                textBoxLogin.BackColor = Color.Red;
                MessageBox.Show("Name has inappropriate length, try again");
                textBoxLogin.BackColor = Color.White;
                textBoxLogin.Text = string.Empty;
            }
            else if (textBoxPass.Text.Length <= 4 || textBoxPass.Text.Length >= 10)
            {
                textBoxPass.BackColor = Color.Red;
                MessageBox.Show("Password has inappropriate length, try again");
                textBoxPass.BackColor = Color.White;
                textBoxPass.Text = string.Empty;
            }
            //filled and long enough
            else
            {
                string login = textBoxLogin.Text;
                string password = (textBoxPass.Text);
                // uniwue users
                if (lombard.Clients.FirstOrDefault(u => u.Name.ToLower() == login.ToLower() && u.Password == password) != null)
                {
                    Form main = new ClientMain(ref lombard, lombard.Clients.FirstOrDefault(u => u.Name == login && u.Password == password));
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sorry, such Client doesn`t exist...Try again or Register");
                    textBoxLogin.Text = string.Empty;
                    textBoxPass.Text = string.Empty;
                }
            }
        }

        private void SignUpForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonLogin_Click(sender, e);
            }
        }
    }
}