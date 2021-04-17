using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QuanLyTaiKhoan.SubForm;

namespace QuanLyTaiKhoan
{
    public partial class FormMainMenu : Form
    {
        private IconButton currentButton;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private string username;
        private string macn;
        private string quyen;
        public FormMainMenu(string username, string macn, string quyen)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 80);
            panelMenu.Controls.Add(leftBorderBtn);
            this.username = username;
            this.macn = macn;
            this.quyen = quyen;


            phanQuyen(quyen);
        }

        private void Trang_chủ_Load(object sender, EventArgs e)
        {
            txtShowUsername.Text = username;
            txtShowQuyen.Text = quyen;
            txtShowMaCN.Text = macn;
            hideSubMenu();
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
          //  public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //button
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                // left border
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icon current child form
                iconCurrentChildForm.IconChar = currentButton.IconChar;
                iconCurrentChildForm.IconColor = color;

            }
        }
        private void DisableButton()
        {
            if(currentButton != null){
                currentButton.BackColor = Color.FromArgb(37, 30, 68);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void showSubMenu(Panel sub)
        {
            if (sub.Visible == false)
            {
                hideSubMenu();
                sub.Visible = true;
            }
            else
            {
                sub.Visible = false;
            }
                
        }


        private void hideSubMenu()
        {
            if(panelPhieu.Visible == true)
            {
                panelPhieu.Visible = false;
            }
            
        }
        private void btnCredit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(panelPhieu);
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lbTitleCurrentChildForm.Text = "Home";
        }
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitleCurrentChildForm.Text = childForm.Text;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuiTien_Click(object sender, EventArgs e)
        {
            lbTitleCurrentChildForm.Text = "Phiếu gửi tiền";
            OpenChildForm(new FormGuiTien());
            hideSubMenu();
        }

        private void btnRutTien_Click(object sender, EventArgs e)
        {
            lbTitleCurrentChildForm.Text = "Phiếu rút tiền";
            OpenChildForm(new FormRutTien());
            hideSubMenu();
        }

        private void btnDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            lbTitleCurrentChildForm.Text = "Danh sách khách hàng";
            OpenChildForm(new FormCustomers(macn,quyen));
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbTitleCurrentChildForm.Text = "Danh sách phiếu";
            hideSubMenu();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormCustomers(macn,quyen));
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormStaffs(macn,quyen));
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormService());
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormStatistical());
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phanQuyen (string quyen)
        {
            if(quyen == "USER")
            {
                btnService.Visible = false;
                btnStatistical.Visible = false;
                btnService.Visible = false;
            }
            if(quyen == "CHINHANH")
            {
                btnService.Visible = false;
            }

        }
    }
}
