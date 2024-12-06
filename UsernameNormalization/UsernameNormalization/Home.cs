using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsernameNormalization
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnBuckToHome_Click(object sender, EventArgs e)
        {
            FormController.pageTransition(this, "G000",false);
        }

        private void btnEndApp_Click(object sender, EventArgs e)
        {
            FormController.pageTransition(this, "endApp", false);
        }
    }
}
