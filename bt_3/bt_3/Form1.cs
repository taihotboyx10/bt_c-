using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            HiddenImage();

        }

        private void HiddenImage()
        {
            picCloudy.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSunny.Visible = false;
        }
        private void DisplayImgAndMsg()
        {
            HiddenImage();

            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Bạn chưa nhập tên của mình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Text = "";
                txtName.Focus ();
                rdCloudy.Checked = false;
                rdRainy.Checked = false;
                rdSnowy.Checked = false;
                rdSunny.Checked = false;
                return;
            }

            if (rdCloudy.Checked)
            {
                picCloudy.Visible=true;
                lblDisplay.Text = txtName.Text + ": Hôm nay trời mát, chúc bạn một ngày vui vẻ";
            }
            if (rdRainy.Checked)
            {
                picRainy.Visible = true;
                lblDisplay.Text = txtName.Text + ": Hôm nay trời mưa, ra đường nhớ mang theo ô bạn nhé";
            }
            if (rdSnowy.Checked)
            {
                picSnowy.Visible = true;
                lblDisplay.Text = txtName.Text + ": Hôm nay tuyết rơi, nhớ mặc ấm bạn nhé";
            }
            if (rdSunny.Checked)
            {
                picSunny.Visible = true;
                lblDisplay.Text = txtName.Text + ": Hôm nay trời năng, ra đường nhớ đội mũ bạn nhé";
            }
        }

        private void rdCloudy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCloudy.Checked)
            {
                DisplayImgAndMsg();
            }
        }

        private void rdRainy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRainy.Checked)
            {
                DisplayImgAndMsg();
            }
        }

        private void rdSnowy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSnowy.Checked)
            {
                DisplayImgAndMsg();
            }
        }

        private void rdSunny_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSunny.Checked)
            {
                DisplayImgAndMsg();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
