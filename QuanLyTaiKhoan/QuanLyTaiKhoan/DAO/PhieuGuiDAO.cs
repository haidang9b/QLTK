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

        public bool AddPhieuGui(string cmnd, string maDV, string ngayGui, float laiSuat, int kyHan, string ngayDenHan , long stg, int maGDVG)
        {
            string query = " set dateformat dmy INSERT INTO [dbo].[PHIEUGUI]([CMND],[MADV],[NGAYGUI],[LAISUAT],[KYHAN],[SOTIEN_GUI],[NGAYDENHAN],[MAGDV_LPG],[rowguid]) VALUES (N'" + cmnd+"','"+maDV+"','"+ngayGui+"',"+laiSuat+","+kyHan+","+stg+",'"+ngayDenHan+"',"+maGDVG+",NEWID()) ";
            int result = DataProvider.Instance
                .ExecuteNoneQuery(query);
            return result > 0;
        }

        public List<PhieuGui> LoadAllPhieuGui()
        {
            List<PhieuGui> list = new List<PhieuGui>();
            string query = "SELECT [MAPHIEU],[CMND],[MADV],[NGAYGUI],[LAISUAT], [KYHAN] ,[SOTIEN_GUI],[NGAYDENHAN],[MAGDV_LPG] FROM [QL_TAIKHOAN].[dbo].[PHIEUGUI] ORDER BY MAPHIEU DESC";
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
            string query = "SELECT  [MAPHIEU],[CMND],[MADV],[NGAYGUI],[LAISUAT],[KYHAN],[SOTIEN_GUI],[NGAYDENHAN],[MAGDV_LPG] FROM PHIEUGUI WHERE MAPHIEU NOT IN(SELECT MAPHIEU FROM PHIEURUT) AND CMND ='" + cmnd+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhieuGui phieu = new PhieuGui(item);
                list.Add(phieu);
            }
            return list;
        }

        public List<PhieuGui> LoadPhieuGuiByTime(string start, string end)
        {

            List<PhieuGui> list = new List<PhieuGui>();
            string query = "SET DATEFORMAT DMY SELECT [MAPHIEU],[CMND],[MADV],[NGAYGUI],[LAISUAT],[KYHAN],[SOTIEN_GUI],[NGAYDENHAN],[MAGDV_LPG]FROM [QL_TAIKHOAN].[dbo].[PHIEUGUI] WHERE [NGAYGUI]>='"+start+"' AND [NGAYGUI]<='"+end+"'";
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
