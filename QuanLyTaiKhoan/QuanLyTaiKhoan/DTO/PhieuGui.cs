using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DTO
{
    public class PhieuGui
    {
        private int maPhieu;
        private string CMND;
        private string maDV;
        private string ngayGui;
        private float laiSuat;
        private decimal soTienGui;
        private string ngayDenHan;
        private int maGDV_LPG;

        public PhieuGui(int maPhieu, string CMND, string maDV, string ngayGui, float laiSuat, decimal soTienGui, string ngayDenHan, int maGDV_LPG)
        {
            this.MaPhieu = maPhieu;
            this.CMND = CMND;
            this.maDV = maDV;
            this.ngayGui = ngayGui;
            this.laiSuat = laiSuat;
            this.soTienGui = soTienGui;
            this.ngayDenHan = ngayDenHan;
            this.maGDV_LPG = maGDV_LPG;
        }

        public PhieuGui(DataRow row)
        {
            this.maPhieu = (int)row["MAPHIEU"];
            this.CMND = row["CMND"].ToString();
            this.maDV = row["MADV"].ToString();
            this.ngayGui = row["NGAYGUI"].ToString();
            this.laiSuat = (float)row["LAISUAT"];
            this.soTienGui = Decimal.Parse(row["SOTIEN_GUI"].ToString(), System.Globalization.NumberStyles.Any);
            this.ngayDenHan = row["NGAYDENHAN"].ToString();
            this.maGDV_LPG = (int)row["MAGDV_LPG"];
        }

        public int MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string CMND1 { get => CMND; set => CMND = value; }
        public string MaDV { get => maDV; set => maDV = value; }
        public string NgayGui { get => ngayGui; set => ngayGui = value; }
        public float LaiSuat { get => laiSuat; set => laiSuat = value; }
        public decimal SoTienGui { get => soTienGui; set => soTienGui = value; }
        public string NgayDenHan { get => ngayDenHan; set => ngayDenHan = value; }
        public int MaGDV_LPG { get => maGDV_LPG; set => maGDV_LPG = value; }
    }
}

