namespace QLSV
{
    partial class AddStudent
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
            this.lbText = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbHovaTen = new System.Windows.Forms.Label();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbNgaSinh = new System.Windows.Forms.Label();
            this.lbTuoi = new System.Windows.Forms.Label();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbLop = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbdiemToan = new System.Windows.Forms.Label();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.diemvanlb = new System.Windows.Forms.Label();
            this.txtDiemvan = new System.Windows.Forms.TextBox();
            this.lbDiemHoa = new System.Windows.Forms.Label();
            this.txtHoa = new System.Windows.Forms.TextBox();
            this.lbDIEMTRUNGBINH = new System.Windows.Forms.Label();
            this.txtTrungBinh = new System.Windows.Forms.TextBox();
            this.btSAVE = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btTroVe = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.ForeColor = System.Drawing.Color.Crimson;
            this.lbText.Location = new System.Drawing.Point(25, 13);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(103, 13);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "NHẬP THÔNG TIN ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(19, 44);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(89, 13);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "Mã Số Sinh Viên ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(114, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // lbHovaTen
            // 
            this.lbHovaTen.AutoSize = true;
            this.lbHovaTen.Location = new System.Drawing.Point(24, 75);
            this.lbHovaTen.Name = "lbHovaTen";
            this.lbHovaTen.Size = new System.Drawing.Size(65, 13);
            this.lbHovaTen.TabIndex = 3;
            this.lbHovaTen.Text = "Họ Và Tên :";
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(114, 75);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(100, 20);
            this.txtHovaTen.TabIndex = 4;
            this.txtHovaTen.TextChanged += new System.EventHandler(this.txtHovaTen_TextChanged);
            this.txtHovaTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHovaTen_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbNgaSinh
            // 
            this.lbNgaSinh.AutoSize = true;
            this.lbNgaSinh.Location = new System.Drawing.Point(19, 116);
            this.lbNgaSinh.Name = "lbNgaSinh";
            this.lbNgaSinh.Size = new System.Drawing.Size(59, 13);
            this.lbNgaSinh.TabIndex = 6;
            this.lbNgaSinh.Text = "Ngày Sinh ";
            // 
            // lbTuoi
            // 
            this.lbTuoi.AutoSize = true;
            this.lbTuoi.Location = new System.Drawing.Point(25, 148);
            this.lbTuoi.Name = "lbTuoi";
            this.lbTuoi.Size = new System.Drawing.Size(31, 13);
            this.lbTuoi.TabIndex = 7;
            this.lbTuoi.Text = "Tuổi ";
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(114, 148);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(100, 20);
            this.txtTuoi.TabIndex = 8;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(24, 178);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(54, 13);
            this.lbGioiTinh.TabIndex = 9;
            this.lbGioiTinh.Text = "Giới Tính ";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(114, 178);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(100, 20);
            this.txtGioiTinh.TabIndex = 10;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(25, 216);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(44, 13);
            this.lbDiaChi.TabIndex = 11;
            this.lbDiaChi.Text = "Địa Chỉ ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(116, 217);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 12;
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Location = new System.Drawing.Point(33, 258);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(34, 13);
            this.lbLop.TabIndex = 13;
            this.lbLop.Text = "Lớp : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // lbdiemToan
            // 
            this.lbdiemToan.AutoSize = true;
            this.lbdiemToan.Location = new System.Drawing.Point(16, 291);
            this.lbdiemToan.Name = "lbdiemToan";
            this.lbdiemToan.Size = new System.Drawing.Size(62, 13);
            this.lbdiemToan.TabIndex = 15;
            this.lbdiemToan.Text = "Điểm Toán ";
            // 
            // txtToan
            // 
            this.txtToan.Location = new System.Drawing.Point(114, 284);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(100, 20);
            this.txtToan.TabIndex = 16;
            this.txtToan.TextChanged += new System.EventHandler(this.txtToan_TextChanged);
            // 
            // diemvanlb
            // 
            this.diemvanlb.AutoSize = true;
            this.diemvanlb.Location = new System.Drawing.Point(16, 317);
            this.diemvanlb.Name = "diemvanlb";
            this.diemvanlb.Size = new System.Drawing.Size(62, 13);
            this.diemvanlb.TabIndex = 17;
            this.diemvanlb.Text = "Điểm Văn : ";
            // 
            // txtDiemvan
            // 
            this.txtDiemvan.Location = new System.Drawing.Point(113, 314);
            this.txtDiemvan.Name = "txtDiemvan";
            this.txtDiemvan.Size = new System.Drawing.Size(100, 20);
            this.txtDiemvan.TabIndex = 18;
            this.txtDiemvan.TextChanged += new System.EventHandler(this.txtDiemvan_TextChanged);
            // 
            // lbDiemHoa
            // 
            this.lbDiemHoa.AutoSize = true;
            this.lbDiemHoa.Location = new System.Drawing.Point(16, 347);
            this.lbDiemHoa.Name = "lbDiemHoa";
            this.lbDiemHoa.Size = new System.Drawing.Size(57, 13);
            this.lbDiemHoa.TabIndex = 19;
            this.lbDiemHoa.Text = "Điểm Hóa ";
            // 
            // txtHoa
            // 
            this.txtHoa.Location = new System.Drawing.Point(116, 347);
            this.txtHoa.Name = "txtHoa";
            this.txtHoa.Size = new System.Drawing.Size(100, 20);
            this.txtHoa.TabIndex = 20;
            this.txtHoa.TextChanged += new System.EventHandler(this.txtHoa_TextChanged);
            // 
            // lbDIEMTRUNGBINH
            // 
            this.lbDIEMTRUNGBINH.AutoSize = true;
            this.lbDIEMTRUNGBINH.Location = new System.Drawing.Point(3, 378);
            this.lbDIEMTRUNGBINH.Name = "lbDIEMTRUNGBINH";
            this.lbDIEMTRUNGBINH.Size = new System.Drawing.Size(95, 13);
            this.lbDIEMTRUNGBINH.TabIndex = 21;
            this.lbDIEMTRUNGBINH.Text = "Điểm Trung Bình : ";
            // 
            // txtTrungBinh
            // 
            this.txtTrungBinh.Location = new System.Drawing.Point(113, 382);
            this.txtTrungBinh.Name = "txtTrungBinh";
            this.txtTrungBinh.Size = new System.Drawing.Size(100, 20);
            this.txtTrungBinh.TabIndex = 22;
            // 
            // btSAVE
            // 
            this.btSAVE.Location = new System.Drawing.Point(6, 415);
            this.btSAVE.Name = "btSAVE";
            this.btSAVE.Size = new System.Drawing.Size(75, 23);
            this.btSAVE.TabIndex = 23;
            this.btSAVE.Text = "Lưu ";
            this.btSAVE.UseVisualStyleBackColor = true;
            this.btSAVE.Click += new System.EventHandler(this.btSAVE_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(481, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(238, 449);
            this.dataGridView1.TabIndex = 24;
            // 
            // btTroVe
            // 
            this.btTroVe.Location = new System.Drawing.Point(387, 415);
            this.btTroVe.Name = "btTroVe";
            this.btTroVe.Size = new System.Drawing.Size(75, 23);
            this.btTroVe.TabIndex = 25;
            this.btTroVe.Text = "Trở Về ";
            this.btTroVe.UseVisualStyleBackColor = true;
            this.btTroVe.Click += new System.EventHandler(this.btTroVe_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(306, 415);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 26;
            this.btXoa.Text = "Xóa ";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(212, 415);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 27;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(102, 415);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btCapNhat.TabIndex = 28;
            this.btCapNhat.Text = "Cập Nhật ";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTroVe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSAVE);
            this.Controls.Add(this.txtTrungBinh);
            this.Controls.Add(this.lbDIEMTRUNGBINH);
            this.Controls.Add(this.txtHoa);
            this.Controls.Add(this.lbDiemHoa);
            this.Controls.Add(this.txtDiemvan);
            this.Controls.Add(this.diemvanlb);
            this.Controls.Add(this.txtToan);
            this.Controls.Add(this.lbdiemToan);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbLop);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.lbTuoi);
            this.Controls.Add(this.lbNgaSinh);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtHovaTen);
            this.Controls.Add(this.lbHovaTen);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbText);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbHovaTen;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbNgaSinh;
        private System.Windows.Forms.Label lbTuoi;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbdiemToan;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.Label diemvanlb;
        private System.Windows.Forms.TextBox txtDiemvan;
        private System.Windows.Forms.Label lbDiemHoa;
        private System.Windows.Forms.TextBox txtHoa;
        private System.Windows.Forms.Label lbDIEMTRUNGBINH;
        private System.Windows.Forms.TextBox txtTrungBinh;
        private System.Windows.Forms.Button btSAVE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btTroVe;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btCapNhat;
    }
}