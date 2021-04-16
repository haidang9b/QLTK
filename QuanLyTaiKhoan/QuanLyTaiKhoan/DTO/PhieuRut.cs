using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DTO
{
    public class PhieuRut
    {
        private int maPhieu;
        private string ngayRut;
        private decimal tienLai;
        private decimal tongTien;
        private float maGDV_LPR;

        public PhieuRut(int maPhieu, string ngayRut, decimal tienLai, decimal tongTien, int maGDV_LPR)
        {
            this.MaPhieu = maPhieu;
            this.ngayRut = ngayRut;
            this.tienLai = tienLai;
            this.tongTien = tongTien;
            this.maGDV_LPR = maGDV_LPR;
        }

        public PhieuRut(DataRow row)
        {
            this.maPhieu = (int)row["MAPHIEU"];
            this.ngayRut = row["NGAYRUT"].ToString();
            this.tienLai = Decimal.Parse(row["TIENLAI"].ToString(), System.Globalization.NumberStyles.Any);
            this.tongTien = Decimal.Parse(row["TONGTIEN"].ToString(), System.Globalization.NumberStyles.Any);
            this.maGDV_LPR = (int)row["MAGDV_LPR"];
        }

        public int MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string NgayRut { get => ngayRut; set => ngayRut = value; }
        public decimal TienLai { get => tienLai; set => tienLai = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }
        public float MaGDV_LPR { get => maGDV_LPR; set => maGDV_LPR = value; }
    }
}
