using QuanLyTaiKhoan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public List<Account> LoadAllAccounts()
        {
            List<Account> list = new List<Account>();
            string query = "SELECT [ID_TAIKHOAN] AS'ID TÀI KHOẢN',[TAIKHOAN] AS 'USERNAME',[MATKHAU] AS 'MẬT KHẨU',[QUYEN] AS 'QUYỀN',[MACN] AS 'MÃ CN'  FROM [QL_TAIKHOAN].[dbo].[ACCOUNT]";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }

            return list;
        }

        public int LoginVerify(string username, string password)
        {
            string query = "SP_LOGINVERIFY @TAIKHOAN , @MATKHAU";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{ username, password });
            if (result.Rows.Count == 0)
            {
                return -1;
            }
            else
            {
                DataRow  row = result.Rows[0];
                return  (int)row["QUYEN"];
            }
            
        }
    }
}
