namespace bt_18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdOk = new System.Windows.Forms.RadioButton();
            this.rdOkCancel = new System.Windows.Forms.RadioButton();
            this.rdARI = new System.Windows.Forms.RadioButton();
            this.rdYNC = new System.Windows.Forms.RadioButton();
            this.rdYesNo = new System.Windows.Forms.RadioButton();
            this.rdRetryCancel = new System.Windows.Forms.RadioButton();
            this.rdInfor = new System.Windows.Forms.RadioButton();
            this.rdExc = new System.Windows.Forms.RadioButton();
            this.rdQuestion = new System.Windows.Forms.RadioButton();
            this.rdStop = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdRetryCancel);
            this.groupBox1.Controls.Add(this.rdYesNo);
            this.groupBox1.Controls.Add(this.rdYNC);
            this.groupBox1.Controls.Add(this.rdARI);
            this.groupBox1.Controls.Add(this.rdOkCancel);
            this.groupBox1.Controls.Add(this.rdOk);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Style Buttons";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.rdInfor);
            this.groupBox2.Controls.Add(this.rdExc);
            this.groupBox2.Controls.Add(this.rdQuestion);
            this.groupBox2.Controls.Add(this.rdStop);
            this.groupBox2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(247, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Style Icon";
            // 
            // rdOk
            // 
            this.rdOk.AutoSize = true;
            this.rdOk.Location = new System.Drawing.Point(19, 35);
            this.rdOk.Name = "rdOk";
            this.rdOk.Size = new System.Drawing.Size(48, 19);
            this.rdOk.TabIndex = 0;
            this.rdOk.TabStop = true;
            this.rdOk.Text = "Ok";
            this.rdOk.UseVisualStyleBackColor = true;
            // 
            // rdOkCancel
            // 
            this.rdOkCancel.AutoSize = true;
            this.rdOkCancel.Location = new System.Drawing.Point(19, 75);
            this.rdOkCancel.Name = "rdOkCancel";
            this.rdOkCancel.Size = new System.Drawing.Size(104, 19);
            this.rdOkCancel.TabIndex = 1;
            this.rdOkCancel.TabStop = true;
            this.rdOkCancel.Text = "Ok Cancel";
            this.rdOkCancel.UseVisualStyleBackColor = true;
            // 
            // rdARI
            // 
            this.rdARI.AutoSize = true;
            this.rdARI.Location = new System.Drawing.Point(19, 115);
            this.rdARI.Name = "rdARI";
            this.rdARI.Size = new System.Drawing.Size(164, 19);
            this.rdARI.TabIndex = 2;
            this.rdARI.TabStop = true;
            this.rdARI.Text = "Abort Retry Ignore";
            this.rdARI.UseVisualStyleBackColor = true;
            // 
            // rdYNC
            // 
            this.rdYNC.AutoSize = true;
            this.rdYNC.Location = new System.Drawing.Point(19, 155);
            this.rdYNC.Name = "rdYNC";
            this.rdYNC.Size = new System.Drawing.Size(137, 19);
            this.rdYNC.TabIndex = 3;
            this.rdYNC.TabStop = true;
            this.rdYNC.Text = "Yes No Cancel";
            this.rdYNC.UseVisualStyleBackColor = true;
            // 
            // rdYesNo
            // 
            this.rdYesNo.AutoSize = true;
            this.rdYesNo.Location = new System.Drawing.Point(19, 195);
            this.rdYesNo.Name = "rdYesNo";
            this.rdYesNo.Size = new System.Drawing.Size(81, 19);
            this.rdYesNo.TabIndex = 4;
            this.rdYesNo.TabStop = true;
            this.rdYesNo.Text = "Yes No";
            this.rdYesNo.UseVisualStyleBackColor = true;
            // 
            // rdRetryCancel
            // 
            this.rdRetryCancel.AutoSize = true;
            this.rdRetryCancel.Location = new System.Drawing.Point(19, 235);
            this.rdRetryCancel.Name = "rdRetryCancel";
            this.rdRetryCancel.Size = new System.Drawing.Size(123, 19);
            this.rdRetryCancel.TabIndex = 5;
            this.rdRetryCancel.TabStop = true;
            this.rdRetryCancel.Text = "Retry Cancel";
            this.rdRetryCancel.UseVisualStyleBackColor = true;
            // 
            // rdInfor
            // 
            this.rdInfor.AutoSize = true;
            this.rdInfor.Location = new System.Drawing.Point(27, 233);
            this.rdInfor.Name = "rdInfor";
            this.rdInfor.Size = new System.Drawing.Size(111, 19);
            this.rdInfor.TabIndex = 7;
            this.rdInfor.TabStop = true;
            this.rdInfor.Text = "Information";
            this.rdInfor.UseVisualStyleBackColor = true;
            // 
            // rdExc
            // 
            this.rdExc.AutoSize = true;
            this.rdExc.Location = new System.Drawing.Point(27, 167);
            this.rdExc.Name = "rdExc";
            this.rdExc.Size = new System.Drawing.Size(114, 19);
            this.rdExc.TabIndex = 6;
            this.rdExc.TabStop = true;
            this.rdExc.Text = "Exclamation";
            this.rdExc.UseVisualStyleBackColor = true;
            // 
            // rdQuestion
            // 
            this.rdQuestion.AutoSize = true;
            this.rdQuestion.Location = new System.Drawing.Point(27, 101);
            this.rdQuestion.Name = "rdQuestion";
            this.rdQuestion.Size = new System.Drawing.Size(94, 19);
            this.rdQuestion.TabIndex = 5;
            this.rdQuestion.TabStop = true;
            this.rdQuestion.Text = "Question";
            this.rdQuestion.UseVisualStyleBackColor = true;
            // 
            // rdStop
            // 
            this.rdStop.AutoSize = true;
            this.rdStop.Location = new System.Drawing.Point(27, 35);
            this.rdStop.Name = "rdStop";
            this.rdStop.Size = new System.Drawing.Size(61, 19);
            this.rdStop.TabIndex = 4;
            this.rdStop.TabStop = true;
            this.rdStop.Text = "Stop";
            this.rdStop.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSelect.Location = new System.Drawing.Point(109, 316);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(103, 36);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(247, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 36);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Thoát";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(157, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(157, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(157, 167);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(157, 235);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 375);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdRetryCancel;
        private System.Windows.Forms.RadioButton rdYesNo;
        private System.Windows.Forms.RadioButton rdYNC;
        private System.Windows.Forms.RadioButton rdARI;
        private System.Windows.Forms.RadioButton rdOkCancel;
        private System.Windows.Forms.RadioButton rdOk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdInfor;
        private System.Windows.Forms.RadioButton rdExc;
        private System.Windows.Forms.RadioButton rdQuestion;
        private System.Windows.Forms.RadioButton rdStop;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

