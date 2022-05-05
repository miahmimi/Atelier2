using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier2
{
    public partial class Form1 : Form
    {
        bool focus = false;
        public Form1()
        {
            InitializeComponent();
            btnValider.Enabled = false;
            txtLogin.Focus();

           
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (txtLogin.Text != "")
            {
                btnValider.Enabled = true;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Liste frm = new Liste();
            frm.Show();
            this.Hide();
        }
    }
}
