
namespace QuanLyTaiKhoan.SubForm
{
    partial class FormService
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
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLaiSuat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThangKy = new System.Windows.Forms.TextBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.cbxMaDV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AllowUserToAddRows = false;
            this.dgvPhieu.AllowUserToDeleteRows = false;
            this.dgvPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu.Location = new System.Drawing.Point(51, 241);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.ReadOnly = true;
            this.dgvPhieu.Size = new System.Drawing.Size(846, 286);
            this.dgvPhieu.TabIndex = 31;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnCapNhat.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCapNhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapNhat.IconSize = 30;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(412, 186);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(120, 30);
            this.btnCapNhat.TabIndex = 26;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtError);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtLaiSuat);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtThangKy);
            this.panel2.Controls.Add(this.txtTenDV);
            this.panel2.Controls.Add(this.cbxMaDV);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvPhieu);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 591);
            this.panel2.TabIndex = 3;
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.Location = new System.Drawing.Point(399, 150);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(0, 13);
            this.txtError.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "tháng";
            // 
            // txtLaiSuat
            // 
            this.txtLaiSuat.Location = new System.Drawing.Point(411, 110);
            this.txtLaiSuat.Name = "txtLaiSuat";
            this.txtLaiSuat.Size = new System.Drawing.Size(121, 20);
            this.txtLaiSuat.TabIndex = 51;
            this.txtLaiSuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Lãi suất";
            // 
            // txtThangKy
            // 
            this.txtThangKy.Location = new System.Drawing.Point(411, 83);
            this.txtThangKy.Name = "txtThangKy";
            this.txtThangKy.ReadOnly = true;
            this.txtThangKy.Size = new System.Drawing.Size(121, 20);
            this.txtThangKy.TabIndex = 49;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(411, 50);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.ReadOnly = true;
            this.txtTenDV.Size = new System.Drawing.Size(291, 20);
            this.txtTenDV.TabIndex = 48;
            // 
            // cbxMaDV
            // 
            this.cbxMaDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaDV.FormattingEnabled = true;
            this.cbxMaDV.Location = new System.Drawing.Point(411, 22);
            this.cbxMaDV.Name = "cbxMaDV";
            this.cbxMaDV.Size = new System.Drawing.Size(121, 21);
            this.cbxMaDV.TabIndex = 47;
            this.cbxMaDV.SelectedValueChanged += new System.EventHandler(this.cbxMaDV_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Tháng/Kỳ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Mã dịch vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "DỊCH VỤ VÀ LÃI SUẤT";
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
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 624);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormService";
            this.Text = "FormService";
            this.Load += new System.EventHandler(this.FormService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPhieu;
        private FontAwesome.Sharp.IconButton btnCapNhat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThangKy;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.ComboBox cbxMaDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLaiSuat;
    }
}