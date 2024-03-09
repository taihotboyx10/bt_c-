using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiaiLai_Click(object sender, EventArgs e)
        {
            txtA.Text = txtB.Text = txtKQ.Text = "";
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtA.Text.Trim()) || string.IsNullOrEmpty(txtB.Text.Trim()))
            {
                return;
            }

            double x = Convert.ToDouble(txtA.Text);
            double y = Convert.ToDouble(txtB.Text);


            if(x == 0 && y == 0)
            {
                txtKQ.Text = "Vô số nghiệm";
            }
            else if (x == 0 && y != 0) 
            {
                txtKQ.Text = "Vô nghiệm";
            }
            else
            {
                txtKQ.Text = "Nghiệm = " + (-y/x).ToString("");
            }

        }
    }
}
