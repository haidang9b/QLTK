using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DTO
{
    public class Staff
    {
        private string hoTen;
        private string diaChi;
        private int maGDV;
        private string maCN;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int MaGDV { get => maGDV; set => maGDV = value; }
        public string MaCN { get => maCN; set => maCN = value; }

        public Staff(string hoTen, string diaChi, int maGDV, string maCN)
        {
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.MaGDV = maGDV;
            this.MaCN = maCN;
        }

        public Staff(DataRow row)
        {
            this.HoTen = row["HOTEN"].ToString();
            this.DiaChi = row["DIACHI"].ToString();
            this.MaGDV = (int)row["MAGDV"];
            this.MaCN = row["MACN"].ToString();
        }

    }
}
