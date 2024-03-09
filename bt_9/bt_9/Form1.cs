using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_9
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
            if(string.IsNullOrEmpty(txtA.Text) && string.IsNullOrEmpty(txtB.Text) && string.IsNullOrEmpty(txtC.Text))
            {
                return;
            }

            double a = 0;
            double b = 0;
            double c = 0;

            if (!string.IsNullOrEmpty(txtA.Text))
            {
                a = Convert.ToDouble(txtA.Text);
            }
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
            if(a == 0)//giai pt bac 1
            {
                
                if(b == 0)
                {
                    if(c == 0)
                    {
                        MessageBox.Show("Phương trình có vô số nghiệm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Phương trình vô nghiệm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    txtNghiem1.Text = (-c / b).ToString(); 
                }
            }
            else//giai pt bac 2
            {
                if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    txtNghiem1.Text = x1.ToString();
                    txtNghiem2.Text = x2.ToString();
                }
                else if (delta > 0)
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
