using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DTO
{
    public class Service
    {
        private string maDV;
        private int kyHan;
        private string tenDV;

        public string MaDV { get => maDV; set => maDV = value; }
        public int KyHan { get => kyHan; set => kyHan = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }

        public Service(string maDV, int kyHan, string tenDV)
        {
            this.MaDV = maDV;
            this.KyHan = kyHan;
            this.TenDV = tenDV;
        }

        public Service(DataRow row)
        {
            this.MaDV = row["MADV"].ToString();
            this.KyHan = (int)row["KYHAN"];
            this.TenDV = row["TENDV"].ToString();
        }
        
    }

}
