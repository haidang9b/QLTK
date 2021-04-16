using QuanLyTaiKhoan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DAO
{
    public class ServiceDAO
    {
        private static ServiceDAO instance;
        public static ServiceDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServiceDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public List<Service> LoadAllService()
        {
            List<Service> list = new List<Service>();
            string query = "SELECT [MADV],[KYHAN],[TENDV] FROM [QL_TAIKHOAN].[dbo].[DICHVU]";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Service service = new Service(item);
                list.Add(service);
            }
            return list;
        }
        
    }
}
