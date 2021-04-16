using QuanLyTaiKhoan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public List<Customer> LoadAllCustomers()
        {
            List<Customer> list = new List<Customer>();
            string query = "SELECT [HOTEN] ,[DIACHI] ,[CMND] ,[NGAYCAP] ,[MACN],[rowguid]FROM [QL_TAIKHOAN].[dbo].[KHACHHANG]";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }
            return list;
        }

        public bool AddCustomer(string hoTen, string diaChi, string cmnd, string ngayCap, string maCN)
        {
            string query = " SP_ADDNEWCUSTOMER @HOTEN , @DIACHI , @CMND , @NGAYCAP , @MACN";
            int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { hoTen, diaChi, cmnd, Convert.ToDateTime(ngayCap), maCN });
            return result > 0;
        }

        public bool HaveACustomerByCMND(string cmnd)
        {
            string query = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_KIEMTRAKHACHHANGTONTAI] @CMND = N'"+cmnd+"' SELECT 'Return Value' = @return_value";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            DataRow row = result.Rows[0];
            return (int)row["Return Value"] == 1;
        }

        public bool RemoveCustomer(string cmnd)
        {
            string query = "DELETE FROM [QL_TAIKHOAN].[dbo].[KHACHHANG] WHERE CMND='" + cmnd.ToString() + "'";
            int result = DataProvider.Instance.ExecuteNoneQuery(query);
            return result>0;
        }

        public bool UpdateCustomer(string hoTen, string diaChi, string cmnd, string ngayCap)
        {
            string query = "SP_UPDATECUSTOMER @HOTEN , @DIACHI , @CMND , @NGAYCAP";
            int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { hoTen, diaChi, cmnd, Convert.ToDateTime(ngayCap) });
            return result > 0;
        }

        public Customer getCustomerByCMND(string cmnd)
        {
            List<Customer> list = new List<Customer>();
            string query = "SELECT [HOTEN],[DIACHI],[CMND],[NGAYCAP],[MACN] FROM [QL_TAIKHOAN].[dbo].[KHACHHANG] WHERE [CMND] = '" + cmnd + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }
            return list[0];

        }
    }
}
