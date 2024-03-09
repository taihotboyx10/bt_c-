using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtST2.Focus();
        }

        private bool ValidateTxt()
        {
            if(string.IsNullOrEmpty(txtST1.Text.Trim()) && string.IsNullOrEmpty(txtST1.Text.Trim())) 
            { 
                return false;
            }

            return true;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (!ValidateTxt())
            {
                return;
            }
            double st1 = Convert.ToDouble(txtST1.Text);
            double st2 = Convert.ToDouble(txtST2.Text);
            txtKQ.Text = (st1 + st2).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (!ValidateTxt())
            {
                return;
            }
            double st1 = Convert.ToDouble(txtST1.Text);
            double st2 = Convert.ToDouble(txtST2.Text);
            txtKQ.Text = (st1 - st2).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (!ValidateTxt())
            {
                return;
            }
            double st1 = Convert.ToDouble(txtST1.Text);
            double st2 = Convert.ToDouble(txtST2.Text);
            txtKQ.Text = (st1 * st2).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (!ValidateTxt())
            {
                return;
            }
            double st1 = Convert.ToDouble(txtST1.Text);
            double st2 = Convert.ToDouble(txtST2.Text);
            
            if(st2 == 0)
            {
                MessageBox.Show("Không thể chia cho 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double rs = st1 / st2;
            txtKQ.Text = rs.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtST1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtST2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
