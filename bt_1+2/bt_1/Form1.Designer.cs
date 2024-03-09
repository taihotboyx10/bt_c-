namespace bt_1
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
            this.lblHoLot = new System.Windows.Forms.Label();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHoLot = new System.Windows.Forms.Button();
            this.btnHoVaTen = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoLot
            // 
            this.lblHoLot.BackColor = System.Drawing.Color.Aqua;
            this.lblHoLot.Location = new System.Drawing.Point(36, 68);
            this.lblHoLot.Name = "lblHoLot";
            this.lblHoLot.Size = new System.Drawing.Size(78, 29);
            this.lblHoLot.TabIndex = 0;
            this.lblHoLot.Text = "Họ lót";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.BackColor = System.Drawing.Color.Yellow;
            this.lblHoVaTen.Location = new System.Drawing.Point(36, 9);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(317, 39);
            this.lblHoVaTen.TabIndex = 1;
            this.lblHoVaTen.DoubleClick += new System.EventHandler(this.lblHoVaTen_DoubleClick);
            // 
            // lblTen
            // 
            this.lblTen.BackColor = System.Drawing.Color.Aqua;
            this.lblTen.Location = new System.Drawing.Point(36, 107);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(78, 29);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên";
            // 
            // txtHoLot
            // 
            this.txtHoLot.Location = new System.Drawing.Point(120, 68);
            this.txtHoLot.Multiline = true;
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(233, 29);
            this.txtHoLot.TabIndex = 3;
            this.txtHoLot.TextChanged += new System.EventHandler(this.txtHoLot_TextChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(120, 107);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(233, 29);
            this.txtTen.TabIndex = 4;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // btnHoLot
            // 
            this.btnHoLot.Location = new System.Drawing.Point(47, 166);
            this.btnHoLot.Name = "btnHoLot";
            this.btnHoLot.Size = new System.Drawing.Size(75, 32);
            this.btnHoLot.TabIndex = 5;
            this.btnHoLot.Text = "Họ Lót";
            this.btnHoLot.UseVisualStyleBackColor = true;
            this.btnHoLot.Click += new System.EventHandler(this.btnHoLot_Click);
            // 
            // btnHoVaTen
            // 
            this.btnHoVaTen.Location = new System.Drawing.Point(249, 166);
            this.btnHoVaTen.Name = "btnHoVaTen";
            this.btnHoVaTen.Size = new System.Drawing.Size(92, 32);
            this.btnHoVaTen.TabIndex = 6;
            this.btnHoVaTen.Text = "Họ Và Tên";
            this.btnHoVaTen.UseVisualStyleBackColor = true;
            this.btnHoVaTen.Click += new System.EventHandler(this.btnHoVaTen_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(129, 221);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(121, 32);
            this.btnKetThuc.TabIndex = 7;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(149, 166);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 32);
            this.btnTen.TabIndex = 8;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 297);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnHoVaTen);
            this.Controls.Add(this.btnHoLot);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoLot);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblHoVaTen);
            this.Controls.Add(this.lblHoLot);
            this.Name = "Form1";
            this.Text = "Họ Tên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoLot;
        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHoLot;
        private System.Windows.Forms.Button btnHoVaTen;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnTen;
    }
}

