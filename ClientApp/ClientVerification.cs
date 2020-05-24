using Lombard_Project.UserClasses;
using System;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class ClientVerification : Form
    {
        public MyApplication work;

        public ClientVerification(MyApplication toedit)
        {
            InitializeComponent();
            this.work = toedit;
        }

        private void ClientVerification_Load(object sender, EventArgs e)
        {
            textBoxName.Text = work.Prod.Name;
            textBoxPrice.Text = (work.Prod.Value).ToString();
            textBoxDescription.Text = work.Prod.Description;

            textBoxProductType.Text = work.Prod.Type;
        }
    }
}