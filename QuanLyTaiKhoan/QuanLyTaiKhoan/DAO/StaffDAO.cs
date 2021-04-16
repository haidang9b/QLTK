using QuanLyTaiKhoan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;
        public static StaffDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public List<Staff> LoadAllStaffs()
        {
            List<Staff> list = new List<Staff>();
            string query = "SELECT [HOTEN],[DIACHI],[MAGDV],[MACN] FROM [QL_TAIKHOAN].[dbo].[GIAODICHVIEN]";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                list.Add(staff);
            }
            return list;
        }

        public bool AddStaff(string hoTen, string diaChi, string maCN)
        {
            string query = "EXEC SP_ADDNEWSTAFF @HOTEN , @DIACHI , @MACN";
            int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] {hoTen, diaChi, maCN });
            return result > 0;
        }

        public bool RemoveStaff(int maGDV)
        {
            string query = "DELETE FROM [QL_TAIKHOAN].[dbo].[GIAODICHVIEN] WHERE MAGDV='" + maGDV + "'";
            int result = DataProvider.Instance.ExecuteNoneQuery(query);
            return result > 0;
        }
        public bool HaveAStaff(int maGDV)
        {
            string query = "DECLARE	@return_value int EXEC	@return_value = [dbo].[SP_KIEMTRAMAGDVTONTAI] @MAGDV = N'"+maGDV.ToString()+"' SELECT	'Return Value' = @return_value";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            DataRow row = result.Rows[0];
            return (int)row["Return Value"] == 1;
        }

        public bool UpdateStaff(string hoTen, string diaChi, int maGDV)
        {
            string query = "UPDATE [dbo].[GIAODICHVIEN] SET [HOTEN] =N'"+hoTen+"' ,[DIACHI] = N'"+diaChi+"' WHERE [MAGDV] =N'"+maGDV+"' ";
            int result = DataProvider.Instance.ExecuteNoneQuery(query);
            return result > 0;
        }
    }
}
