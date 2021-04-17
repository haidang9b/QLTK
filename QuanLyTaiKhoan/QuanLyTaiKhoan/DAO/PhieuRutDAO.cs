using QuanLyTaiKhoan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DAO
{
    public class PhieuRutDAO
    {
        private static PhieuRutDAO instance;
        public static PhieuRutDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuRutDAO();
                return instance;
            }
            private set { instance = value; }
        }


        public List<PhieuRut> LoadAllPhieuRut()
        {
            List<PhieuRut> list = new List<PhieuRut>();
            string query = "SELECT [MAPHIEU],[NGAYRUT],[TIENLAI],[TONGTIEN],[MAGDV_LPR] FROM [QL_TAIKHOAN].[dbo].[PHIEURUT]  ORDER BY [NGAYRUT] DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhieuRut phieu = new PhieuRut(item);
                list.Add(phieu);
            }
            return list;
        }

        public bool AddNewPhieuRut(int maPhieu, string ngayRut, long tienLai, long tongTien, int maNV)
        {
            string query = "SET DATEFORMAT DMY INSERT INTO [dbo].[PHIEURUT]([MAPHIEU],[NGAYRUT],[TIENLAI],[TONGTIEN],[MAGDV_LPR],[rowguid])VALUES(" + maPhieu + ",'" + ngayRut + "'," + tienLai + "," + tongTien + "," + maNV + ",NEWID())";
            int result = DataProvider.Instance.ExecuteNoneQuery(query);
            return result > 0;
        }

        public bool RemovePhieuRut(int maPhieu)
        {
            string query = "DELETE FROM [dbo].PHIEURUT WHERE [MAPHIEU] =" + maPhieu;
            int result = DataProvider.Instance.ExecuteNoneQuery(query);
            return result > 0;
        }

        public List<PhieuRut> LoadPhieuRutByTime(string start, string end)
        {
            List<PhieuRut> list = new List<PhieuRut>();
            string query = "SET DATEFORMAT DMY SELECT [MAPHIEU],[NGAYRUT],[TIENLAI],[TONGTIEN],[MAGDV_LPR] FROM [QL_TAIKHOAN].[dbo].[PHIEURUT] WHERE [NGAYRUT]>='"+start+"' AND [NGAYRUT]<='"+end+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhieuRut phieu = new PhieuRut(item);
                list.Add(phieu);
            }
            return list;
        }
    }
}
