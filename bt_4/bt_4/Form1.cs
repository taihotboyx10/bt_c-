using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_4
{
    public partial class Form1 : Form
    {
        private FontStyle currentStyle = FontStyle.Regular;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pic2.Visible = false;
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            pic1.Visible = false;
            pic2.Visible = true;
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            pic1.Visible = true;
            pic2.Visible = false;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Bạn chưa nhập tên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblDisplay.Text = txtName.Text + ": " + txtMsg.Text;

        }

        private void rdRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRed.Checked)
            {
                lblDisplay.ForeColor = Color.Red;
            }
        }

        private void rdGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGreen.Checked)
            {
                lblDisplay.ForeColor = Color.Green;
            }
        }

        private void rdBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBlue.Checked)
            {
                lblDisplay.ForeColor = Color.Blue;
            }
        }

        private void rdBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBlack.Checked)
            {
                lblDisplay.ForeColor = Color.Black;
            }
        }

        private void SetLblStyle()
        {
            lblDisplay.Font = new Font(lblDisplay.Font, currentStyle);
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBold.Checked)
            {
                currentStyle |= FontStyle.Bold;
            }
            else
            {
                currentStyle &= ~FontStyle.Bold;
            }
            SetLblStyle();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItalic.Checked)
            {
                currentStyle |= FontStyle.Italic;
            }
            else
            {
                currentStyle &= ~FontStyle.Italic;
            }
            SetLblStyle();
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnderline.Checked)
            {
                currentStyle |= FontStyle.Underline;
            }
            else
            {
                currentStyle &= ~FontStyle.Underline;
            }
            SetLblStyle();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtMsg.Text = "";
            lblDisplay.Text = "";
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
