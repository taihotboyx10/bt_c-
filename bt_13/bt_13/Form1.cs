using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_13
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

        private int TinhGiaiThua(int n)
        {
            int rs = 1;
            for (int i = 1; i <= n; i++)
            {
                rs *= i;
            }
            return rs;
        }

        private void btnGiaiThua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                return;
            }

            int input = Convert.ToInt32(txtInput.Text);
            int rs = TinhGiaiThua(input);

            txtResult.Text = rs.ToString();

        }

        private void btnChiaGiaiThua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                return;
            }

            int input = Convert.ToInt32(txtInput.Text);
            double rs1 = TinhGiaiThua(input);
            double rs2 = TinhGiaiThua(input + 1);

            txtResult.Text = (rs1/rs2).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
