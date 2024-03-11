using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_11
{
    public partial class Form1 : Form
    {
        private string resultText = "";
        private double result = 0;
        private bool shouldContinue = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resultText = "";
            txtResult.Text = "";
            txtResult.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            resultText += "1";
            txtResult.Text = resultText;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            resultText += "2";
            txtResult.Text = resultText;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            resultText += "3";
            txtResult.Text = resultText;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            resultText += "4";
            txtResult.Text = resultText;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            resultText += "5";
            txtResult.Text = resultText;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            resultText += "6";
            txtResult.Text = resultText;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            resultText += "7";
            txtResult.Text = resultText;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            resultText += "8";
            txtResult.Text = resultText;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            resultText += "9";
            txtResult.Text = resultText;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            resultText += "0";
            txtResult.Text = resultText;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            resultText += ".";
            txtResult.Text = resultText;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            resultText += "+";
            txtResult.Text = resultText;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            resultText += "-";
            txtResult.Text = resultText;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            resultText += "*";
            txtResult.Text = resultText;
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            resultText += "/";
            txtResult.Text = resultText;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            resultText = txtResult.Text;

            try
            {
                EvaluateExpression(resultText);

                if(shouldContinue)
                {
                    resultText += "=";
                    txtResult.Text = resultText + result;
                }
                resultText = "";
                shouldContinue = true;
            }
            catch
            {
                MessageBox.Show("Biểu thức đã nhập không đúng cú pháp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Focus();
                return;
            }
        }

        private void EvaluateExpression(string expression)
        {
            // Tạo danh sách lưu trữ các toán tử và toán hạng
            List<double> operands = new List<double>();
            List<char> operators = new List<char>();

            // Phân tích chuỗi biểu thức để tách các toán tử và toán hạng
            string numberBuffer = "";
            foreach (char c in expression)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    numberBuffer += c; // Nếu là chữ số hoặc dấu chấm, thêm vào buffer
                }
                else
                {
                    // Nếu là toán tử, chuyển buffer thành toán hạng và thêm vào danh sách
                    operands.Add(double.Parse(numberBuffer));
                    numberBuffer = "";

                    // Thêm toán tử vào danh sách
                    operators.Add(c);
                }
            }

            // Xử lý toán hạng cuối cùng (sau khi kết thúc chuỗi)
            operands.Add(double.Parse(numberBuffer));

            // Thực hiện các phép tính theo thứ tự ưu tiên của các toán tử
            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == '=') 
                {
                    MessageBox.Show("Biểu thức đã nhập không đúng cú pháp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtResult.Focus();
                    shouldContinue = false;
                    return;
                }

                if (operators[i] == '*')
                {
                    operands[i] *= operands[i + 1];
                    operands.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i--; // Để xử lý lại toán tử tiếp theo (nếu có) sau khi xóa
                }
                else if (operators[i] == '/')
                {
                    if(operands[i + 1] == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtResult.Focus();
                        shouldContinue = false;
                        return;
                    }
                    operands[i] /= operands[i + 1];
                    operands.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i--; // Để xử lý lại toán tử tiếp theo (nếu có) sau khi xóa
                }
            }

            // Thực hiện các phép tính còn lại (cộng và trừ)
            result = operands[0];
            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == '+')
                {
                    result += operands[i + 1];
                }
                else if (operators[i] == '-')
                {
                    result -= operands[i + 1];
                }
            }
        }

        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (!char.IsDigit(e.KeyChar) 
                && (e.KeyChar != (char)Keys.Back)
                && (e.KeyChar != '.')
                && (e.KeyChar != '+')
                && (e.KeyChar != '-')
                && (e.KeyChar != '*')
                && (e.KeyChar != '/')
                && (e.KeyChar != '='))
            {
                e.Handled = true;
            }
        }

        //Nên enable false phím = sau khi cho ra kết quả 
    }
}
