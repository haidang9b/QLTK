using QuanLyTaiKhoan.DAO;
using QuanLyTaiKhoan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiKhoan.SubForm
{
    public partial class FormRutTien : Form
    {
        

        public FormRutTien()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormRutTien_Load(object sender, EventArgs e)
        {
            dateCMND.Format = DateTimePickerFormat.Custom;
            dateCMND.CustomFormat = "dd/MM/yyyy";

            dateNgayDenHan.Format = DateTimePickerFormat.Custom;
            dateNgayDenHan.CustomFormat = "dd/MM/yyyy";

            dateNgayGui.Format = DateTimePickerFormat.Custom;
            dateNgayGui.CustomFormat = "dd/MM/yyyy";

            dateNgayRut.Format = DateTimePickerFormat.Custom;
            dateNgayRut.CustomFormat = "dd/MM/yyyy";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTraCuuSCMND_Click(object sender, EventArgs e)
        {
            string cmnd = txtCMND.Text;
            if (cmnd.Length == 0)
            {
                setError("Vui lòng nhập số CMND của khách hàng tra cứu");
            }
            else
            {
                if (CustomerDAO.Instance.HaveACustomerByCMND(cmnd))
                {
                    try
                    {
                        LoadCustomerByCMND(cmnd);
                        LoadPhieuGuiByCMND(cmnd);

                    }
                    catch
                    {
                        setError("Khách hàng này đang ở chi nhánh khác, vui lòng thử lại sau");
                    }

                }
                else
                {
                    setError("Không có khách hàng này");
                }
            }
        }

        private void LoadCustomerByCMND(string cmnd)
        {
            if (CustomerDAO.Instance.getCustomerByCMND(cmnd) != null)
            {
                Customer result = CustomerDAO.Instance.getCustomerByCMND(cmnd);
                txtTenKH.Text = result.HoTen;
                txtDiaChi.Text = result.DiaChi;
                dateCMND.Text = result.NgayCap;
                txtCMND.Enabled = false;

            }
        }

        private void setError(string msg)
        {
            txtError.ForeColor = Color.Red;
            txtError.Text = msg;
        }

        private void setSuccess(string msg)
        {
            txtError.ForeColor = Color.Green;
            txtError.Text = msg;
        }

        private decimal tinhLai(DateTime ngayDenHan, DateTime ngayRut, decimal tienGui, float laiSuat)
        {
            decimal tienLai = 0;
            double laiSuatHienHanh = 0.02;
            if(ngayRut.Date < ngayDenHan.Date)
            {
                string totalDays = (ngayRut.Date - ngayDenHan.Date).TotalDays.ToString();
                tienLai = tienGui * 0;

            }
            return tienLai;
        }
        

        private void LoadPhieuGuiByCMND(string cmnd)
        {
            List<PhieuGui> list = PhieuGuiDAO.Instance.LoadAllPhieuGuiByCMND(cmnd);
            cbxMaPhieu.DataSource = list;
            cbxMaPhieu.DisplayMember = "MAPHIEU";
        }
    }
}
