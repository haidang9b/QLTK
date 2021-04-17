
namespace QuanLyTaiKhoan.SubForm
{
    partial class FormRutTien
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhieuRut = new System.Windows.Forms.DataGridView();
            this.btnTraCuuSCMND = new System.Windows.Forms.Button();
            this.dateCMND = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLaiSuat = new System.Windows.Forms.TextBox();
            this.txtKyHan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateNgayDenHan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateNgayGui = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.Label();
            this.txtMaGDV = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTongTienRut = new System.Windows.Forms.TextBox();
            this.txtTienLai = new System.Windows.Forms.TextBox();
            this.dateNgayRut = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMaPhieu = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnTinhLai = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuRut)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "PHIẾU RÚT TIỀN";
            // 
            // dgvPhieuRut
            // 
            this.dgvPhieuRut.AllowUserToAddRows = false;
            this.dgvPhieuRut.AllowUserToDeleteRows = false;
            this.dgvPhieuRut.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuRut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuRut.Location = new System.Drawing.Point(51, 344);
            this.dgvPhieuRut.Name = "dgvPhieuRut";
            this.dgvPhieuRut.ReadOnly = true;
            this.dgvPhieuRut.Size = new System.Drawing.Size(876, 219);
            this.dgvPhieuRut.TabIndex = 31;
            this.dgvPhieuRut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuRut_CellContentClick);
            // 
            // btnTraCuuSCMND
            // 
            this.btnTraCuuSCMND.Location = new System.Drawing.Point(340, 18);
            this.btnTraCuuSCMND.Name = "btnTraCuuSCMND";
            this.btnTraCuuSCMND.Size = new System.Drawing.Size(98, 23);
            this.btnTraCuuSCMND.TabIndex = 14;
            this.btnTraCuuSCMND.Text = "Tra cứu";
            this.btnTraCuuSCMND.UseVisualStyleBackColor = true;
            this.btnTraCuuSCMND.Click += new System.EventHandler(this.btnTraCuuSCMND_Click);
            // 
            // dateCMND
            // 
            this.dateCMND.CustomFormat = "dd/mm/yyyy";
            this.dateCMND.Enabled = false;
            this.dateCMND.Location = new System.Drawing.Point(122, 96);
            this.dateCMND.Name = "dateCMND";
            this.dateCMND.Size = new System.Drawing.Size(181, 20);
            this.dateCMND.TabIndex = 13;
            this.dateCMND.Value = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày cấp";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(122, 70);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(316, 20);
            this.txtDiaChi.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Địa chỉ";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(122, 46);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(316, 20);
            this.txtTenKH.TabIndex = 9;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(122, 20);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(181, 20);
            this.txtCMND.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số CMND";
            // 
            // txtLaiSuat
            // 
            this.txtLaiSuat.Location = new System.Drawing.Point(112, 94);
            this.txtLaiSuat.Name = "txtLaiSuat";
            this.txtLaiSuat.ReadOnly = true;
            this.txtLaiSuat.Size = new System.Drawing.Size(100, 20);
            this.txtLaiSuat.TabIndex = 7;
            // 
            // txtKyHan
            // 
            this.txtKyHan.Location = new System.Drawing.Point(112, 68);
            this.txtKyHan.Name = "txtKyHan";
            this.txtKyHan.ReadOnly = true;
            this.txtKyHan.Size = new System.Drawing.Size(100, 20);
            this.txtKyHan.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Lãi suất";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Kỳ hạn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã dịch vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenDV);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtMaDV);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtMoney);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateNgayDenHan);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dateNgayGui);
            this.groupBox2.Controls.Add(this.txtLaiSuat);
            this.groupBox2.Controls.Add(this.txtKyHan);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(593, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 206);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(112, 41);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.ReadOnly = true;
            this.txtTenDV.Size = new System.Drawing.Size(202, 20);
            this.txtTenDV.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Tên dịch vụ";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(112, 15);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.ReadOnly = true;
            this.txtMaDV.Size = new System.Drawing.Size(100, 20);
            this.txtMaDV.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Số tiền gửi";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(112, 172);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(181, 20);
            this.txtMoney.TabIndex = 34;
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ngày đến hạn";
            // 
            // dateNgayDenHan
            // 
            this.dateNgayDenHan.CustomFormat = "dd/mm/yyyy";
            this.dateNgayDenHan.Enabled = false;
            this.dateNgayDenHan.Location = new System.Drawing.Point(112, 146);
            this.dateNgayDenHan.Name = "dateNgayDenHan";
            this.dateNgayDenHan.Size = new System.Drawing.Size(181, 20);
            this.dateNgayDenHan.TabIndex = 16;
            this.dateNgayDenHan.Value = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày gửi";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateNgayGui
            // 
            this.dateNgayGui.CustomFormat = "dd/mm/yyyy";
            this.dateNgayGui.Enabled = false;
            this.dateNgayGui.Location = new System.Drawing.Point(112, 120);
            this.dateNgayGui.Name = "dateNgayGui";
            this.dateNgayGui.Size = new System.Drawing.Size(181, 20);
            this.dateNgayGui.TabIndex = 14;
            this.dateNgayGui.Value = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTraCuuSCMND);
            this.groupBox1.Controls.Add(this.dateCMND);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(51, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 127);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên khách hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMessage);
            this.panel2.Controls.Add(this.txtMaGDV);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtError);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.cbxMaPhieu);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.dgvPhieuRut);
            this.panel2.Controls.Add(this.btnTinhLai);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 591);
            this.panel2.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.txtMessage.AutoSize = true;
            this.txtMessage.Location = new System.Drawing.Point(112, 178);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(0, 13);
            this.txtMessage.TabIndex = 39;
            // 
            // txtMaGDV
            // 
            this.txtMaGDV.Location = new System.Drawing.Point(419, 139);
            this.txtMaGDV.Name = "txtMaGDV";
            this.txtMaGDV.Size = new System.Drawing.Size(100, 20);
            this.txtMaGDV.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(348, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Mã GDV";
            // 
            // txtError
            // 
            this.txtError.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.txtError.AutoSize = true;
            this.txtError.Location = new System.Drawing.Point(143, 178);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(0, 13);
            this.txtError.TabIndex = 36;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTongTienRut);
            this.groupBox3.Controls.Add(this.txtTienLai);
            this.groupBox3.Controls.Add(this.dateNgayRut);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(593, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 107);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin rút";
            // 
            // txtTongTienRut
            // 
            this.txtTongTienRut.Location = new System.Drawing.Point(123, 75);
            this.txtTongTienRut.Name = "txtTongTienRut";
            this.txtTongTienRut.ReadOnly = true;
            this.txtTongTienRut.Size = new System.Drawing.Size(181, 20);
            this.txtTongTienRut.TabIndex = 41;
            this.txtTongTienRut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTienLai
            // 
            this.txtTienLai.Location = new System.Drawing.Point(123, 46);
            this.txtTienLai.Name = "txtTienLai";
            this.txtTienLai.ReadOnly = true;
            this.txtTienLai.Size = new System.Drawing.Size(181, 20);
            this.txtTienLai.TabIndex = 40;
            this.txtTienLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateNgayRut
            // 
            this.dateNgayRut.CustomFormat = "dd/mm/yyyy";
            this.dateNgayRut.Enabled = false;
            this.dateNgayRut.Location = new System.Drawing.Point(123, 19);
            this.dateNgayRut.Name = "dateNgayRut";
            this.dateNgayRut.Size = new System.Drawing.Size(181, 20);
            this.dateNgayRut.TabIndex = 39;
            this.dateNgayRut.Value = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Tổng số tiền rút";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Tiền lãi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Ngày rút";
            // 
            // cbxMaPhieu
            // 
            this.cbxMaPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaPhieu.FormattingEnabled = true;
            this.cbxMaPhieu.Location = new System.Drawing.Point(173, 139);
            this.cbxMaPhieu.Name = "cbxMaPhieu";
            this.cbxMaPhieu.Size = new System.Drawing.Size(169, 21);
            this.cbxMaPhieu.TabIndex = 34;
            this.cbxMaPhieu.SelectedValueChanged += new System.EventHandler(this.cbxMaPhieu_SelectedValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(77, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Mã phiếu";
            // 
            // btnTinhLai
            // 
            this.btnTinhLai.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnTinhLai.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTinhLai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTinhLai.IconSize = 30;
            this.btnTinhLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhLai.Location = new System.Drawing.Point(295, 288);
            this.btnTinhLai.Name = "btnTinhLai";
            this.btnTinhLai.Size = new System.Drawing.Size(120, 30);
            this.btnTinhLai.TabIndex = 26;
            this.btnTinhLai.Text = "Tính tiền lãi";
            this.btnTinhLai.UseVisualStyleBackColor = true;
            this.btnTinhLai.Click += new System.EventHandler(this.btnTinhLai_Click);
            // 
            // btnClear
            // 
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnClear.IconColor = System.Drawing.Color.SandyBrown;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 30;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(114, 288);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 30);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Nhập lại";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoa.IconColor = System.Drawing.Color.Red;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 30;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(295, 227);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 30);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.DarkSeaGreen;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 30;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(115, 227);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 30);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Lập phiếu rút";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 33);
            this.panel1.TabIndex = 2;
            // 
            // FormRutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 624);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormRutTien";
            this.Text = "FormGuiTien";
            this.Load += new System.EventHandler(this.FormRutTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuRut)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhieuRut;
        private System.Windows.Forms.Button btnTraCuuSCMND;
        private System.Windows.Forms.DateTimePicker dateCMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLaiSuat;
        private System.Windows.Forms.TextBox txtKyHan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnTinhLai;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateNgayDenHan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateNgayGui;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTongTienRut;
        private System.Windows.Forms.TextBox txtTienLai;
        private System.Windows.Forms.DateTimePicker dateNgayRut;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMaPhieu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.TextBox txtMaGDV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label txtMessage;
    }
}