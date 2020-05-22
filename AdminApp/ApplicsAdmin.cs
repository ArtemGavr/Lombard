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
    public partial class ApplicsAdmin : Form
    {
        Lombard lombard;
        public ApplicsAdmin(ref Lombard lombard)
        {
            InitializeComponent();
            this.lombard = lombard;
        }

        private void Applics_Load(object sender, EventArgs e)
        {

        }

        private void buttonSendAppl_Click(object sender, EventArgs e)
        {

        }
    }
}
