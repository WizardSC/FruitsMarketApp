namespace GUI
{
    partial class KhachHangGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHangGUI));
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMG = new System.Windows.Forms.DataGridViewImageColumn();
            this.DiemTichLuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnThongTinNV = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbGioiTinhNu = new CustomControls.RJControls.RJRadioButton();
            this.rdbGioiTinhNam = new CustomControls.RJControls.RJRadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbKHoatDong = new CustomControls.RJControls.RJRadioButton();
            this.rdbHoatDong = new CustomControls.RJControls.RJRadioButton();
            this.btnSua = new GUI.MyCustom.RJButton();
            this.btnXoa = new GUI.MyCustom.RJButton();
            this.btnReset = new GUI.MyCustom.RJButton();
            this.btnThem = new GUI.MyCustom.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoDT = new CustomControls.RJControls.RJTextBox();
            this.txtDiaChi = new CustomControls.RJControls.RJTextBox();
            this.dtpNgaySinh = new CustomControls.RJControls.RJDatePicker();
            this.txtTen = new CustomControls.RJControls.RJTextBox();
            this.txtHo = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new CustomControls.RJControls.RJTextBox();
            this.btnUploadAnh = new GUI.MyCustom.RJButton();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkDiemTichLuy = new GUI.MyCustom.BiggerCheckBox();
            this.btnFilter = new GUI.MyCustom.RJButton();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFrom = new CustomControls.RJControls.RJTextBox();
            this.txtTo = new CustomControls.RJControls.RJTextBox();
            this.txtTimKiem = new CustomControls.RJControls.RJTextBox();
            this.cbxTimKiem = new CustomControls.RJControls.RJComboBox();
            this.pnFilter = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new GUI.MyCustom.GradientPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnNVLabel = new GUI.MyCustom.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton1 = new GUI.MyCustom.RJButton();
            this.label13 = new System.Windows.Forms.Label();
            this.biggerCheckBox1 = new GUI.MyCustom.BiggerCheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.pnThongTinNV.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnFilter.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.pnNVLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AllowUserToResizeColumns = false;
            this.dgvKhachHang.AllowUserToResizeRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKhachHang.ColumnHeadersHeight = 45;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.Ho,
            this.Ten,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.SoDT,
            this.IMG,
            this.DiemTichLuy,
            this.TrangThai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKhachHang.Location = new System.Drawing.Point(-1, 77);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvKhachHang.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvKhachHang.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvKhachHang.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.dgvKhachHang.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvKhachHang.RowTemplate.Height = 26;
            this.dgvKhachHang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(846, 626);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.TabStop = false;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            this.dgvKhachHang.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvKhachHang_DataBindingComplete);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // Ho
            // 
            this.Ho.DataPropertyName = "Ho";
            this.Ho.HeaderText = "Họ";
            this.Ho.MinimumWidth = 6;
            this.Ho.Name = "Ho";
            this.Ho.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số ĐT";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            // 
            // IMG
            // 
            this.IMG.DataPropertyName = "IMG";
            this.IMG.HeaderText = "IMG";
            this.IMG.MinimumWidth = 6;
            this.IMG.Name = "IMG";
            this.IMG.ReadOnly = true;
            this.IMG.Visible = false;
            // 
            // DiemTichLuy
            // 
            this.DiemTichLuy.DataPropertyName = "DiemTichLuy";
            this.DiemTichLuy.HeaderText = "Điểm tích lũy";
            this.DiemTichLuy.MinimumWidth = 6;
            this.DiemTichLuy.Name = "DiemTichLuy";
            this.DiemTichLuy.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // pnThongTinNV
            // 
            this.pnThongTinNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnThongTinNV.Controls.Add(this.panel2);
            this.pnThongTinNV.Controls.Add(this.label11);
            this.pnThongTinNV.Controls.Add(this.panel3);
            this.pnThongTinNV.Controls.Add(this.btnSua);
            this.pnThongTinNV.Controls.Add(this.btnXoa);
            this.pnThongTinNV.Controls.Add(this.btnReset);
            this.pnThongTinNV.Controls.Add(this.btnThem);
            this.pnThongTinNV.Controls.Add(this.label4);
            this.pnThongTinNV.Controls.Add(this.label3);
            this.pnThongTinNV.Controls.Add(this.label5);
            this.pnThongTinNV.Controls.Add(this.label6);
            this.pnThongTinNV.Controls.Add(this.label10);
            this.pnThongTinNV.Controls.Add(this.label7);
            this.pnThongTinNV.Controls.Add(this.txtSoDT);
            this.pnThongTinNV.Controls.Add(this.txtDiaChi);
            this.pnThongTinNV.Controls.Add(this.dtpNgaySinh);
            this.pnThongTinNV.Controls.Add(this.txtTen);
            this.pnThongTinNV.Controls.Add(this.txtHo);
            this.pnThongTinNV.Controls.Add(this.label2);
            this.pnThongTinNV.Controls.Add(this.txtMaKH);
            this.pnThongTinNV.Controls.Add(this.btnUploadAnh);
            this.pnThongTinNV.Controls.Add(this.pbImage);
            this.pnThongTinNV.Location = new System.Drawing.Point(4, 7);
            this.pnThongTinNV.Name = "pnThongTinNV";
            this.pnThongTinNV.Size = new System.Drawing.Size(282, 704);
            this.pnThongTinNV.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbGioiTinhNu);
            this.panel2.Controls.Add(this.rdbGioiTinhNam);
            this.panel2.Location = new System.Drawing.Point(77, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 39);
            this.panel2.TabIndex = 30;
            // 
            // rdbGioiTinhNu
            // 
            this.rdbGioiTinhNu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.rdbGioiTinhNu.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rdbGioiTinhNu.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGioiTinhNu.Location = new System.Drawing.Point(103, 5);
            this.rdbGioiTinhNu.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbGioiTinhNu.Name = "rdbGioiTinhNu";
            this.rdbGioiTinhNu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbGioiTinhNu.Size = new System.Drawing.Size(67, 30);
            this.rdbGioiTinhNu.TabIndex = 29;
            this.rdbGioiTinhNu.TabStop = true;
            this.rdbGioiTinhNu.Text = "Nữ";
            this.rdbGioiTinhNu.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbGioiTinhNu.UseVisualStyleBackColor = false;
            // 
            // rdbGioiTinhNam
            // 
            this.rdbGioiTinhNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.rdbGioiTinhNam.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rdbGioiTinhNam.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGioiTinhNam.Location = new System.Drawing.Point(30, 5);
            this.rdbGioiTinhNam.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbGioiTinhNam.Name = "rdbGioiTinhNam";
            this.rdbGioiTinhNam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbGioiTinhNam.Size = new System.Drawing.Size(67, 30);
            this.rdbGioiTinhNam.TabIndex = 28;
            this.rdbGioiTinhNam.TabStop = true;
            this.rdbGioiTinhNam.Text = "Nam";
            this.rdbGioiTinhNam.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbGioiTinhNam.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(104, 566);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 71;
            this.label11.Text = "Trạng thái";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdbKHoatDong);
            this.panel3.Controls.Add(this.rdbHoatDong);
            this.panel3.Location = new System.Drawing.Point(14, 586);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 30);
            this.panel3.TabIndex = 4;
            // 
            // rdbKHoatDong
            // 
            this.rdbKHoatDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.rdbKHoatDong.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rdbKHoatDong.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKHoatDong.Location = new System.Drawing.Point(130, 0);
            this.rdbKHoatDong.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbKHoatDong.Name = "rdbKHoatDong";
            this.rdbKHoatDong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbKHoatDong.Size = new System.Drawing.Size(125, 30);
            this.rdbKHoatDong.TabIndex = 60;
            this.rdbKHoatDong.TabStop = true;
            this.rdbKHoatDong.Text = "Không hoạt động";
            this.rdbKHoatDong.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbKHoatDong.UseVisualStyleBackColor = false;
            // 
            // rdbHoatDong
            // 
            this.rdbHoatDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.rdbHoatDong.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rdbHoatDong.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHoatDong.Location = new System.Drawing.Point(14, 0);
            this.rdbHoatDong.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbHoatDong.Name = "rdbHoatDong";
            this.rdbHoatDong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbHoatDong.Size = new System.Drawing.Size(111, 30);
            this.rdbHoatDong.TabIndex = 59;
            this.rdbHoatDong.TabStop = true;
            this.rdbHoatDong.Text = "Hoạt động";
            this.rdbHoatDong.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbHoatDong.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.btnSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.btnSua.BorderColor = System.Drawing.Color.Black;
            this.btnSua.BorderRadius = 20;
            this.btnSua.BorderSize = 2;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Enabled = false;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(138)))), ((int)(((byte)(74)))));
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = global::GUI.Properties.Resources.icons8_pencil_23;
            this.btnSua.Location = new System.Drawing.Point(85, 622);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(40, 40);
            this.btnSua.TabIndex = 70;
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.btnXoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderSize = 2;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Enabled = false;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(138)))), ((int)(((byte)(74)))));
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::GUI.Properties.Resources.icons8_garbage_23;
            this.btnXoa.Location = new System.Drawing.Point(156, 622);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(40, 40);
            this.btnXoa.TabIndex = 69;
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.btnReset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.btnReset.BorderColor = System.Drawing.Color.Black;
            this.btnReset.BorderRadius = 20;
            this.btnReset.BorderSize = 2;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(138)))), ((int)(((byte)(74)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::GUI.Properties.Resources.icons8_reset_23;
            this.btnReset.Location = new System.Drawing.Point(227, 622);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(40, 40);
            this.btnReset.TabIndex = 68;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.btnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.BorderRadius = 20;
            this.btnThem.BorderSize = 2;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(138)))), ((int)(((byte)(74)))));
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::GUI.Properties.Resources.icons8_add_32;
            this.btnThem.Location = new System.Drawing.Point(14, 622);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(40, 40);
            this.btnThem.TabIndex = 67;
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 62;
            this.label4.Text = "Tên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "Họ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 65;
            this.label6.Text = "Địa chỉ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 64;
            this.label10.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 63;
            this.label7.Text = "Số ĐT";
            // 
            // txtSoDT
            // 
            this.txtSoDT.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoDT.BorderColor = System.Drawing.Color.Black;
            this.txtSoDT.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.txtSoDT.BorderRadius = 0;
            this.txtSoDT.BorderSize = 1;
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoDT.Location = new System.Drawing.Point(82, 524);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDT.Multiline = false;
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSoDT.PasswordChar = false;
            this.txtSoDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoDT.PlaceholderText = "";
            this.txtSoDT.Size = new System.Drawing.Size(187, 31);
            this.txtSoDT.TabIndex = 58;
            this.txtSoDT.Texts = "";
            this.txtSoDT.UnderlinedStyle = false;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.BorderColor = System.Drawing.Color.Black;
            this.txtDiaChi.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.txtDiaChi.BorderRadius = 0;
            this.txtDiaChi.BorderSize = 1;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiaChi.Location = new System.Drawing.Point(82, 468);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(187, 31);
            this.txtDiaChi.TabIndex = 56;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = false;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderColor = System.Drawing.Color.Black;
            this.dtpNgaySinh.BorderSize = 1;
            this.dtpNgaySinh.CalendarFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpNgaySinh.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(82, 381);
            this.dtpNgaySinh.MinimumSize = new System.Drawing.Size(4, 31);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(187, 31);
            this.dtpNgaySinh.SkinColor = System.Drawing.Color.Transparent;
            this.dtpNgaySinh.TabIndex = 55;
            this.dtpNgaySinh.TextColor = System.Drawing.Color.Black;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtTen.BorderColor = System.Drawing.Color.Black;
            this.txtTen.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.txtTen.BorderRadius = 0;
            this.txtTen.BorderSize = 1;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTen.Location = new System.Drawing.Point(82, 332);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Multiline = false;
            this.txtTen.Name = "txtTen";
            this.txtTen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTen.PasswordChar = false;
            this.txtTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTen.PlaceholderText = "";
            this.txtTen.Size = new System.Drawing.Size(187, 31);
            this.txtTen.TabIndex = 54;
            this.txtTen.Texts = "";
            this.txtTen.UnderlinedStyle = false;
            // 
            // txtHo
            // 
            this.txtHo.BackColor = System.Drawing.SystemColors.Window;
            this.txtHo.BorderColor = System.Drawing.Color.Black;
            this.txtHo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.txtHo.BorderRadius = 0;
            this.txtHo.BorderSize = 1;
            this.txtHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHo.Location = new System.Drawing.Point(82, 276);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHo.Multiline = false;
            this.txtHo.Name = "txtHo";
            this.txtHo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHo.PasswordChar = false;
            this.txtHo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHo.PlaceholderText = "";
            this.txtHo.Size = new System.Drawing.Size(187, 31);
            this.txtHo.TabIndex = 53;
            this.txtHo.Texts = "";
            this.txtHo.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã KH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.White;
            this.txtMaKH.BorderColor = System.Drawing.Color.Black;
            this.txtMaKH.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.txtMaKH.BorderRadius = 0;
            this.txtMaKH.BorderSize = 1;
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaKH.Location = new System.Drawing.Point(82, 220);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Multiline = false;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaKH.PasswordChar = false;
            this.txtMaKH.PlaceholderColor = System.Drawing.Color.Transparent;
            this.txtMaKH.PlaceholderText = "";
            this.txtMaKH.Size = new System.Drawing.Size(187, 31);
            this.txtMaKH.TabIndex = 51;
            this.txtMaKH.Texts = "";
            this.txtMaKH.UnderlinedStyle = false;
            // 
            // btnUploadAnh
            // 
            this.btnUploadAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.btnUploadAnh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.btnUploadAnh.BorderColor = System.Drawing.Color.Transparent;
            this.btnUploadAnh.BorderRadius = 20;
            this.btnUploadAnh.BorderSize = 0;
            this.btnUploadAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadAnh.FlatAppearance.BorderSize = 0;
            this.btnUploadAnh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(138)))), ((int)(((byte)(74)))));
            this.btnUploadAnh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.btnUploadAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadAnh.ForeColor = System.Drawing.Color.White;
            this.btnUploadAnh.Image = global::GUI.Properties.Resources.icons8_upload_26;
            this.btnUploadAnh.Location = new System.Drawing.Point(225, 111);
            this.btnUploadAnh.Name = "btnUploadAnh";
            this.btnUploadAnh.Size = new System.Drawing.Size(40, 40);
            this.btnUploadAnh.TabIndex = 50;
            this.btnUploadAnh.TextColor = System.Drawing.Color.White;
            this.btnUploadAnh.UseVisualStyleBackColor = false;
            this.btnUploadAnh.Click += new System.EventHandler(this.btnUploadAnh_Click);
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(60, 56);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(160, 150);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dgvKhachHang);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.pnSearch);
            this.panel1.Controls.Add(this.pnFilter);
            this.panel1.Location = new System.Drawing.Point(292, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 704);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.rjTextBox1);
            this.panel4.Controls.Add(this.rjTextBox2);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.biggerCheckBox1);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtTo);
            this.panel4.Controls.Add(this.txtFrom);
            this.panel4.Controls.Add(this.chkDiemTichLuy);
            this.panel4.Location = new System.Drawing.Point(619, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 171);
            this.panel4.TabIndex = 9;
            this.panel4.Visible = false;
            // 
            // chkDiemTichLuy
            // 
            this.chkDiemTichLuy.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDiemTichLuy.BoxBackColor = System.Drawing.Color.Transparent;
            this.chkDiemTichLuy.BoxColor = System.Drawing.Color.Black;
            this.chkDiemTichLuy.BoxLocationX = 0;
            this.chkDiemTichLuy.BoxLocationY = 0;
            this.chkDiemTichLuy.BoxSize = 15;
            this.chkDiemTichLuy.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDiemTichLuy.FlatAppearance.BorderSize = 0;
            this.chkDiemTichLuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDiemTichLuy.Location = new System.Drawing.Point(16, 15);
            this.chkDiemTichLuy.Name = "chkDiemTichLuy";
            this.chkDiemTichLuy.Size = new System.Drawing.Size(18, 19);
            this.chkDiemTichLuy.TabIndex = 1;
            this.chkDiemTichLuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDiemTichLuy.TextLocationX = 16;
            this.chkDiemTichLuy.TextLocationY = 1;
            this.chkDiemTichLuy.TickColor = System.Drawing.Color.Black;
            this.chkDiemTichLuy.TickLeftPosition = 0F;
            this.chkDiemTichLuy.TickSize = 11F;
            this.chkDiemTichLuy.TickTopPosition = 0F;
            this.chkDiemTichLuy.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnFilter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFilter.BorderRadius = 5;
            this.btnFilter.BorderSize = 0;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(787, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(43, 42);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.TextColor = System.Drawing.Color.White;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.label15);
            this.pnSearch.Controls.Add(this.txtTimKiem);
            this.pnSearch.Controls.Add(this.cbxTimKiem);
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(738, 69);
            this.pnSearch.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 12);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label12.Size = new System.Drawing.Size(92, 22);
            this.label12.TabIndex = 1;
            this.label12.Text = "Điểm tích lũy:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Image = global::GUI.Properties.Resources.icons8_search_25;
            this.label15.Location = new System.Drawing.Point(691, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 30);
            this.label15.TabIndex = 7;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.Color.White;
            this.txtFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFrom.BorderColor = System.Drawing.Color.Black;
            this.txtFrom.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.txtFrom.BorderRadius = 0;
            this.txtFrom.BorderSize = 1;
            this.txtFrom.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFrom.Location = new System.Drawing.Point(28, 38);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Multiline = false;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFrom.PasswordChar = false;
            this.txtFrom.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtFrom.PlaceholderText = "Từ";
            this.txtFrom.Size = new System.Drawing.Size(49, 30);
            this.txtFrom.TabIndex = 72;
            this.txtFrom.Texts = "";
            this.txtFrom.UnderlinedStyle = false;
            this.txtFrom._TextChanged += new System.EventHandler(this.txtFrom__TextChanged);
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.White;
            this.txtTo.BorderColor = System.Drawing.Color.Black;
            this.txtTo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.txtTo.BorderRadius = 0;
            this.txtTo.BorderSize = 1;
            this.txtTo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTo.Location = new System.Drawing.Point(138, 38);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Multiline = false;
            this.txtTo.Name = "txtTo";
            this.txtTo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTo.PasswordChar = false;
            this.txtTo.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtTo.PlaceholderText = "Đến";
            this.txtTo.Size = new System.Drawing.Size(49, 30);
            this.txtTo.TabIndex = 73;
            this.txtTo.Texts = "";
            this.txtTo.UnderlinedStyle = false;
            this.txtTo._TextChanged += new System.EventHandler(this.txtTo__TextChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.txtTimKiem.BorderColor = System.Drawing.Color.Black;
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.txtTimKiem.BorderRadius = 0;
            this.txtTimKiem.BorderSize = 2;
            this.txtTimKiem.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimKiem.Location = new System.Drawing.Point(135, 19);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "Nhập thông tin cần tìm";
            this.txtTimKiem.Size = new System.Drawing.Size(550, 29);
            this.txtTimKiem.TabIndex = 5;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = true;
            this.txtTimKiem._TextChanged += new System.EventHandler(this.txtTimKiem__TextChanged);
            // 
            // cbxTimKiem
            // 
            this.cbxTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.cbxTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.cbxTimKiem.BorderSize = 1;
            this.cbxTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxTimKiem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimKiem.ForeColor = System.Drawing.Color.Black;
            this.cbxTimKiem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.cbxTimKiem.ListBackColor = System.Drawing.Color.White;
            this.cbxTimKiem.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxTimKiem.Location = new System.Drawing.Point(18, 19);
            this.cbxTimKiem.MinimumSize = new System.Drawing.Size(50, 30);
            this.cbxTimKiem.Name = "cbxTimKiem";
            this.cbxTimKiem.Padding = new System.Windows.Forms.Padding(1);
            this.cbxTimKiem.Size = new System.Drawing.Size(110, 30);
            this.cbxTimKiem.TabIndex = 6;
            this.cbxTimKiem.Texts = "";
            this.cbxTimKiem.OnSelectedIndexChanged += new System.EventHandler(this.cbxTimKiem_OnSelectedIndexChanged);
            // 
            // pnFilter
            // 
            this.pnFilter.Controls.Add(this.label14);
            this.pnFilter.Location = new System.Drawing.Point(57, 176);
            this.pnFilter.Name = "pnFilter";
            this.pnFilter.Size = new System.Drawing.Size(85, 69);
            this.pnFilter.TabIndex = 8;
            this.pnFilter.Visible = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(293, 1);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label14.Size = new System.Drawing.Size(111, 32);
            this.label14.TabIndex = 75;
            this.label14.Text = "Giới tính";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 180F;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.label9);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Location = new System.Drawing.Point(4, 676);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(282, 35);
            this.gradientPanel1.TabIndex = 2;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(118, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label9.Size = new System.Drawing.Size(40, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "160";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label8.Size = new System.Drawing.Size(111, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Điểm tích lũy:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnNVLabel
            // 
            this.pnNVLabel.Angle = 0F;
            this.pnNVLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.pnNVLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnNVLabel.BottomColor = System.Drawing.Color.Empty;
            this.pnNVLabel.Controls.Add(this.label1);
            this.pnNVLabel.Location = new System.Drawing.Point(4, 4);
            this.pnNVLabel.Name = "pnNVLabel";
            this.pnNVLabel.Size = new System.Drawing.Size(282, 48);
            this.pnNVLabel.TabIndex = 0;
            this.pnNVLabel.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Red;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Red;
            this.rjButton1.BorderColor = System.Drawing.Color.Black;
            this.rjButton1.BorderRadius = 5;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(173, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(100, 26);
            this.rjButton1.TabIndex = 2;
            this.rjButton1.Text = "Không hoạt động";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(96, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 32);
            this.label13.TabIndex = 74;
            this.label13.Text = "-";
            // 
            // biggerCheckBox1
            // 
            this.biggerCheckBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.biggerCheckBox1.BoxBackColor = System.Drawing.Color.Transparent;
            this.biggerCheckBox1.BoxColor = System.Drawing.Color.Black;
            this.biggerCheckBox1.BoxLocationX = 0;
            this.biggerCheckBox1.BoxLocationY = 0;
            this.biggerCheckBox1.BoxSize = 15;
            this.biggerCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.biggerCheckBox1.FlatAppearance.BorderSize = 0;
            this.biggerCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.biggerCheckBox1.Location = new System.Drawing.Point(16, 90);
            this.biggerCheckBox1.Name = "biggerCheckBox1";
            this.biggerCheckBox1.Size = new System.Drawing.Size(18, 19);
            this.biggerCheckBox1.TabIndex = 75;
            this.biggerCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.biggerCheckBox1.TextLocationX = 16;
            this.biggerCheckBox1.TextLocationY = 1;
            this.biggerCheckBox1.TickColor = System.Drawing.Color.Black;
            this.biggerCheckBox1.TickLeftPosition = 0F;
            this.biggerCheckBox1.TickSize = 11F;
            this.biggerCheckBox1.TickTopPosition = 0F;
            this.biggerCheckBox1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(40, 87);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label16.Size = new System.Drawing.Size(92, 22);
            this.label16.TabIndex = 76;
            this.label16.Text = "Tuổi:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(96, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 32);
            this.label17.TabIndex = 79;
            this.label17.Text = "-";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.White;
            this.rjTextBox1.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 1;
            this.rjTextBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(138, 119);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.Gray;
            this.rjTextBox1.PlaceholderText = "Đến";
            this.rjTextBox1.Size = new System.Drawing.Size(49, 30);
            this.rjTextBox1.TabIndex = 78;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.Color.White;
            this.rjTextBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rjTextBox2.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rjTextBox2.BorderRadius = 0;
            this.rjTextBox2.BorderSize = 1;
            this.rjTextBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(28, 119);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.Gray;
            this.rjTextBox2.PlaceholderText = "Từ";
            this.rjTextBox2.Size = new System.Drawing.Size(49, 30);
            this.rjTextBox2.TabIndex = 77;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // KhachHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1150, 718);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.pnNVLabel);
            this.Controls.Add(this.pnThongTinNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhachHangGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhachHangGUI";
            this.Load += new System.EventHandler(this.KhachHangGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.pnThongTinNV.ResumeLayout(false);
            this.pnThongTinNV.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnFilter.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.pnNVLabel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewImageColumn IMG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTichLuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Panel pnThongTinNV;
        private MyCustom.GradientPanel pnNVLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImage;
        private MyCustom.RJButton btnUploadAnh;
        private CustomControls.RJControls.RJTextBox txtMaKH;
        private CustomControls.RJControls.RJTextBox txtTen;
        private CustomControls.RJControls.RJTextBox txtHo;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJDatePicker dtpNgaySinh;
        private CustomControls.RJControls.RJRadioButton rdbKHoatDong;
        private CustomControls.RJControls.RJRadioButton rdbHoatDong;
        private CustomControls.RJControls.RJTextBox txtSoDT;
        private CustomControls.RJControls.RJTextBox txtDiaChi;
        private CustomControls.RJControls.RJRadioButton rdbGioiTinhNu;
        private CustomControls.RJControls.RJRadioButton rdbGioiTinhNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private MyCustom.RJButton btnSua;
        private MyCustom.RJButton btnXoa;
        private MyCustom.RJButton btnReset;
        private MyCustom.RJButton btnThem;
        private MyCustom.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private MyCustom.RJButton rjButton1;
        private System.Windows.Forms.Panel panel1;
        private MyCustom.RJButton btnFilter;
        private CustomControls.RJControls.RJTextBox txtTimKiem;
        private CustomControls.RJControls.RJComboBox cbxTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnSearch;
        private CustomControls.RJControls.RJTextBox txtFrom;
        private CustomControls.RJControls.RJTextBox txtTo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnFilter;
        private System.Windows.Forms.Panel panel4;
        private MyCustom.BiggerCheckBox chkDiemTichLuy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private System.Windows.Forms.Label label16;
        private MyCustom.BiggerCheckBox biggerCheckBox1;
    }
}