using Lombard_Project.UserClasses;
using System;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class ApplicVerificationClient : Form
    {
        public MyApplication work;

        public ApplicVerificationClient(MyApplication toedit)
        {
            InitializeComponent();
            this.work = toedit;
        }

        private void ClientVerification_Load(object sender, EventArgs e)
        {
            labelName.Text = work.Prod.Name;
            labelPrice.Text = (work.Prod.Value).ToString();
            labelDescription.Text = work.Prod.Description;
            pictureBox.Image = work.Prod.Image;
            labelType.Text = work.Prod.Type;
        }
    }
}