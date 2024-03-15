using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal.CodeSigning;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimUoc()
        {
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                return;
            }

            string rs = "";
            int input = Convert.ToInt32(txtInput.Text);
            for (int i = input / 2; i >= 1; i--)
            {
                if (input % i == 0)
                {
                    rs += i.ToString() + " ";
                }
            }

            rs = input.ToString() + " " + rs;

            txtResult.Text = rs;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            TimUoc();
            txtInput.Focus();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                TimUoc();
                txtInput.Focus();
            }
        }


    }
}
