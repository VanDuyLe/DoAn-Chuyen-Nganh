namespace _019101060.GUI
{
    partial class DangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbcv = new System.Windows.Forms.ComboBox();
            this.cbnv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvtaikhoan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(455, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(336, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng Ký";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbcv);
            this.groupBox1.Controls.Add(this.cbnv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Controls.Add(this.txttk);
            this.groupBox1.Location = new System.Drawing.Point(13, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 187);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // cbcv
            // 
            this.cbcv.FormattingEnabled = true;
            this.cbcv.Location = new System.Drawing.Point(747, 122);
            this.cbcv.Name = "cbcv";
            this.cbcv.Size = new System.Drawing.Size(274, 33);
            this.cbcv.TabIndex = 22;
            // 
            // cbnv
            // 
            this.cbnv.FormattingEnabled = true;
            this.cbnv.Location = new System.Drawing.Point(747, 40);
            this.cbnv.Name = "cbnv";
            this.cbnv.Size = new System.Drawing.Size(274, 33);
            this.cbnv.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(554, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Chức Vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(549, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tên Nhân Viên:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tài Khoản";
            // 
            // txtmk
            // 
            this.txtmk.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtmk.Location = new System.Drawing.Point(176, 122);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(276, 34);
            this.txtmk.TabIndex = 10;
            // 
            // txttk
            // 
            this.txttk.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txttk.Location = new System.Drawing.Point(176, 47);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(276, 34);
            this.txttk.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lvtaikhoan);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(13, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1079, 213);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lvtaikhoan
            // 
            this.lvtaikhoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvtaikhoan.FullRowSelect = true;
            this.lvtaikhoan.GridLines = true;
            this.lvtaikhoan.HideSelection = false;
            this.lvtaikhoan.Location = new System.Drawing.Point(16, 34);
            this.lvtaikhoan.Name = "lvtaikhoan";
            this.lvtaikhoan.Size = new System.Drawing.Size(1038, 161);
            this.lvtaikhoan.TabIndex = 0;
            this.lvtaikhoan.UseCompatibleStateImageBehavior = false;
            this.lvtaikhoan.View = System.Windows.Forms.View.Details;
            this.lvtaikhoan.Click += new System.EventHandler(this.lvtaikhoan_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tài Khoản";
            this.columnHeader1.Width = 284;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mật Khẩu";
            this.columnHeader2.Width = 244;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Nhân Viên";
            this.columnHeader3.Width = 262;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Chức Vụ";
            this.columnHeader4.Width = 244;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Location = new System.Drawing.Point(522, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cập Nhật";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.Location = new System.Drawing.Point(690, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 58);
            this.button3.TabIndex = 7;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 584);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký";
            this.Load += new System.EventHandler(this.Frm_DangKy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbnv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvtaikhoan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbcv;
    }
}