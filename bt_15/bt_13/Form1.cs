using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private int TinhTong(int input)
        {
            int rs = 0;
            for(int i = 1;i<= input;i++)
            {
                rs += i;
            }

            return rs;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(txtInput.Text);
            txtResult.Text = TinhTong(input).ToString();
        }

        private void btnTongMu2_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(txtInput.Text);
            int rs = TinhTong(input);
            txtResult.Text = (rs*rs).ToString();
        }

        private int TongMuN(int input)
        {
            int rs = 0;
            for(int i = 1;i<= input; i++)
            {
                rs += (int)Math.Pow(i, i+1);
            }

            return rs;
        }
        private void btnTongMuN_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(txtInput.Text);
            txtResult.Text = TongMuN(input).ToString();
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(txtInput.Text);
            int rs1 = TinhTong(input);
            int rs2 = TongMuN(input);
            try
            {
                txtResult.Text = ((double)rs1 / rs2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
