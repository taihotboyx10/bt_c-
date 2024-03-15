namespace bt_15
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
            this.btnTong = new System.Windows.Forms.Button();
            this.btnTongMu2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTich = new System.Windows.Forms.Button();
            this.btnTongMuN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "N=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết Quả";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(126, 35);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(190, 22);
            this.txtInput.TabIndex = 2;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(126, 79);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(190, 22);
            this.txtResult.TabIndex = 3;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(42, 131);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(274, 23);
            this.btnTong.TabIndex = 4;
            this.btnTong.Text = "Tính 1+2+3+...+N";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnTongMu2
            // 
            this.btnTongMu2.Location = new System.Drawing.Point(42, 169);
            this.btnTongMu2.Name = "btnTongMu2";
            this.btnTongMu2.Size = new System.Drawing.Size(274, 23);
            this.btnTongMu2.TabIndex = 5;
            this.btnTongMu2.Text = "Tính (1+2+3+...+N) Bình Phương";
            this.btnTongMu2.UseVisualStyleBackColor = true;
            this.btnTongMu2.Click += new System.EventHandler(this.btnTongMu2_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(42, 283);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(274, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Kết Thúc";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTich
            // 
            this.btnTich.Location = new System.Drawing.Point(42, 245);
            this.btnTich.Name = "btnTich";
            this.btnTich.Size = new System.Drawing.Size(274, 23);
            this.btnTich.TabIndex = 8;
            this.btnTich.Text = "Tính (1+2+...+N)/(1^2+2^3+...+N^(N+1))";
            this.btnTich.UseVisualStyleBackColor = true;
            this.btnTich.Click += new System.EventHandler(this.btnTich_Click);
            // 
            // btnTongMuN
            // 
            this.btnTongMuN.Location = new System.Drawing.Point(42, 207);
            this.btnTongMuN.Name = "btnTongMuN";
            this.btnTongMuN.Size = new System.Drawing.Size(274, 23);
            this.btnTongMuN.TabIndex = 7;
            this.btnTongMuN.Text = "Tính 1^2+2^3+...+N^(N+1)";
            this.btnTongMuN.UseVisualStyleBackColor = true;
            this.btnTongMuN.Click += new System.EventHandler(this.btnTongMuN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 350);
            this.Controls.Add(this.btnTich);
            this.Controls.Add(this.btnTongMuN);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTongMu2);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnTongMu2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTich;
        private System.Windows.Forms.Button btnTongMuN;
    }
}

