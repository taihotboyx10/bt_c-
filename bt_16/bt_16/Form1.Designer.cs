namespace bt_16
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
            this.txtDuongLich = new System.Windows.Forms.TextBox();
            this.txtAmLich = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nam Duong Lich";
            // 
            // txtDuongLich
            // 
            this.txtDuongLich.Location = new System.Drawing.Point(185, 25);
            this.txtDuongLich.Name = "txtDuongLich";
            this.txtDuongLich.Size = new System.Drawing.Size(100, 22);
            this.txtDuongLich.TabIndex = 1;
            this.txtDuongLich.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuongLich_KeyPress);
            // 
            // txtAmLich
            // 
            this.txtAmLich.Location = new System.Drawing.Point(185, 108);
            this.txtAmLich.Name = "txtAmLich";
            this.txtAmLich.Size = new System.Drawing.Size(100, 22);
            this.txtAmLich.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nam Am Lich";
            // 
            // btnDoi
            // 
            this.btnDoi.Location = new System.Drawing.Point(51, 64);
            this.btnDoi.Name = "btnDoi";
            this.btnDoi.Size = new System.Drawing.Size(234, 23);
            this.btnDoi.TabIndex = 4;
            this.btnDoi.Text = "Thuc Hien Doi";
            this.btnDoi.UseVisualStyleBackColor = true;
            this.btnDoi.Click += new System.EventHandler(this.btnDoi_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 194);
            this.Controls.Add(this.btnDoi);
            this.Controls.Add(this.txtAmLich);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDuongLich);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuongLich;
        private System.Windows.Forms.TextBox txtAmLich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDoi;
    }
}

