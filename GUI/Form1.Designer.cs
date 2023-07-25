namespace GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnSideMenu = new System.Windows.Forms.Panel();
            this.pnSubQuanLy = new System.Windows.Forms.Panel();
            this.pnLBNhanVien = new System.Windows.Forms.Panel();
            this.pnLBKhachHang = new System.Windows.Forms.Panel();
            this.btnKhachHang = new GUI.MyCustom.CustomButton();
            this.btnNhanVien = new GUI.MyCustom.CustomButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnLBQuanLy = new System.Windows.Forms.Panel();
            this.btnQuanLy = new GUI.MyCustom.CustomButton();
            this.pnSubHangHoa = new System.Windows.Forms.Panel();
            this.pnLBPhieuNhap = new System.Windows.Forms.Panel();
            this.pnLBNhapHang = new System.Windows.Forms.Panel();
            this.pnLBHoaDon = new System.Windows.Forms.Panel();
            this.pnLBBanHang = new System.Windows.Forms.Panel();
            this.btnPhieuNhap = new GUI.MyCustom.CustomButton();
            this.btnNhapHang = new GUI.MyCustom.CustomButton();
            this.btnHoaDon = new GUI.MyCustom.CustomButton();
            this.btnBanHang = new GUI.MyCustom.CustomButton();
            this.pnHangHoa = new System.Windows.Forms.Panel();
            this.pnLBHangHoa = new System.Windows.Forms.Panel();
            this.btnHangHoa = new GUI.MyCustom.CustomButton();
            this.pnTrangChu = new System.Windows.Forms.Panel();
            this.pnLBTrangChu = new System.Windows.Forms.Panel();
            this.btnTrangChu = new GUI.MyCustom.CustomButton();
            this.pnImage = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new GUI.MyCustom.GradientPanel();
            this.btnClose = new GUI.MyCustom.CustomButton();
            this.btnMinimize = new GUI.MyCustom.CustomButton();
            this.pnSideMenu.SuspendLayout();
            this.pnSubQuanLy.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnSubHangHoa.SuspendLayout();
            this.pnHangHoa.SuspendLayout();
            this.pnTrangChu.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSideMenu
            // 
            this.pnSideMenu.AutoScroll = true;
            this.pnSideMenu.BackColor = System.Drawing.Color.White;
            this.pnSideMenu.Controls.Add(this.pnSubQuanLy);
            this.pnSideMenu.Controls.Add(this.panel3);
            this.pnSideMenu.Controls.Add(this.pnSubHangHoa);
            this.pnSideMenu.Controls.Add(this.pnHangHoa);
            this.pnSideMenu.Controls.Add(this.pnTrangChu);
            this.pnSideMenu.Controls.Add(this.pnImage);
            this.pnSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSideMenu.Location = new System.Drawing.Point(0, 40);
            this.pnSideMenu.Name = "pnSideMenu";
            this.pnSideMenu.Size = new System.Drawing.Size(200, 760);
            this.pnSideMenu.TabIndex = 1;
            // 
            // pnSubQuanLy
            // 
            this.pnSubQuanLy.Controls.Add(this.pnLBNhanVien);
            this.pnSubQuanLy.Controls.Add(this.pnLBKhachHang);
            this.pnSubQuanLy.Controls.Add(this.btnKhachHang);
            this.pnSubQuanLy.Controls.Add(this.btnNhanVien);
            this.pnSubQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubQuanLy.Location = new System.Drawing.Point(0, 529);
            this.pnSubQuanLy.Name = "pnSubQuanLy";
            this.pnSubQuanLy.Size = new System.Drawing.Size(200, 99);
            this.pnSubQuanLy.TabIndex = 2;
            // 
            // pnLBNhanVien
            // 
            this.pnLBNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.pnLBNhanVien.Location = new System.Drawing.Point(0, 1);
            this.pnLBNhanVien.Name = "pnLBNhanVien";
            this.pnLBNhanVien.Size = new System.Drawing.Size(8, 45);
            this.pnLBNhanVien.TabIndex = 14;
            this.pnLBNhanVien.Visible = false;
            // 
            // pnLBKhachHang
            // 
            this.pnLBKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.pnLBKhachHang.Location = new System.Drawing.Point(0, 54);
            this.pnLBKhachHang.Name = "pnLBKhachHang";
            this.pnLBKhachHang.Size = new System.Drawing.Size(8, 45);
            this.pnLBKhachHang.TabIndex = 13;
            this.pnLBKhachHang.Visible = false;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.White;
            this.btnKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.btnKhachHang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKhachHang.BorderRadius = 0;
            this.btnKhachHang.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(3, 54);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(197, 45);
            this.btnKhachHang.TabIndex = 10;
            this.btnKhachHang.Text = "      Khách hàng";
            this.btnKhachHang.TextColor = System.Drawing.Color.Black;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.White;
            this.btnNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.btnNhanVien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNhanVien.BorderRadius = 0;
            this.btnNhanVien.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(3, 0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(197, 45);
            this.btnNhanVien.TabIndex = 9;
            this.btnNhanVien.Text = "      Nhân viên";
            this.btnNhanVien.TextColor = System.Drawing.Color.Black;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.btnQuanLy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 474);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 55);
            this.panel3.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.panel7.Controls.Add(this.pnLBQuanLy);
            this.panel7.Location = new System.Drawing.Point(0, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(8, 45);
            this.panel7.TabIndex = 12;
            this.panel7.Visible = false;
            // 
            // pnLBQuanLy
            // 
            this.pnLBQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.pnLBQuanLy.Location = new System.Drawing.Point(0, 0);
            this.pnLBQuanLy.Name = "pnLBQuanLy";
            this.pnLBQuanLy.Size = new System.Drawing.Size(8, 45);
            this.pnLBQuanLy.TabIndex = 13;
            this.pnLBQuanLy.Visible = false;
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.BackColor = System.Drawing.Color.White;
            this.btnQuanLy.BackgroundColor = System.Drawing.Color.White;
            this.btnQuanLy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnQuanLy.BorderRadius = 0;
            this.btnQuanLy.BorderSize = 0;
            this.btnQuanLy.FlatAppearance.BorderSize = 0;
            this.btnQuanLy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLy.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLy.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLy.Image")));
            this.btnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.Location = new System.Drawing.Point(0, 5);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnQuanLy.Size = new System.Drawing.Size(200, 45);
            this.btnQuanLy.TabIndex = 6;
            this.btnQuanLy.Text = "      Quản lý";
            this.btnQuanLy.TextColor = System.Drawing.Color.Black;
            this.btnQuanLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLy.UseVisualStyleBackColor = false;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // pnSubHangHoa
            // 
            this.pnSubHangHoa.Controls.Add(this.pnLBPhieuNhap);
            this.pnSubHangHoa.Controls.Add(this.pnLBNhapHang);
            this.pnSubHangHoa.Controls.Add(this.pnLBHoaDon);
            this.pnSubHangHoa.Controls.Add(this.pnLBBanHang);
            this.pnSubHangHoa.Controls.Add(this.btnPhieuNhap);
            this.pnSubHangHoa.Controls.Add(this.btnNhapHang);
            this.pnSubHangHoa.Controls.Add(this.btnHoaDon);
            this.pnSubHangHoa.Controls.Add(this.btnBanHang);
            this.pnSubHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubHangHoa.Location = new System.Drawing.Point(0, 253);
            this.pnSubHangHoa.Name = "pnSubHangHoa";
            this.pnSubHangHoa.Size = new System.Drawing.Size(200, 221);
            this.pnSubHangHoa.TabIndex = 4;
            // 
            // pnLBPhieuNhap
            // 
            this.pnLBPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.pnLBPhieuNhap.Location = new System.Drawing.Point(0, 174);
            this.pnLBPhieuNhap.Name = "pnLBPhieuNhap";
            this.pnLBPhieuNhap.Size = new System.Drawing.Size(8, 45);
            this.pnLBPhieuNhap.TabIndex = 12;
            this.pnLBPhieuNhap.Visible = false;
            // 
            // pnLBNhapHang
            // 
            this.pnLBNhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.pnLBNhapHang.Location = new System.Drawing.Point(0, 117);
            this.pnLBNhapHang.Name = "pnLBNhapHang";
            this.pnLBNhapHang.Size = new System.Drawing.Size(8, 45);
            this.pnLBNhapHang.TabIndex = 12;
            this.pnLBNhapHang.Visible = false;
            // 
            // pnLBHoaDon
            // 
            this.pnLBHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.pnLBHoaDon.Location = new System.Drawing.Point(0, 60);
            this.pnLBHoaDon.Name = "pnLBHoaDon";
            this.pnLBHoaDon.Size = new System.Drawing.Size(8, 45);
            this.pnLBHoaDon.TabIndex = 12;
            this.pnLBHoaDon.Visible = false;
            // 
            // pnLBBanHang
            // 
            this.pnLBBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.pnLBBanHang.Location = new System.Drawing.Point(0, 3);
            this.pnLBBanHang.Name = "pnLBBanHang";
            this.pnLBBanHang.Size = new System.Drawing.Size(8, 45);
            this.pnLBBanHang.TabIndex = 11;
            this.pnLBBanHang.Visible = false;
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.BackColor = System.Drawing.Color.White;
            this.btnPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.btnPhieuNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPhieuNhap.BorderRadius = 0;
            this.btnPhieuNhap.BorderSize = 0;
            this.btnPhieuNhap.FlatAppearance.BorderSize = 0;
            this.btnPhieuNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.btnPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuNhap.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuNhap.ForeColor = System.Drawing.Color.Black;
            this.btnPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuNhap.Image")));
            this.btnPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuNhap.Location = new System.Drawing.Point(3, 174);
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPhieuNhap.Size = new System.Drawing.Size(197, 45);
            this.btnPhieuNhap.TabIndex = 8;
            this.btnPhieuNhap.Text = "      Phiếu nhập";
            this.btnPhieuNhap.TextColor = System.Drawing.Color.Black;
            this.btnPhieuNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhieuNhap.UseVisualStyleBackColor = false;
            this.btnPhieuNhap.Click += new System.EventHandler(this.btnPhieuNhap_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.White;
            this.btnNhapHang.BackgroundColor = System.Drawing.Color.White;
            this.btnNhapHang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNhapHang.BorderRadius = 0;
            this.btnNhapHang.BorderSize = 0;
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.Black;
            this.btnNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapHang.Image")));
            this.btnNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.Location = new System.Drawing.Point(3, 117);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnNhapHang.Size = new System.Drawing.Size(197, 45);
            this.btnNhapHang.TabIndex = 7;
            this.btnNhapHang.Text = "      Nhập hàng";
            this.btnNhapHang.TextColor = System.Drawing.Color.Black;
            this.btnNhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.White;
            this.btnHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.btnHoaDon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHoaDon.BorderRadius = 0;
            this.btnHoaDon.BorderSize = 0;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(3, 60);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(197, 45);
            this.btnHoaDon.TabIndex = 6;
            this.btnHoaDon.Text = "      Hóa đơn";
            this.btnHoaDon.TextColor = System.Drawing.Color.Black;
            this.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.White;
            this.btnBanHang.BackgroundColor = System.Drawing.Color.White;
            this.btnBanHang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBanHang.BorderRadius = 0;
            this.btnBanHang.BorderSize = 0;
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.ForeColor = System.Drawing.Color.Black;
            this.btnBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanHang.Image")));
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.Location = new System.Drawing.Point(3, 3);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBanHang.Size = new System.Drawing.Size(197, 45);
            this.btnBanHang.TabIndex = 5;
            this.btnBanHang.Text = "      Bán hàng";
            this.btnBanHang.TextColor = System.Drawing.Color.Black;
            this.btnBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // pnHangHoa
            // 
            this.pnHangHoa.Controls.Add(this.pnLBHangHoa);
            this.pnHangHoa.Controls.Add(this.btnHangHoa);
            this.pnHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHangHoa.Location = new System.Drawing.Point(0, 198);
            this.pnHangHoa.Name = "pnHangHoa";
            this.pnHangHoa.Size = new System.Drawing.Size(200, 55);
            this.pnHangHoa.TabIndex = 6;
            // 
            // pnLBHangHoa
            // 
            this.pnLBHangHoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.pnLBHangHoa.Location = new System.Drawing.Point(0, 5);
            this.pnLBHangHoa.Name = "pnLBHangHoa";
            this.pnLBHangHoa.Size = new System.Drawing.Size(8, 45);
            this.pnLBHangHoa.TabIndex = 10;
            this.pnLBHangHoa.Visible = false;
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.BackColor = System.Drawing.Color.White;
            this.btnHangHoa.BackgroundColor = System.Drawing.Color.White;
            this.btnHangHoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHangHoa.BorderRadius = 0;
            this.btnHangHoa.BorderSize = 0;
            this.btnHangHoa.FlatAppearance.BorderSize = 0;
            this.btnHangHoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.btnHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangHoa.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHangHoa.ForeColor = System.Drawing.Color.Black;
            this.btnHangHoa.Image = ((System.Drawing.Image)(resources.GetObject("btnHangHoa.Image")));
            this.btnHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHangHoa.Location = new System.Drawing.Point(0, 5);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnHangHoa.Size = new System.Drawing.Size(200, 45);
            this.btnHangHoa.TabIndex = 4;
            this.btnHangHoa.Text = "      Hàng hóa";
            this.btnHangHoa.TextColor = System.Drawing.Color.Black;
            this.btnHangHoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHangHoa.UseVisualStyleBackColor = false;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // pnTrangChu
            // 
            this.pnTrangChu.Controls.Add(this.pnLBTrangChu);
            this.pnTrangChu.Controls.Add(this.btnTrangChu);
            this.pnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTrangChu.Location = new System.Drawing.Point(0, 143);
            this.pnTrangChu.Name = "pnTrangChu";
            this.pnTrangChu.Size = new System.Drawing.Size(200, 55);
            this.pnTrangChu.TabIndex = 7;
            // 
            // pnLBTrangChu
            // 
            this.pnLBTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.pnLBTrangChu.Location = new System.Drawing.Point(0, 5);
            this.pnLBTrangChu.Name = "pnLBTrangChu";
            this.pnLBTrangChu.Size = new System.Drawing.Size(8, 45);
            this.pnLBTrangChu.TabIndex = 9;
            this.pnLBTrangChu.Visible = false;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.White;
            this.btnTrangChu.BackgroundColor = System.Drawing.Color.White;
            this.btnTrangChu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTrangChu.BorderRadius = 0;
            this.btnTrangChu.BorderSize = 0;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Black;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 5);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(200, 45);
            this.btnTrangChu.TabIndex = 2;
            this.btnTrangChu.Text = "      Trang chủ";
            this.btnTrangChu.TextColor = System.Drawing.Color.Black;
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // pnImage
            // 
            this.pnImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnImage.Location = new System.Drawing.Point(0, 0);
            this.pnImage.Name = "pnImage";
            this.pnImage.Size = new System.Drawing.Size(200, 143);
            this.pnImage.TabIndex = 0;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(74)))));
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.btnMinimize);
            this.gradientPanel1.Controls.Add(this.btnClose);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1350, 40);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(138)))), ((int)(((byte)(74)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(102)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1308, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMinimize.BorderRadius = 0;
            this.btnMinimize.BorderSize = 0;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(138)))), ((int)(((byte)(74)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(102)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1260, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(42, 40);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextColor = System.Drawing.Color.Black;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1350, 800);
            this.Controls.Add(this.pnSideMenu);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnSideMenu.ResumeLayout(false);
            this.pnSubQuanLy.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnSubHangHoa.ResumeLayout(false);
            this.pnHangHoa.ResumeLayout(false);
            this.pnTrangChu.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MyCustom.GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel pnSideMenu;
        private System.Windows.Forms.Panel pnImage;
        private System.Windows.Forms.Panel pnSubHangHoa;
        private MyCustom.CustomButton btnPhieuNhap;
        private MyCustom.CustomButton btnNhapHang;
        private MyCustom.CustomButton btnHoaDon;
        private MyCustom.CustomButton btnBanHang;
        private System.Windows.Forms.Panel pnSubQuanLy;
        private MyCustom.CustomButton btnKhachHang;
        private MyCustom.CustomButton btnNhanVien;
        private System.Windows.Forms.Panel pnHangHoa;
        private MyCustom.CustomButton btnHangHoa;
        private System.Windows.Forms.Panel pnTrangChu;
        private MyCustom.CustomButton btnTrangChu;
        private System.Windows.Forms.Panel panel3;
        private MyCustom.CustomButton btnQuanLy;
        private System.Windows.Forms.Panel pnLBTrangChu;
        private System.Windows.Forms.Panel pnLBHangHoa;
        private System.Windows.Forms.Panel pnLBBanHang;
        private System.Windows.Forms.Panel pnLBNhanVien;
        private System.Windows.Forms.Panel pnLBKhachHang;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnLBQuanLy;
        private System.Windows.Forms.Panel pnLBPhieuNhap;
        private System.Windows.Forms.Panel pnLBNhapHang;
        private System.Windows.Forms.Panel pnLBHoaDon;
        private MyCustom.CustomButton btnClose;
        private MyCustom.CustomButton btnMinimize;
    }
}

