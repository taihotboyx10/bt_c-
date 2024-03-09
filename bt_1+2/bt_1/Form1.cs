using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
            lblHoLot.Text = txtHoLot.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblTen.Text = txtTen.Text;
        }

        private void btnHoVaTen_Click(object sender, EventArgs e)
        {
            lblHoVaTen.Text = txtHoLot.Text + " " + txtTen.Text;
        }

        private void lblHoVaTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoVaTen.Text = "";
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtHoLot_TextChanged(object sender, EventArgs e)
        {
            lblHoLot.Text = txtHoLot.Text;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            lblTen.Text = txtTen.Text;
        }
    }
}
