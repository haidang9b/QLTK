
namespace QuanLyTaiKhoan.SubForm
{
    partial class FormStatistical
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
            this.dateBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.bnReport = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMSG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AllowUserToAddRows = false;
            this.dgvPhieu.AllowUserToDeleteRows = false;
            this.dgvPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu.Location = new System.Drawing.Point(90, 218);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.ReadOnly = true;
            this.dgvPhieu.Size = new System.Drawing.Size(846, 405);
            this.dgvPhieu.TabIndex = 50;
            // 
            // dateBatDau
            // 
            this.dateBatDau.Location = new System.Drawing.Point(235, 84);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Size = new System.Drawing.Size(200, 20);
            this.dateBatDau.TabIndex = 51;
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.Location = new System.Drawing.Point(235, 140);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Size = new System.Drawing.Size(200, 20);
            this.dateKetThuc.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Ngày Bắt Đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Ngày Kết Thúc";
            // 
            // btnPrint
            // 
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.btnPrint.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrint.IconSize = 30;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(545, 81);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 30);
            this.btnPrint.TabIndex = 57;
            this.btnPrint.Text = "Phiếu gửi";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(711, 81);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(120, 30);
            this.iconButton1.TabIndex = 58;
            this.iconButton1.Text = "Phiếu rút";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(545, 129);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(120, 30);
            this.iconButton2.TabIndex = 59;
            this.iconButton2.Text = "Xuất Excel";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // bnReport
            // 
            this.bnReport.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.bnReport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bnReport.IconSize = 30;
            this.bnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnReport.Location = new System.Drawing.Point(711, 130);
            this.bnReport.Name = "bnReport";
            this.bnReport.Size = new System.Drawing.Size(120, 30);
            this.bnReport.TabIndex = 60;
            this.bnReport.Text = "Báo cáo";
            this.bnReport.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 29);
            this.label3.TabIndex = 61;
            this.label3.Text = "THỐNG KÊ PHIẾU";
            // 
            // txtMSG
            // 
            this.txtMSG.AutoSize = true;
            this.txtMSG.Location = new System.Drawing.Point(465, 182);
            this.txtMSG.Name = "txtMSG";
            this.txtMSG.Size = new System.Drawing.Size(0, 13);
            this.txtMSG.TabIndex = 62;
            // 
            // FormStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 728);
            this.Controls.Add(this.txtMSG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bnReport);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateKetThuc);
            this.Controls.Add(this.dateBatDau);
            this.Controls.Add(this.dgvPhieu);
            this.Name = "FormStatistical";
            this.Text = "FormStatistical";
            this.Load += new System.EventHandler(this.FormStatistical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.DateTimePicker dateBatDau;
        private System.Windows.Forms.DateTimePicker dateKetThuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnPrint;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton bnReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtMSG;
    }
}