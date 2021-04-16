using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DTO
{
    public class DichvuLaisuat
    {
        private string maDV;
        private int kyHan;
        private string tenDV;
        private string ngayAD;
        private float laiSuat;

        public DichvuLaisuat(string maDV, int kyHan, string tenDV, string ngayAD, float laiSuat)
        {
            this.maDV = maDV;
            this.kyHan = kyHan;
            this.tenDV = tenDV;
            this.ngayAD = ngayAD;
            this.laiSuat = laiSuat;
        }

        public DichvuLaisuat(DataRow row)
        {
            this.maDV = row["MADV"].ToString();
            this.kyHan = (int)row["KYHAN"];
            this.tenDV = row["TENDV"].ToString();
            this.ngayAD = row["NGAYAD"].ToString();
            this.laiSuat = (float)row["LASUAT"];
        }
        public string MaDV { get => maDV; set => maDV = value; }
        public int KyHan { get => kyHan; set => kyHan = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public string NgayAD { get => ngayAD; set => ngayAD = value; }
        public float LaiSuat { get => laiSuat; set => laiSuat = value; }
    }
}
