using QuanLyTaiKhoan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiKhoan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public struct ConnectionString
        {
            public static string connectStringCN1 = "Data Source=DESKTOP-FV6DJR3\\MSSQLSERVER01;Initial Catalog=QL_TAIKHOAN;User ID=sa;Password=123;";
            public static string connectStringCN2 = "Data Source=DESKTOP-FV6DJR3\\MSSQLSERVER02;Initial Catalog=QL_TAIKHOAN;User ID=sa;Password=123;";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if(cbxChinhanh.Text == "")
            {
                txtError.Text = "Vui lòng chọn chi nhánh";
            }
            else if(txtUsername.Text == "" && txtPassword.Text == "")
            {
                txtError.Text = "Vui lòng nhập tài khoản và mật khẩu";
            }
            else if(txtUsername.Text == "")
            {
                txtError.Text = "Vui lòng nhập tài khoản";
            }
            else if(txtPassword.Text == "")
            {
                txtError.Text = "Vui lòng nhập mật khẩu";
            }
            else
            {
                string macn = "";
                if (cbxChinhanh.Text == "Chi nhánh 1")
                {
                    macn = "CN1";
                    DataProvider.Instance.setConnectionString("Data Source=DESKTOP-FV6DJR3\\MSSQLSERVER01;Initial Catalog=QL_TAIKHOAN;User ID=sa;Password=123;");
                }
                if(cbxChinhanh.Text == "Chi nhánh 2")
                {
                    macn = "CN2";
                    DataProvider.Instance.setConnectionString("Data Source=DESKTOP-FV6DJR3\\MSSQLSERVER02;Initial Catalog=QL_TAIKHOAN;User ID=sa;Password=123;");
                }
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                
                if (AccountDAO.Instance.LoginVerify(username, password)>=0)
                {
                    int role = AccountDAO.Instance.LoginVerify(username, password);
                    if (role == 0)
                    {
                        //txtError.Text = "Đăng nhập với quyền admin";
                        FormMainMenu formMainMenu = new FormMainMenu(username,macn,"ADMIN");
                        formMainMenu.Show();
                        this.Hide();
                    }
                    if(role == 1)
                    {
                        //txtError.Text = "Đăng nhập với quyền chi nhánh";
                        FormMainMenu formMainMenu = new FormMainMenu(username, macn, "CHINHANH");
                        formMainMenu.Show();
                        this.Hide();
                    }
                    if(role == 2)
                    {
                        //txtError.Text = "Đăng nhập với quyền user";
                        FormMainMenu formMainMenu = new FormMainMenu(username, macn, "USER");
                        formMainMenu.Show();
                        this.Hide();
                    }
                }
                else
                {
                    txtError.Text = "Tài khoản hoăc mật khẩu không chính xác";
                }
            }
        }
    }
}
