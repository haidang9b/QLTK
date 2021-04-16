using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DTO
{
    public class Customer
    {
        
        private string hoTen;
        private string diaChi;
        private string cmnd;
        private string ngayCap;
        
        public Customer(string hoTen, string diaChi, string cmnd, string ngayCap)
        {
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.Cmnd = cmnd;
            this.NgayCap = ngayCap;
        }

        public Customer(DataRow row)
        {
            this.HoTen = row["HOTEN"].ToString();
            this.DiaChi = row["DIACHI"].ToString();
            this.Cmnd = row["CMND"].ToString();
            this.NgayCap = row["NGAYCAP"].ToString();
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string NgayCap { get => ngayCap; set => ngayCap = value; }
    }
}
