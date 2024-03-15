using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDuongLich_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            if(txtDuongLich.Text == "0")
            {
                txtAmLich.Text = "0";
            }

            if (string.IsNullOrEmpty(txtDuongLich.Text))
            {
                return;
            }

            int dl = Convert.ToInt32(txtDuongLich.Text);

            string al = "";
            int mod1 = dl % 10;
            switch (mod1)
            {
                case 0:
                    al += "Canh";
                    break;
                case 1:
                    al += "Tan";
                    break;
                case 2:
                    al += "Nham";
                    break;
                case 3:
                    al += "Quy";
                    break;
                case 4:
                    al += "Giap";
                    break;
                case 5:
                    al += "At";
                    break;
                case 6:
                    al += "Binh";
                    break;
                case 7:
                    al += "Dinh";
                    break;
                case 8:
                    al += "Mau";
                    break;
                case 9:
                    al += "Ky";
                    break;
            }

            int mod2 = dl % 12;
            switch (mod2)
            {
                case 0:
                    al += " Than";
                    break;
                case 1:
                    al += " Dau";
                    break;
                case 2:
                    al += " Tuat";
                    break;
                case 3:
                    al += " Hoi";
                    break;
                case 4:
                    al += " Ty";
                    break;
                case 5:
                    al += " Suu";
                    break;
                case 6:
                    al += " Dan";
                    break;
                case 7:
                    al += " Meo";
                    break;
                case 8:
                    al += " Thin";
                    break;
                case 9:
                    al += " Ty";
                    break;
                case 10:
                    al += " Ngo";
                    break;
                case 11:
                    al += " Mui";
                    break;
            }

            txtAmLich.Text = al;
        }
    }
}
