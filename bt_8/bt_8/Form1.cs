using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtA.Text.Trim()))
            {
                MessageBox.Show("Bạn chưa nhập hệ số a", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Focus();
                return;
            }

            double a = Convert.ToDouble(txtA.Text);
            double b = 0;
            double c = 0;
            if (!string.IsNullOrEmpty(txtB.Text))
            {
                b = Convert.ToDouble(txtB.Text);
            }
            if (!string.IsNullOrEmpty(txtC.Text))
            {
                c = Convert.ToDouble(txtC.Text);
            }

            double delta = b * b - 4 * a * c;

            double x1 = 0;
            double x2 = 0;

            if(delta == 0)
            {
                x1 = x2 = -b / (2 * a);
                txtNghiem1.Text = x1.ToString();
                txtNghiem2.Text = x2.ToString();
            }
            else if(delta > 0) 
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                txtNghiem1.Text = x1.ToString();
                txtNghiem2.Text = x2.ToString();
            }
            else
            {
                MessageBox.Show("Phương trình vô nghiệm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
