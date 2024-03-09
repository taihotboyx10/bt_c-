namespace bt_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdSunny = new System.Windows.Forms.RadioButton();
            this.rdSnowy = new System.Windows.Forms.RadioButton();
            this.rdRainy = new System.Windows.Forms.RadioButton();
            this.rdCloudy = new System.Windows.Forms.RadioButton();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picCloudy = new System.Windows.Forms.PictureBox();
            this.picRainy = new System.Windows.Forms.PictureBox();
            this.picSnowy = new System.Windows.Forms.PictureBox();
            this.picSunny = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name here";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtName.Location = new System.Drawing.Point(193, 35);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 31);
            this.txtName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdSunny);
            this.groupBox1.Controls.Add(this.rdSnowy);
            this.groupBox1.Controls.Add(this.rdRainy);
            this.groupBox1.Controls.Add(this.rdCloudy);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(22, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // rdSunny
            // 
            this.rdSunny.AutoSize = true;
            this.rdSunny.ForeColor = System.Drawing.Color.Red;
            this.rdSunny.Location = new System.Drawing.Point(29, 139);
            this.rdSunny.Name = "rdSunny";
            this.rdSunny.Size = new System.Drawing.Size(68, 19);
            this.rdSunny.TabIndex = 6;
            this.rdSunny.TabStop = true;
            this.rdSunny.Text = "Sunny";
            this.rdSunny.UseVisualStyleBackColor = true;
            this.rdSunny.CheckedChanged += new System.EventHandler(this.rdSunny_CheckedChanged);
            // 
            // rdSnowy
            // 
            this.rdSnowy.AutoSize = true;
            this.rdSnowy.ForeColor = System.Drawing.Color.Blue;
            this.rdSnowy.Location = new System.Drawing.Point(29, 100);
            this.rdSnowy.Name = "rdSnowy";
            this.rdSnowy.Size = new System.Drawing.Size(70, 19);
            this.rdSnowy.TabIndex = 5;
            this.rdSnowy.TabStop = true;
            this.rdSnowy.Text = "Snowy";
            this.rdSnowy.UseVisualStyleBackColor = true;
            this.rdSnowy.CheckedChanged += new System.EventHandler(this.rdSnowy_CheckedChanged);
            // 
            // rdRainy
            // 
            this.rdRainy.AutoSize = true;
            this.rdRainy.ForeColor = System.Drawing.Color.Fuchsia;
            this.rdRainy.Location = new System.Drawing.Point(29, 62);
            this.rdRainy.Name = "rdRainy";
            this.rdRainy.Size = new System.Drawing.Size(62, 19);
            this.rdRainy.TabIndex = 4;
            this.rdRainy.TabStop = true;
            this.rdRainy.Text = "Rainy";
            this.rdRainy.UseVisualStyleBackColor = true;
            this.rdRainy.CheckedChanged += new System.EventHandler(this.rdRainy_CheckedChanged);
            // 
            // rdCloudy
            // 
            this.rdCloudy.AutoSize = true;
            this.rdCloudy.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.rdCloudy.Location = new System.Drawing.Point(29, 25);
            this.rdCloudy.Name = "rdCloudy";
            this.rdCloudy.Size = new System.Drawing.Size(71, 19);
            this.rdCloudy.TabIndex = 3;
            this.rdCloudy.TabStop = true;
            this.rdCloudy.Text = "Cloudy";
            this.rdCloudy.UseVisualStyleBackColor = true;
            this.rdCloudy.CheckedChanged += new System.EventHandler(this.rdCloudy_CheckedChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.Blue;
            this.lblDisplay.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDisplay.Location = new System.Drawing.Point(21, 305);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(225, 95);
            this.lblDisplay.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPrint.Location = new System.Drawing.Point(309, 312);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 39);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExit.Location = new System.Drawing.Point(309, 358);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picCloudy
            // 
            this.picCloudy.Image = ((System.Drawing.Image)(resources.GetObject("picCloudy.Image")));
            this.picCloudy.Location = new System.Drawing.Point(217, 115);
            this.picCloudy.Name = "picCloudy";
            this.picCloudy.Size = new System.Drawing.Size(73, 48);
            this.picCloudy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCloudy.TabIndex = 6;
            this.picCloudy.TabStop = false;
            // 
            // picRainy
            // 
            this.picRainy.Image = ((System.Drawing.Image)(resources.GetObject("picRainy.Image")));
            this.picRainy.Location = new System.Drawing.Point(340, 115);
            this.picRainy.Name = "picRainy";
            this.picRainy.Size = new System.Drawing.Size(76, 71);
            this.picRainy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRainy.TabIndex = 7;
            this.picRainy.TabStop = false;
            // 
            // picSnowy
            // 
            this.picSnowy.Image = ((System.Drawing.Image)(resources.GetObject("picSnowy.Image")));
            this.picSnowy.Location = new System.Drawing.Point(218, 204);
            this.picSnowy.Name = "picSnowy";
            this.picSnowy.Size = new System.Drawing.Size(54, 67);
            this.picSnowy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSnowy.TabIndex = 8;
            this.picSnowy.TabStop = false;
            // 
            // picSunny
            // 
            this.picSunny.Image = ((System.Drawing.Image)(resources.GetObject("picSunny.Image")));
            this.picSunny.Location = new System.Drawing.Point(340, 204);
            this.picSunny.Name = "picSunny";
            this.picSunny.Size = new System.Drawing.Size(67, 64);
            this.picSunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSunny.TabIndex = 9;
            this.picSunny.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 431);
            this.Controls.Add(this.picSunny);
            this.Controls.Add(this.picSnowy);
            this.Controls.Add(this.picRainy);
            this.Controls.Add(this.picCloudy);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdSunny;
        private System.Windows.Forms.RadioButton rdSnowy;
        private System.Windows.Forms.RadioButton rdRainy;
        private System.Windows.Forms.RadioButton rdCloudy;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picCloudy;
        private System.Windows.Forms.PictureBox picRainy;
        private System.Windows.Forms.PictureBox picSnowy;
        private System.Windows.Forms.PictureBox picSunny;
    }
}

