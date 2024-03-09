using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool Validate()
        {
            if(string.IsNullOrEmpty(txtX.Text.Trim()) && string.IsNullOrEmpty(txtX.Text.Trim())) 
            {
                return false;
            }

            return true;
        }

        private bool ValidateX()
        {
            if (string.IsNullOrEmpty(txtX.Text.Trim()))
            {
                return false;
            }

            return true;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                return;
            }
            double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);
            txtKQ.Text = (x + y).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                return;
            }
            double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);
            txtKQ.Text = (x - y).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                return;
            }
            double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);
            txtKQ.Text = (x * y).ToString();
        }

        private void btnMu2_Click(object sender, EventArgs e)
        {
            if (!ValidateX())
            {
                return;
            }
            double x = Convert.ToDouble(txtX.Text);
            txtKQ.Text = (x * x).ToString();
        }

        private void bntMu3_Click(object sender, EventArgs e)
        {
            if (!ValidateX())
            {
                return;
            }
            double x = Convert.ToDouble(txtX.Text);
            txtKQ.Text = (x * x * x).ToString();
        }

        private void btnMu12_Click(object sender, EventArgs e)
        {
            if (!ValidateX())
            {
                return;
            }
            double x = Convert.ToDouble(txtX.Text);
            txtKQ.Text = Math.Sqrt(x).ToString();
        }
    }
}
