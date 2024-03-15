namespace bt_13
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnGiaiThua = new System.Windows.Forms.Button();
            this.btnChiaGiaiThua = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "N=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết Quả";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(128, 35);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(152, 22);
            this.txtInput.TabIndex = 2;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(128, 79);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(152, 22);
            this.txtResult.TabIndex = 3;
            // 
            // btnGiaiThua
            // 
            this.btnGiaiThua.Location = new System.Drawing.Point(63, 131);
            this.btnGiaiThua.Name = "btnGiaiThua";
            this.btnGiaiThua.Size = new System.Drawing.Size(217, 23);
            this.btnGiaiThua.TabIndex = 4;
            this.btnGiaiThua.Text = "Tính N!";
            this.btnGiaiThua.UseVisualStyleBackColor = true;
            this.btnGiaiThua.Click += new System.EventHandler(this.btnGiaiThua_Click);
            // 
            // btnChiaGiaiThua
            // 
            this.btnChiaGiaiThua.Location = new System.Drawing.Point(63, 172);
            this.btnChiaGiaiThua.Name = "btnChiaGiaiThua";
            this.btnChiaGiaiThua.Size = new System.Drawing.Size(217, 23);
            this.btnChiaGiaiThua.TabIndex = 5;
            this.btnChiaGiaiThua.Text = "Tính N!/(N+1)!";
            this.btnChiaGiaiThua.UseVisualStyleBackColor = true;
            this.btnChiaGiaiThua.Click += new System.EventHandler(this.btnChiaGiaiThua_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(63, 212);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(217, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Kết Thúc";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 279);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnChiaGiaiThua);
            this.Controls.Add(this.btnGiaiThua);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnGiaiThua;
        private System.Windows.Forms.Button btnChiaGiaiThua;
        private System.Windows.Forms.Button btnBack;
    }
}

