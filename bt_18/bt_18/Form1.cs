using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdStop.Checked = true;
            rdOk.Checked = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private MessageBoxButtons GetButtonType()
        {
            if(rdOk.Checked)
            {
                return MessageBoxButtons.OK;
            }
            if(rdOkCancel.Checked)
            {
                return MessageBoxButtons.OKCancel;
            }
            if (rdARI.Checked)
            {
                return MessageBoxButtons.AbortRetryIgnore;
            }
            if (rdYNC.Checked)
            {
                return MessageBoxButtons.YesNoCancel;
            }
            if(rdYesNo.Checked)
            {
                return MessageBoxButtons.YesNo;
            }
            if(rdRetryCancel.Checked)
            {
                return MessageBoxButtons.RetryCancel;
            }

            return MessageBoxButtons.OK;
        }

        private MessageBoxIcon GetIconType()
        {
            if (rdStop.Checked)
            {
                return MessageBoxIcon.Stop;
            }
            if (rdQuestion.Checked)
            {
                return MessageBoxIcon.Question;
            }
            if (rdExc.Checked)
            {
                return MessageBoxIcon.Exclamation;
            }
            if (rdInfor.Checked)
            {
                return MessageBoxIcon.Information;
            }
            
            return MessageBoxIcon.Stop;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là một dạng của Message Box", "Message Box", GetButtonType(), GetIconType());
        }
    }
}
