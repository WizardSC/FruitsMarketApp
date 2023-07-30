﻿namespace GUI
{
    partial class NhanVienGUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.ttChucNang = new System.Windows.Forms.ToolTip(this.components);
            this.pnThanhTimKiem = new System.Windows.Forms.Panel();
            this.warningMaNV = new System.Windows.Forms.Label();
            this.errThongTin = new System.Windows.Forms.ErrorProvider(this.components);
            this.warningHo = new System.Windows.Forms.Label();
            this.warningTen = new System.Windows.Forms.Label();
            this.warningNgaySinh = new System.Windows.Forms.Label();
            this.warningGioiTinh = new System.Windows.Forms.Label();
            this.warningDiaChi = new System.Windows.Forms.Label();
            this.warningSoDT = new System.Windows.Forms.Label();
            this.warningMaCV = new System.Windows.Forms.Label();
            this.btnUploadAnh = new GUI.MyCustom.RJButton();
            this.btnChonChucVu = new GUI.MyCustom.RJButton();
            this.btnSua = new GUI.MyCustom.RJButton();
            this.btnXoa = new GUI.MyCustom.RJButton();
            this.btnReset = new GUI.MyCustom.RJButton();
            this.btnThem = new GUI.MyCustom.RJButton();
            this.txtMaCV = new CustomControls.RJControls.RJTextBox();
            this.txtSoDT = new CustomControls.RJControls.RJTextBox();
            this.txtDiaChi = new CustomControls.RJControls.RJTextBox();
            this.rdbGioiTinhNu = new CustomControls.RJControls.RJRadioButton();
            this.rdbGioiTinhNam = new CustomControls.RJControls.RJRadioButton();
            this.dtpNgaySinh = new CustomControls.RJControls.RJDatePicker();
            this.txtTen = new CustomControls.RJControls.RJTextBox();
            this.txtHo = new CustomControls.RJControls.RJTextBox();
            this.txtMaNV = new CustomControls.RJControls.RJTextBox();
            this.pnLabelThongTin = new GUI.MyCustom.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new CustomControls.RJControls.RJTextBox();
            this.cbxTimKiem = new CustomControls.RJControls.RJComboBox();
            this.rdbTimKiemMaleGender = new CustomControls.RJControls.RJRadioButton();
            this.rdbTimKiemFemaleGender = new CustomControls.RJControls.RJRadioButton();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMG = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnThanhTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errThongTin)).BeginInit();
            this.pnLabelThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AllowUserToResizeColumns = false;
            this.dgvNhanVien.AllowUserToResizeRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNhanVien.ColumnHeadersHeight = 35;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.Column1,
            this.Ten,
            this.NgaySinh,
            this.GioiTinh,
            this.Column5,
            this.SoDT,
            this.Column7,
            this.IMG});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNhanVien.Location = new System.Drawing.Point(306, 52);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNhanVien.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.dgvNhanVien.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.RowTemplate.Height = 26;
            this.dgvNhanVien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(832, 654);
            this.dgvNhanVien.TabIndex = 1;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã NV";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Họ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 519);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Số ĐT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Địa chỉ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 571);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Mã CV";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Image = global::GUI.Properties.Resources.placeholder_image;
            this.pbImage.Location = new System.Drawing.Point(74, 67);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(150, 121);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 11;
            this.pbImage.TabStop = false;
            // 
            // ttChucNang
            // 
            this.ttChucNang.ShowAlways = true;
            // 
            // pnThanhTimKiem
            // 
            this.pnThanhTimKiem.Controls.Add(this.txtTimKiem);
            this.pnThanhTimKiem.Controls.Add(this.cbxTimKiem);
            this.pnThanhTimKiem.Controls.Add(this.rdbTimKiemMaleGender);
            this.pnThanhTimKiem.Controls.Add(this.rdbTimKiemFemaleGender);
            this.pnThanhTimKiem.Location = new System.Drawing.Point(306, 3);
            this.pnThanhTimKiem.Name = "pnThanhTimKiem";
            this.pnThanhTimKiem.Size = new System.Drawing.Size(832, 43);
            this.pnThanhTimKiem.TabIndex = 38;
            // 
            // warningMaNV
            // 
            this.warningMaNV.AutoSize = true;
            this.warningMaNV.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningMaNV.ForeColor = System.Drawing.Color.Red;
            this.warningMaNV.Location = new System.Drawing.Point(84, 242);
            this.warningMaNV.Name = "warningMaNV";
            this.warningMaNV.Size = new System.Drawing.Size(181, 15);
            this.warningMaNV.TabIndex = 39;
            this.warningMaNV.Text = "*Bạn phải điền mã nhân viên";
            this.warningMaNV.Visible = false;
            // 
            // errThongTin
            // 
            this.errThongTin.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errThongTin.ContainerControl = this;
            // 
            // warningHo
            // 
            this.warningHo.AutoSize = true;
            this.warningHo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningHo.ForeColor = System.Drawing.Color.Red;
            this.warningHo.Location = new System.Drawing.Point(84, 294);
            this.warningHo.Name = "warningHo";
            this.warningHo.Size = new System.Drawing.Size(118, 15);
            this.warningHo.TabIndex = 42;
            this.warningHo.Text = "*Bạn phải nhập họ";
            this.warningHo.Visible = false;
            // 
            // warningTen
            // 
            this.warningTen.AutoSize = true;
            this.warningTen.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningTen.ForeColor = System.Drawing.Color.Red;
            this.warningTen.Location = new System.Drawing.Point(84, 346);
            this.warningTen.Name = "warningTen";
            this.warningTen.Size = new System.Drawing.Size(123, 15);
            this.warningTen.TabIndex = 43;
            this.warningTen.Text = "*Bạn phải nhập tên";
            this.warningTen.Visible = false;
            // 
            // warningNgaySinh
            // 
            this.warningNgaySinh.AutoSize = true;
            this.warningNgaySinh.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningNgaySinh.ForeColor = System.Drawing.Color.Red;
            this.warningNgaySinh.Location = new System.Drawing.Point(84, 398);
            this.warningNgaySinh.Name = "warningNgaySinh";
            this.warningNgaySinh.Size = new System.Drawing.Size(157, 15);
            this.warningNgaySinh.TabIndex = 44;
            this.warningNgaySinh.Text = "*Bạn phải điền ngày sinh";
            this.warningNgaySinh.Visible = false;
            // 
            // warningGioiTinh
            // 
            this.warningGioiTinh.AutoSize = true;
            this.warningGioiTinh.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningGioiTinh.ForeColor = System.Drawing.Color.Red;
            this.warningGioiTinh.Location = new System.Drawing.Point(84, 448);
            this.warningGioiTinh.Name = "warningGioiTinh";
            this.warningGioiTinh.Size = new System.Drawing.Size(153, 15);
            this.warningGioiTinh.TabIndex = 45;
            this.warningGioiTinh.Text = "*Bạn phải chọn giới tính";
            this.warningGioiTinh.Visible = false;
            // 
            // warningDiaChi
            // 
            this.warningDiaChi.AutoSize = true;
            this.warningDiaChi.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningDiaChi.ForeColor = System.Drawing.Color.Red;
            this.warningDiaChi.Location = new System.Drawing.Point(84, 500);
            this.warningDiaChi.Name = "warningDiaChi";
            this.warningDiaChi.Size = new System.Drawing.Size(143, 15);
            this.warningDiaChi.TabIndex = 46;
            this.warningDiaChi.Text = "*Bạn phải nhập địa chỉ";
            this.warningDiaChi.Visible = false;
            // 
            // warningSoDT
            // 
            this.warningSoDT.AutoSize = true;
            this.warningSoDT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningSoDT.ForeColor = System.Drawing.Color.Red;
            this.warningSoDT.Location = new System.Drawing.Point(84, 552);
            this.warningSoDT.Name = "warningSoDT";
            this.warningSoDT.Size = new System.Drawing.Size(180, 15);
            this.warningSoDT.TabIndex = 47;
            this.warningSoDT.Text = "*Bạn phải nhập số điện thoại";
            this.warningSoDT.Visible = false;
            // 
            // warningMaCV
            // 
            this.warningMaCV.AutoSize = true;
            this.warningMaCV.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningMaCV.ForeColor = System.Drawing.Color.Red;
            this.warningMaCV.Location = new System.Drawing.Point(84, 604);
            this.warningMaCV.Name = "warningMaCV";
            this.warningMaCV.Size = new System.Drawing.Size(148, 15);
            this.warningMaCV.TabIndex = 48;
            this.warningMaCV.Text = "*Bạn phải chọn chức vụ";
            this.warningMaCV.Visible = false;
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
            this.btnUploadAnh.Location = new System.Drawing.Point(242, 107);
            this.btnUploadAnh.Name = "btnUploadAnh";
            this.btnUploadAnh.Size = new System.Drawing.Size(40, 40);
            this.btnUploadAnh.TabIndex = 49;
            this.btnUploadAnh.TextColor = System.Drawing.Color.White;
            this.ttChucNang.SetToolTip(this.btnUploadAnh, "Xóa");
            this.btnUploadAnh.UseVisualStyleBackColor = false;
            this.btnUploadAnh.Click += new System.EventHandler(this.btnUploadAnh_Click);
            // 
            // btnChonChucVu
            // 
            this.btnChonChucVu.BackColor = System.Drawing.Color.Transparent;
            this.btnChonChucVu.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnChonChucVu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChonChucVu.BorderRadius = 17;
            this.btnChonChucVu.BorderSize = 0;
            this.btnChonChucVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonChucVu.FlatAppearance.BorderSize = 0;
            this.btnChonChucVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChonChucVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChonChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonChucVu.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonChucVu.ForeColor = System.Drawing.Color.Black;
            this.btnChonChucVu.Location = new System.Drawing.Point(252, 571);
            this.btnChonChucVu.Name = "btnChonChucVu";
            this.btnChonChucVu.Size = new System.Drawing.Size(30, 29);
            this.btnChonChucVu.TabIndex = 37;
            this.btnChonChucVu.Text = "...";
            this.btnChonChucVu.TextColor = System.Drawing.Color.Black;
            this.btnChonChucVu.UseVisualStyleBackColor = false;
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
            this.btnSua.Location = new System.Drawing.Point(100, 642);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(40, 40);
            this.btnSua.TabIndex = 36;
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.ttChucNang.SetToolTip(this.btnSua, "Sửa");
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
            this.btnXoa.Location = new System.Drawing.Point(171, 642);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(40, 40);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.ttChucNang.SetToolTip(this.btnXoa, "Xóa");
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
            this.btnReset.Location = new System.Drawing.Point(242, 642);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(40, 40);
            this.btnReset.TabIndex = 34;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.ttChucNang.SetToolTip(this.btnReset, "Reload");
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
            this.btnThem.Location = new System.Drawing.Point(29, 642);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(40, 40);
            this.btnThem.TabIndex = 33;
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.ttChucNang.SetToolTip(this.btnThem, "Thêm");
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaCV
            // 
            this.txtMaCV.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaCV.BorderColor = System.Drawing.Color.Black;
            this.txtMaCV.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.txtMaCV.BorderRadius = 0;
            this.txtMaCV.BorderSize = 1;
            this.txtMaCV.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaCV.Location = new System.Drawing.Point(95, 571);
            this.txtMaCV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCV.Multiline = true;
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaCV.PasswordChar = false;
            this.txtMaCV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaCV.PlaceholderText = "";
            this.txtMaCV.Size = new System.Drawing.Size(149, 29);
            this.txtMaCV.TabIndex = 32;
            this.txtMaCV.Texts = "";
            this.txtMaCV.UnderlinedStyle = false;
            // 
            // txtSoDT
            // 
            this.txtSoDT.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoDT.BorderColor = System.Drawing.Color.Black;
            this.txtSoDT.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.txtSoDT.BorderRadius = 0;
            this.txtSoDT.BorderSize = 1;
            this.txtSoDT.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoDT.Location = new System.Drawing.Point(95, 519);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDT.Multiline = true;
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSoDT.PasswordChar = false;
            this.txtSoDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoDT.PlaceholderText = "";
            this.txtSoDT.Size = new System.Drawing.Size(187, 29);
            this.txtSoDT.TabIndex = 30;
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
            this.txtDiaChi.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiaChi.Location = new System.Drawing.Point(95, 467);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(187, 29);
            this.txtDiaChi.TabIndex = 29;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = false;
            this.txtDiaChi._TextChanged += new System.EventHandler(this.rjTextBox4__TextChanged);
            // 
            // rdbGioiTinhNu
            // 
            this.rdbGioiTinhNu.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rdbGioiTinhNu.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGioiTinhNu.Location = new System.Drawing.Point(194, 416);
            this.rdbGioiTinhNu.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbGioiTinhNu.Name = "rdbGioiTinhNu";
            this.rdbGioiTinhNu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbGioiTinhNu.Size = new System.Drawing.Size(67, 30);
            this.rdbGioiTinhNu.TabIndex = 27;
            this.rdbGioiTinhNu.TabStop = true;
            this.rdbGioiTinhNu.Text = "Nữ";
            this.rdbGioiTinhNu.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbGioiTinhNu.UseVisualStyleBackColor = true;
            // 
            // rdbGioiTinhNam
            // 
            this.rdbGioiTinhNam.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rdbGioiTinhNam.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGioiTinhNam.Location = new System.Drawing.Point(121, 416);
            this.rdbGioiTinhNam.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbGioiTinhNam.Name = "rdbGioiTinhNam";
            this.rdbGioiTinhNam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbGioiTinhNam.Size = new System.Drawing.Size(67, 30);
            this.rdbGioiTinhNam.TabIndex = 26;
            this.rdbGioiTinhNam.TabStop = true;
            this.rdbGioiTinhNam.Text = "Nam";
            this.rdbGioiTinhNam.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbGioiTinhNam.UseVisualStyleBackColor = true;
            this.rdbGioiTinhNam.CheckedChanged += new System.EventHandler(this.rjRadioButton4_CheckedChanged);
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
            this.dtpNgaySinh.Location = new System.Drawing.Point(95, 364);
            this.dtpNgaySinh.MinimumSize = new System.Drawing.Size(4, 29);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(187, 29);
            this.dtpNgaySinh.SkinColor = System.Drawing.Color.Transparent;
            this.dtpNgaySinh.TabIndex = 24;
            this.dtpNgaySinh.TextColor = System.Drawing.Color.Black;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtTen.BorderColor = System.Drawing.Color.Black;
            this.txtTen.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.txtTen.BorderRadius = 0;
            this.txtTen.BorderSize = 1;
            this.txtTen.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTen.Location = new System.Drawing.Point(96, 313);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTen.PasswordChar = false;
            this.txtTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTen.PlaceholderText = "";
            this.txtTen.Size = new System.Drawing.Size(187, 29);
            this.txtTen.TabIndex = 13;
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
            this.txtHo.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHo.Location = new System.Drawing.Point(96, 261);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHo.Multiline = true;
            this.txtHo.Name = "txtHo";
            this.txtHo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHo.PasswordChar = false;
            this.txtHo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHo.PlaceholderText = "";
            this.txtHo.Size = new System.Drawing.Size(187, 29);
            this.txtHo.TabIndex = 10;
            this.txtHo.Texts = "";
            this.txtHo.UnderlinedStyle = false;
            // 
            // txtMaNV
            // 
            this.txtMaNV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtMaNV.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaNV.BorderColor = System.Drawing.Color.Black;
            this.txtMaNV.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.txtMaNV.BorderRadius = 0;
            this.txtMaNV.BorderSize = 1;
            this.txtMaNV.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaNV.Location = new System.Drawing.Point(96, 210);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.MinimumSize = new System.Drawing.Size(0, 10);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaNV.PasswordChar = false;
            this.txtMaNV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaNV.PlaceholderText = "";
            this.txtMaNV.Size = new System.Drawing.Size(187, 29);
            this.txtMaNV.TabIndex = 9;
            this.txtMaNV.TabStop = false;
            this.txtMaNV.Texts = "";
            this.txtMaNV.UnderlinedStyle = false;
            // 
            // pnLabelThongTin
            // 
            this.pnLabelThongTin.Angle = 0F;
            this.pnLabelThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.pnLabelThongTin.BottomColor = System.Drawing.Color.Empty;
            this.pnLabelThongTin.Controls.Add(this.label1);
            this.pnLabelThongTin.Location = new System.Drawing.Point(11, 12);
            this.pnLabelThongTin.Name = "pnLabelThongTin";
            this.pnLabelThongTin.Size = new System.Drawing.Size(280, 39);
            this.pnLabelThongTin.TabIndex = 2;
            this.pnLabelThongTin.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtTimKiem.Location = new System.Drawing.Point(126, 10);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "Nhập thông tin cần tìm";
            this.txtTimKiem.Size = new System.Drawing.Size(258, 29);
            this.txtTimKiem.TabIndex = 3;
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
            this.cbxTimKiem.Location = new System.Drawing.Point(9, 9);
            this.cbxTimKiem.MinimumSize = new System.Drawing.Size(50, 30);
            this.cbxTimKiem.Name = "cbxTimKiem";
            this.cbxTimKiem.Padding = new System.Windows.Forms.Padding(1);
            this.cbxTimKiem.Size = new System.Drawing.Size(110, 30);
            this.cbxTimKiem.TabIndex = 4;
            this.cbxTimKiem.Texts = "";
            this.cbxTimKiem.OnSelectedIndexChanged += new System.EventHandler(this.cbxTimKiem_OnSelectedIndexChanged);
            // 
            // rdbTimKiemMaleGender
            // 
            this.rdbTimKiemMaleGender.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rdbTimKiemMaleGender.Location = new System.Drawing.Point(391, 9);
            this.rdbTimKiemMaleGender.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbTimKiemMaleGender.Name = "rdbTimKiemMaleGender";
            this.rdbTimKiemMaleGender.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbTimKiemMaleGender.Size = new System.Drawing.Size(67, 30);
            this.rdbTimKiemMaleGender.TabIndex = 5;
            this.rdbTimKiemMaleGender.TabStop = true;
            this.rdbTimKiemMaleGender.Text = "Nam";
            this.rdbTimKiemMaleGender.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbTimKiemMaleGender.UseVisualStyleBackColor = true;
            this.rdbTimKiemMaleGender.CheckedChanged += new System.EventHandler(this.rdbTimKiemMaleGender_CheckedChanged);
            // 
            // rdbTimKiemFemaleGender
            // 
            this.rdbTimKiemFemaleGender.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rdbTimKiemFemaleGender.Location = new System.Drawing.Point(464, 9);
            this.rdbTimKiemFemaleGender.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbTimKiemFemaleGender.Name = "rdbTimKiemFemaleGender";
            this.rdbTimKiemFemaleGender.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbTimKiemFemaleGender.Size = new System.Drawing.Size(67, 30);
            this.rdbTimKiemFemaleGender.TabIndex = 6;
            this.rdbTimKiemFemaleGender.TabStop = true;
            this.rdbTimKiemFemaleGender.Text = "Nữ";
            this.rdbTimKiemFemaleGender.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbTimKiemFemaleGender.UseVisualStyleBackColor = true;
            this.rdbTimKiemFemaleGender.CheckedChanged += new System.EventHandler(this.rdbTimKiemGenderNu_CheckedChanged);
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Ho";
            this.Column1.HeaderText = "Họ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "DiaChi";
            this.Column5.HeaderText = "Địa chỉ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // SoDT
            // 
            this.SoDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số ĐT";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "MaCV";
            this.Column7.HeaderText = "Mã CV";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // IMG
            // 
            this.IMG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IMG.DataPropertyName = "IMG";
            this.IMG.HeaderText = "IMG";
            this.IMG.MinimumWidth = 6;
            this.IMG.Name = "IMG";
            this.IMG.ReadOnly = true;
            this.IMG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IMG.Visible = false;
            this.IMG.Width = 64;
            // 
            // NhanVienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1150, 718);
            this.Controls.Add(this.btnUploadAnh);
            this.Controls.Add(this.warningMaCV);
            this.Controls.Add(this.warningSoDT);
            this.Controls.Add(this.warningDiaChi);
            this.Controls.Add(this.warningGioiTinh);
            this.Controls.Add(this.warningNgaySinh);
            this.Controls.Add(this.warningTen);
            this.Controls.Add(this.warningHo);
            this.Controls.Add(this.warningMaNV);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btnChonChucVu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaCV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdbGioiTinhNu);
            this.Controls.Add(this.rdbGioiTinhNam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnLabelThongTin);
            this.Controls.Add(this.pnThanhTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanVienGUI";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pnThanhTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errThongTin)).EndInit();
            this.pnLabelThongTin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private MyCustom.GradientPanel pnLabelThongTin;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtTimKiem;
        private CustomControls.RJControls.RJRadioButton rdbTimKiemMaleGender;
        private CustomControls.RJControls.RJRadioButton rdbTimKiemFemaleGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txtHo;
        private System.Windows.Forms.PictureBox pbImage;
        private CustomControls.RJControls.RJTextBox txtTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJControls.RJDatePicker dtpNgaySinh;
        private System.Windows.Forms.Label label10;
        private CustomControls.RJControls.RJRadioButton rdbGioiTinhNu;
        private CustomControls.RJControls.RJRadioButton rdbGioiTinhNam;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJTextBox txtDiaChi;
        private CustomControls.RJControls.RJTextBox txtSoDT;
        private System.Windows.Forms.Label label8;
        private CustomControls.RJControls.RJTextBox txtMaCV;
        private MyCustom.RJButton btnThem;
        private MyCustom.RJButton btnReset;
        private MyCustom.RJButton btnXoa;
        private MyCustom.RJButton btnSua;
        private MyCustom.RJButton btnChonChucVu;
        private System.Windows.Forms.ToolTip ttChucNang;
        private System.Windows.Forms.Panel pnThanhTimKiem;
        private System.Windows.Forms.Label warningMaNV;
        private System.Windows.Forms.ErrorProvider errThongTin;
        private CustomControls.RJControls.RJTextBox txtMaNV;
        private System.Windows.Forms.Label warningHo;
        private System.Windows.Forms.Label warningNgaySinh;
        private System.Windows.Forms.Label warningTen;
        private System.Windows.Forms.Label warningMaCV;
        private System.Windows.Forms.Label warningSoDT;
        private System.Windows.Forms.Label warningDiaChi;
        private System.Windows.Forms.Label warningGioiTinh;
        private CustomControls.RJControls.RJComboBox cbxTimKiem;
        private MyCustom.RJButton btnUploadAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn IMG;
    }
}