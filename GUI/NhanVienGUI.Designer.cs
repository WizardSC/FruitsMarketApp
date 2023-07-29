namespace GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttChucNang = new System.Windows.Forms.ToolTip(this.components);
            this.btnSua = new GUI.MyCustom.RJButton();
            this.btnXoa = new GUI.MyCustom.RJButton();
            this.btnReset = new GUI.MyCustom.RJButton();
            this.btnThem = new GUI.MyCustom.RJButton();
            this.pnThanhTimKiem = new System.Windows.Forms.Panel();
            this.txtTimKiem = new CustomControls.RJControls.RJTextBox();
            this.rjComboBox1 = new CustomControls.RJControls.RJComboBox();
            this.rjRadioButton1 = new CustomControls.RJControls.RJRadioButton();
            this.rjRadioButton2 = new CustomControls.RJControls.RJRadioButton();
            this.warningMaNV = new System.Windows.Forms.Label();
            this.errThongTin = new System.Windows.Forms.ErrorProvider(this.components);
            this.rjButton1 = new GUI.MyCustom.RJButton();
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
            this.warningHo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.Location = new System.Drawing.Point(306, 52);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVien.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.dgvNhanVien.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.RowTemplate.Height = 26;
            this.dgvNhanVien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(832, 654);
            this.dgvNhanVien.TabIndex = 1;
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
            this.IMG.Visible = false;
            this.IMG.Width = 64;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = global::GUI.Properties.Resources.placeholder_image;
            this.pictureBox1.Location = new System.Drawing.Point(74, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ttChucNang
            // 
            this.ttChucNang.ShowAlways = true;
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
            // pnThanhTimKiem
            // 
            this.pnThanhTimKiem.Controls.Add(this.txtTimKiem);
            this.pnThanhTimKiem.Controls.Add(this.rjComboBox1);
            this.pnThanhTimKiem.Controls.Add(this.rjRadioButton1);
            this.pnThanhTimKiem.Controls.Add(this.rjRadioButton2);
            this.pnThanhTimKiem.Location = new System.Drawing.Point(306, 3);
            this.pnThanhTimKiem.Name = "pnThanhTimKiem";
            this.pnThanhTimKiem.Size = new System.Drawing.Size(832, 43);
            this.pnThanhTimKiem.TabIndex = 38;
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
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.rjComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rjComboBox1.ListBackColor = System.Drawing.Color.White;
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(9, 9);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(50, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox1.Size = new System.Drawing.Size(110, 30);
            this.rjComboBox1.TabIndex = 4;
            this.rjComboBox1.Texts = "";
            // 
            // rjRadioButton1
            // 
            this.rjRadioButton1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rjRadioButton1.Location = new System.Drawing.Point(391, 9);
            this.rjRadioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjRadioButton1.Name = "rjRadioButton1";
            this.rjRadioButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjRadioButton1.Size = new System.Drawing.Size(67, 30);
            this.rjRadioButton1.TabIndex = 5;
            this.rjRadioButton1.TabStop = true;
            this.rjRadioButton1.Text = "Nam";
            this.rjRadioButton1.UnCheckedColor = System.Drawing.Color.Gray;
            this.rjRadioButton1.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton2
            // 
            this.rjRadioButton2.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rjRadioButton2.Location = new System.Drawing.Point(464, 9);
            this.rjRadioButton2.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjRadioButton2.Name = "rjRadioButton2";
            this.rjRadioButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjRadioButton2.Size = new System.Drawing.Size(67, 30);
            this.rjRadioButton2.TabIndex = 6;
            this.rjRadioButton2.TabStop = true;
            this.rjRadioButton2.Text = "Nữ";
            this.rjRadioButton2.UnCheckedColor = System.Drawing.Color.Gray;
            this.rjRadioButton2.UseVisualStyleBackColor = true;
            // 
            // warningMaNV
            // 
            this.warningMaNV.AutoSize = true;
            this.warningMaNV.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningMaNV.ForeColor = System.Drawing.Color.Red;
            this.warningMaNV.Location = new System.Drawing.Point(84, 242);
            this.warningMaNV.Name = "warningMaNV";
            this.warningMaNV.Size = new System.Drawing.Size(198, 15);
            this.warningMaNV.TabIndex = 39;
            this.warningMaNV.Text = "*Bạn phải điền đầy đủ thông tin";
            this.warningMaNV.Visible = false;
            // 
            // errThongTin
            // 
            this.errThongTin.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errThongTin.ContainerControl = this;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 17;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(253, 571);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(30, 29);
            this.rjButton1.TabIndex = 37;
            this.rjButton1.Text = "...";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
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
            this.txtSoDT.Location = new System.Drawing.Point(92, 519);
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
            // warningHo
            // 
            this.warningHo.AutoSize = true;
            this.warningHo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningHo.ForeColor = System.Drawing.Color.Red;
            this.warningHo.Location = new System.Drawing.Point(85, 294);
            this.warningHo.Name = "warningHo";
            this.warningHo.Size = new System.Drawing.Size(118, 15);
            this.warningHo.TabIndex = 42;
            this.warningHo.Text = "*Bạn phải nhập họ";
            this.warningHo.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(84, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 15);
            this.label9.TabIndex = 43;
            this.label9.Text = "*Bạn phải nhập tên";
            this.label9.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(89, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 15);
            this.label11.TabIndex = 44;
            this.label11.Text = "*Bạn phải điền ngày sinh";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(93, 448);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 15);
            this.label12.TabIndex = 45;
            this.label12.Text = "*Bạn phải điền ngày sinh";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(93, 500);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 15);
            this.label13.TabIndex = 46;
            this.label13.Text = "*Bạn phải điền ngày sinh";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(89, 552);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 15);
            this.label14.TabIndex = 47;
            this.label14.Text = "*Bạn phải điền ngày sinh";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(92, 604);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 15);
            this.label15.TabIndex = 48;
            this.label15.Text = "*Bạn phải điền ngày sinh";
            this.label15.Visible = false;
            // 
            // NhanVienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1150, 720);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.warningHo);
            this.Controls.Add(this.warningMaNV);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.rjButton1);
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
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnThanhTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errThongTin)).EndInit();
            this.pnLabelThongTin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private MyCustom.GradientPanel pnLabelThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMG;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtTimKiem;
        private CustomControls.RJControls.RJComboBox rjComboBox1;
        private CustomControls.RJControls.RJRadioButton rjRadioButton1;
        private CustomControls.RJControls.RJRadioButton rjRadioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txtHo;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private MyCustom.RJButton rjButton1;
        private System.Windows.Forms.ToolTip ttChucNang;
        private System.Windows.Forms.Panel pnThanhTimKiem;
        private System.Windows.Forms.Label warningMaNV;
        private System.Windows.Forms.ErrorProvider errThongTin;
        private CustomControls.RJControls.RJTextBox txtMaNV;
        private System.Windows.Forms.Label warningHo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}