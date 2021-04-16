using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DTO
{
    public class Account
    {
        int id;
        string username;
        string password;
        string quyen;
        string macn;

        public Account(int id, string username, string password, string quyen, string macn)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.quyen = quyen;
            this.macn = macn;
        }

        public Account(DataRow row)
        {
            this.id = (int)row["ID TÀI KHOẢN"];
            this.username = row["USERNAME"].ToString();
            this.password = row["MẬT KHẨU"].ToString();
            this.quyen = row["QUYỀN"].ToString();
            this.macn = row["MÃ CN"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Quyen { get => quyen; set => quyen = value; }
        public string Macn { get => macn; set => macn = value; }
    }
}
