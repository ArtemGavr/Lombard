using Lombard_Project.UserClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class AplicsView : Form
    {
        private Lombard lombard;

        public AplicsView(ref Lombard lombard)
        {
            InitializeComponent();
            this.lombard = lombard;
        }
    }
}
