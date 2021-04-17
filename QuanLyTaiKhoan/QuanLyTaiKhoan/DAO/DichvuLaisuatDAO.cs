using QuanLyTaiKhoan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DAO
{
    public class DichvuLaisuatDAO
    {
        private static DichvuLaisuatDAO instance;
        public static DichvuLaisuatDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DichvuLaisuatDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public List<DichvuLaisuat> LoadAllDVLS()
        {
            List<DichvuLaisuat> list = new List<DichvuLaisuat>();
            string query = "SELECT  DV.[MADV],[KYHAN],[TENDV],[NGAYAD],[LASUAT]FROM [QL_TAIKHOAN].[dbo].[DICHVU] DV,  [QL_TAIKHOAN].[dbo].[LAISUAT] LS WHERE DV.MADV = LS.MADV ORDER BY [NGAYAD] DESC ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DichvuLaisuat dichvuLaisuat = new DichvuLaisuat(item);
                list.Add(dichvuLaisuat);
            }
            return list;
        }

        public DichvuLaisuat LoadDVLSByMaDV(string maDV)
        {
            
            List<DichvuLaisuat> list = new List<DichvuLaisuat>();
            string query = "SELECT  DV.[MADV],[KYHAN],[TENDV],[NGAYAD],[LASUAT]FROM [QL_TAIKHOAN].[dbo].[DICHVU] DV,  [QL_TAIKHOAN].[dbo].[LAISUAT] LS WHERE DV.MADV = LS.MADV AND DV.MADV ='"+maDV+"' ORDER BY [NGAYAD] DESC	";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DichvuLaisuat dichvuLaisuat = new DichvuLaisuat(item);
                list.Add(dichvuLaisuat);
            }

            DichvuLaisuat dvls = list[0];
            return dvls;
        }

        public DichvuLaisuat GetLaiSuatHienHanh()
        {
            List<DichvuLaisuat> list = new List<DichvuLaisuat>();
            string query = "SELECT top(1)  DV.[MADV],[KYHAN],[TENDV],[NGAYAD],[LASUAT]FROM [QL_TAIKHOAN].[dbo].[DICHVU] DV,  [QL_TAIKHOAN].[dbo].[LAISUAT] LS WHERE DV.MADV = LS.MADV AND dv.KYHAN=0 ORDER BY [NGAYAD] DESC	";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DichvuLaisuat dichvuLaisuat = new DichvuLaisuat(item);
                list.Add(dichvuLaisuat);
            }
            DichvuLaisuat dvls = list[0];
            return dvls;
        }


        public bool InsertLaiSuat(string maDV, string ngayAD, double laiSuat)
        {
            string query = "SET DATEFORMAT DMY INSERT INTO [dbo].[LAISUAT]([MADV],[NGAYAD],[LASUAT],[rowguid])VALUES('"+maDV+"','"+ngayAD+"','"+laiSuat+"',NEWID())";
            int rs = DataProvider.Instance.ExecuteNoneQuery(query); ;
            return rs > 0;
        }
    }
}
