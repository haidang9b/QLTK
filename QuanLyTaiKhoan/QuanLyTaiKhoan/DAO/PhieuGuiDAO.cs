using QuanLyTaiKhoan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DAO
{
    public class PhieuGuiDAO
    {
        private static PhieuGuiDAO instance;
        public static PhieuGuiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuGuiDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public bool AddPhieuGui(string cmnd, string maDV, string ngayGui, float laiSuat, string ngayDenHan , long stg, int maGDVG)
        {
            string query = "SP_ADDPHIEUGUI @CMND , @MADV , @NGAYGUI , @LAISUAT , @SOTIEN_GUI , @NGAYDENHAN , @MAGDV_LPG ";
            int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] {cmnd, maDV, Convert.ToDateTime(ngayGui), laiSuat, stg, Convert.ToDateTime(ngayDenHan), maGDVG } );
            return result > 0;
        }

        public List<PhieuGui> LoadAllPhieuGui()
        {
            List<PhieuGui> list = new List<PhieuGui>();
            string query = "SELECT [MAPHIEU],[CMND],[MADV],[NGAYGUI],[LAISUAT],[SOTIEN_GUI],[NGAYDENHAN],[MAGDV_LPG] FROM [QL_TAIKHOAN].[dbo].[PHIEUGUI] ORDER BY MAPHIEU DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhieuGui phieu = new PhieuGui(item);
                list.Add(phieu);
            }
            return list;
        }

        public bool RemovePhieu(int maPhieu)
        {
            string query = "DELETE FROM [dbo].[PHIEUGUI] WHERE MAPHIEU="+maPhieu;
            int result = DataProvider.Instance.ExecuteNoneQuery(query);
            return result > 0;
        }

        public List<PhieuGui> LoadAllPhieuGuiByCMND(string cmnd)
        {
            List<PhieuGui> list = new List<PhieuGui>();
            string query = "SELECT [MAPHIEU],[CMND],[MADV],[NGAYGUI],[LAISUAT],[SOTIEN_GUI],[NGAYDENHAN],[MAGDV_LPG] FROM [QL_TAIKHOAN].[dbo].[PHIEUGUI] WHERE CMND ='"+cmnd+"' ORDER BY MAPHIEU DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhieuGui phieu = new PhieuGui(item);
                list.Add(phieu);
            }
            return list;
        }
    }
}
