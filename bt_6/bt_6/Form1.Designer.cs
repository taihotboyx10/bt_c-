namespace bt_6
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
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnMu12 = new System.Windows.Forms.Button();
            this.bntMu3 = new System.Windows.Forms.Button();
            this.btnMu2 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(84, 39);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(242, 33);
            this.txtKQ.TabIndex = 0;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(177, 89);
            this.txtX.Multiline = true;
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(149, 33);
            this.txtX.TabIndex = 1;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(177, 146);
            this.txtY.Multiline = true;
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(149, 33);
            this.txtY.TabIndex = 2;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(81, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(81, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(38, 216);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 32);
            this.btnCong.TabIndex = 5;
            this.btnCong.Text = "X+Y";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(148, 216);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(75, 32);
            this.btnTru.TabIndex = 6;
            this.btnTru.Text = "X-Y";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(251, 216);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 32);
            this.btnNhan.TabIndex = 7;
            this.btnNhan.Text = "X*Y";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnMu12
            // 
            this.btnMu12.Location = new System.Drawing.Point(251, 257);
            this.btnMu12.Name = "btnMu12";
            this.btnMu12.Size = new System.Drawing.Size(75, 32);
            this.btnMu12.TabIndex = 8;
            this.btnMu12.Text = "X^1/2";
            this.btnMu12.UseVisualStyleBackColor = true;
            this.btnMu12.Click += new System.EventHandler(this.btnMu12_Click);
            // 
            // bntMu3
            // 
            this.bntMu3.Location = new System.Drawing.Point(148, 257);
            this.bntMu3.Name = "bntMu3";
            this.bntMu3.Size = new System.Drawing.Size(75, 32);
            this.bntMu3.TabIndex = 9;
            this.bntMu3.Text = "X^3";
            this.bntMu3.UseVisualStyleBackColor = true;
            this.bntMu3.Click += new System.EventHandler(this.bntMu3_Click);
            // 
            // btnMu2
            // 
            this.btnMu2.Location = new System.Drawing.Point(38, 257);
            this.btnMu2.Name = "btnMu2";
            this.btnMu2.Size = new System.Drawing.Size(75, 32);
            this.btnMu2.TabIndex = 10;
            this.btnMu2.Text = "X^2";
            this.btnMu2.UseVisualStyleBackColor = true;
            this.btnMu2.Click += new System.EventHandler(this.btnMu2_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(148, 298);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 32);
            this.BtnBack.TabIndex = 11;
            this.BtnBack.Text = "Exit";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 375);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.btnMu2);
            this.Controls.Add(this.bntMu3);
            this.Controls.Add(this.btnMu12);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtKQ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnMu12;
        private System.Windows.Forms.Button bntMu3;
        private System.Windows.Forms.Button btnMu2;
        private System.Windows.Forms.Button BtnBack;
    }
}

