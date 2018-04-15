namespace QuanLyBanVeXemPhim
{
    partial class Banve
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbGio = new System.Windows.Forms.ComboBox();
            this.lblPhongchieu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPhim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBohet = new System.Windows.Forms.Button();
            this.btnChonhet = new System.Windows.Forms.Button();
            this.btBo = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbChon = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbGhe = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLichchieuID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbGio);
            this.groupBox1.Controls.Add(this.lblPhongchieu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbPhim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch chiếu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbbGio
            // 
            this.cbbGio.FormattingEnabled = true;
            this.cbbGio.Location = new System.Drawing.Point(83, 76);
            this.cbbGio.Name = "cbbGio";
            this.cbbGio.Size = new System.Drawing.Size(143, 21);
            this.cbbGio.TabIndex = 6;
            this.cbbGio.SelectedIndexChanged += new System.EventHandler(this.cbbGio_SelectedIndexChanged);
            // 
            // lblPhongchieu
            // 
            this.lblPhongchieu.AutoSize = true;
            this.lblPhongchieu.Location = new System.Drawing.Point(80, 115);
            this.lblPhongchieu.Name = "lblPhongchieu";
            this.lblPhongchieu.Size = new System.Drawing.Size(0, 13);
            this.lblPhongchieu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phòng chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giờ chiếu";
            // 
            // cbbPhim
            // 
            this.cbbPhim.FormattingEnabled = true;
            this.cbbPhim.Location = new System.Drawing.Point(83, 33);
            this.cbbPhim.Name = "cbbPhim";
            this.cbbPhim.Size = new System.Drawing.Size(143, 21);
            this.cbbPhim.TabIndex = 1;
            this.cbbPhim.SelectedIndexChanged += new System.EventHandler(this.cbbPhim_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTien);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnBohet);
            this.groupBox2.Controls.Add(this.btnChonhet);
            this.groupBox2.Controls.Add(this.btBo);
            this.groupBox2.Controls.Add(this.btnChon);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbChon);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbGhe);
            this.groupBox2.Location = new System.Drawing.Point(28, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vị trí ghế";
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Location = new System.Drawing.Point(284, 132);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(0, 13);
            this.lblTien.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng tiền:";
            // 
            // btnBohet
            // 
            this.btnBohet.Location = new System.Drawing.Point(191, 88);
            this.btnBohet.Name = "btnBohet";
            this.btnBohet.Size = new System.Drawing.Size(35, 23);
            this.btnBohet.TabIndex = 7;
            this.btnBohet.Text = "<<";
            this.btnBohet.UseVisualStyleBackColor = true;
            this.btnBohet.Click += new System.EventHandler(this.btnBohet_Click);
            // 
            // btnChonhet
            // 
            this.btnChonhet.Location = new System.Drawing.Point(150, 88);
            this.btnChonhet.Name = "btnChonhet";
            this.btnChonhet.Size = new System.Drawing.Size(35, 23);
            this.btnChonhet.TabIndex = 6;
            this.btnChonhet.Text = ">>";
            this.btnChonhet.UseVisualStyleBackColor = true;
            this.btnChonhet.Click += new System.EventHandler(this.btnChonhet_Click);
            // 
            // btBo
            // 
            this.btBo.Location = new System.Drawing.Point(191, 59);
            this.btBo.Name = "btBo";
            this.btBo.Size = new System.Drawing.Size(35, 23);
            this.btBo.TabIndex = 5;
            this.btBo.Text = "<";
            this.btBo.UseVisualStyleBackColor = true;
            this.btBo.Click += new System.EventHandler(this.btBo_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(150, 59);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(35, 23);
            this.btnChon.TabIndex = 4;
            this.btnChon.Text = ">";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đã chọn";
            // 
            // lbChon
            // 
            this.lbChon.FormattingEnabled = true;
            this.lbChon.Location = new System.Drawing.Point(232, 47);
            this.lbChon.Name = "lbChon";
            this.lbChon.Size = new System.Drawing.Size(120, 82);
            this.lbChon.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Còn trống:";
            // 
            // lbGhe
            // 
            this.lbGhe.FormattingEnabled = true;
            this.lbGhe.Location = new System.Drawing.Point(24, 47);
            this.lbGhe.Name = "lbGhe";
            this.lbGhe.Size = new System.Drawing.Size(120, 82);
            this.lbGhe.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(118, 355);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(217, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLichchieuID
            // 
            this.lblLichchieuID.AutoSize = true;
            this.lblLichchieuID.Location = new System.Drawing.Point(432, 383);
            this.lblLichchieuID.Name = "lblLichchieuID";
            this.lblLichchieuID.Size = new System.Drawing.Size(35, 13);
            this.lblLichchieuID.TabIndex = 4;
            this.lblLichchieuID.Text = "label7";
            this.lblLichchieuID.Visible = false;
            // 
            // Banve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 405);
            this.Controls.Add(this.lblLichchieuID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Banve";
            this.Text = "Banve";
            this.Load += new System.EventHandler(this.Banve_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPhongchieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBohet;
        private System.Windows.Forms.Button btnChonhet;
        private System.Windows.Forms.Button btBo;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbChon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbGhe;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbbGio;
        private System.Windows.Forms.Label lblLichchieuID;
    }
}