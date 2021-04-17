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

            loadAllPhieuRut();
        }

        private void phanQuyen()
        {

        }
        private void loadAllPhieuRut()
        {
            dgvPhieuRut.DataSource = PhieuRutDAO.Instance.LoadAllPhieuRut();
            dgvPhieuRut.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPhieuRut.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPhieuRut.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPhieuRut.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPhieuRut.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvPhieuRut.Columns[0].HeaderText = "Mã Phiếu";
            dgvPhieuRut.Columns[1].HeaderText = "Ngày rút";
            dgvPhieuRut.Columns[2].HeaderText = "Tiền lãi";
            dgvPhieuRut.Columns[3].HeaderText = "Tổng tiền";
            dgvPhieuRut.Columns[4].HeaderText = "Mã GDV rút";

            dgvPhieuRut.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPhieuRut.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void clearTextBox()
        {
            txtTongTienRut.Text = "";
            txtTienLai.Text = "";
            txtLaiSuat.Text = "";
            txtKyHan.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtError.Text = "";
            txtTenDV.Text = "";
            txtMaDV.Text = "";
            dateCMND.Text = "";
            dateNgayDenHan.Text = "";
            dateNgayGui.Text = "";
            dateNgayRut.Text = "";
            txtMoney.Text = "";
            txtTenKH.Text = "";
            cbxMaPhieu.DataSource = null;
            txtCMND.Enabled = true;
            btnTinhLai.Enabled = true;
            txtMaGDV.Text = "";
        }

        private void btnTraCuuSCMND_Click(object sender, EventArgs e)
        {
            string cmnd = txtCMND.Text;
            btnXoa.Enabled = false;
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

        private double tinhLai(DateTime ngayDenHan, DateTime ngayGui ,DateTime ngayRut, decimal tienGui, float laiSuat, int kyHan)
        {
            
            double tienLai = 0;
            double tienGUI = Convert.ToDouble(tienGui);
            double tongTien = tienGUI;
            DichvuLaisuat dvls = DichvuLaisuatDAO.Instance.GetLaiSuatHienHanh();
            float laiSuatHienHanh = dvls.LaiSuat;
            if (ngayRut.Date < ngayDenHan.Date)
            {
                double totalDays = (ngayRut.Date - ngayGui.Date).TotalDays;
                tienLai = tienGUI * (totalDays/30.0)*laiSuatHienHanh;
                tongTien += tienLai;

            }
            else if(ngayRut.Date == ngayDenHan.Date)
            {
                tienLai = tienGUI * laiSuat * kyHan;
            }
            else
            {
                tienLai = tienGUI * laiSuat * kyHan;
            }
            return Math.Round(tienLai,0, MidpointRounding.AwayFromZero);
        }
        

        private void LoadPhieuGuiByCMND(string cmnd)
        {
            List<PhieuGui> list = PhieuGuiDAO.Instance.LoadAllPhieuGuiByCMND(cmnd);
            cbxMaPhieu.DataSource = list;
            cbxMaPhieu.DisplayMember = "MAPHIEU";
        }

        private void cbxMaPhieu_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cbxMaPhieu.SelectedItem == null)
            {
                return;
            }
            PhieuGui phieu = cbxMaPhieu.SelectedItem as PhieuGui;
            try
            {
                if (phieu!= null)
                {
                    txtMaDV.Text = phieu.MaDV;
                    txtMoney.Text = Math.Round(phieu.SoTienGui, 0).ToString();
                    txtLaiSuat.Text = phieu.LaiSuat.ToString();
                    dateNgayGui.Value = Convert.ToDateTime(phieu.NgayGui);
                    dateNgayDenHan.Value = Convert.ToDateTime(phieu.NgayDenHan);
                    txtKyHan.Text = phieu.KyHan.ToString();
                    string maDV = phieu.MaDV;
                    try
                    {
                        DichvuLaisuat dvls = DichvuLaisuatDAO.Instance.LoadDVLSByMaDV(maDV);
                        txtTenDV.Text = dvls.TenDV;

                    }
                    catch
                    {

                    }
                }
                

            }
            catch
            {

            }
            txtTienLai.Text = "";
        }

        private void btnTinhLai_Click(object sender, EventArgs e)
        {
            if(cbxMaPhieu.Text.Length == 0)
            {
                setError("Vui lòng chọn phiếu cần tính");
            }
            else
            {
                DateTime ngayDenHan = dateNgayDenHan.Value;
                DateTime ngayRut = DateTime.Now.Date;
                DateTime ngayGui = dateNgayGui.Value;
                decimal tienGui = Decimal.Parse(txtMoney.Text);
                float laiSuat = float.Parse(txtLaiSuat.Text);
                int kyHan = Int32.Parse(txtKyHan.Text);

                double tienLai = tinhLai(ngayDenHan,ngayGui ,ngayRut, tienGui, laiSuat, kyHan);
                txtTienLai.Text = tienLai.ToString();
                double tongTienRut = tienLai + Int64.Parse(txtMoney.Text);
                txtTongTienRut.Text = tongTienRut.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string cmnd = txtCMND.Text;
            string hoTen = txtTenKH.Text;
            string maDV = txtMaDV.Text;

           
           

            if(cmnd.Length == 0)
            {
                setError("Vui lòng nhập CMND của khách hàng");
            }
            else if(cbxMaPhieu.Text == "")
            {
                setError("Vui lòng chọn phiếu");
            }
            else if(hoTen.Length == 0)
            {
                setError("Vui lòng tra cứu khách hàng");
            }
            else if(maDV.Length == 0)
            {
                setError("Phiếu không có mã DV");
            }
            else if(txtLaiSuat.Text.Length == 0)
            {
                setError("Phiếu không có lãi suất");
            }
            else if(txtTienLai.Text.Length == 0)
            {
                setError("Vui lòng tính lãi");
            }
            else if(txtTongTienRut.Text.Length == 0)
            {
                setError("Vui lòng tính lãi");
            }
            else if(txtMaGDV.Text.Length == 0)
            {
                setError("Vui lòng nhập mã GDV");
            }
            else
            {
                try
                {
                    int maNV = Convert.ToInt32(txtMaGDV.Text);

                    int kyHan = Convert.ToInt32(txtKyHan.Text);
                    long tienLai = Convert.ToInt64(txtTienLai.Text);
                    long tongTien = Convert.ToInt64(txtTongTienRut.Text);
                    string ngayRut = DateTime.Now.ToString("dd/MM/yyyy");
                    int maPhieu = Convert.ToInt32(cbxMaPhieu.Text);
                    if (StaffDAO.Instance.HaveAStaff(maNV))
                    {
                        if(PhieuRutDAO.Instance.AddNewPhieuRut(maPhieu,ngayRut, tienLai, tongTien, maNV))
                        {
                            clearTextBox();
                            setSuccess("Lập phiếu rút thành công");
                            loadAllPhieuRut();
                        }
                        else
                        {
                            setError("Lập phiếu thất bại");
                        }
                    }
                    else
                    {
                        setError("Vui lòng nhập mã GDV hợp lệ");
                    }
                }
                catch
                {
                    setError("Có vẻ như Mã GDV này đang ở chi nhánh khác");
                }
                
            }


        }

        private void dgvPhieuRut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                clearTextBox();
                btnXoa.Enabled = true;
                btnTinhLai.Enabled = false;
                btnThem.Enabled = false;
                cbxMaPhieu.Items.Clear();
                //cbxMaPhieu.SelectedItem = dgvPhieuRut.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbxMaPhieu.Items.Add(dgvPhieuRut.Rows[e.RowIndex].Cells[0].Value.ToString());
                cbxMaPhieu.Text = dgvPhieuRut.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTongTienRut.Text = dgvPhieuRut.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTienLai.Text = dgvPhieuRut.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMaGDV.Text = dgvPhieuRut.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateNgayRut.Text = dgvPhieuRut.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
                clearTextBox();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(cbxMaPhieu.Text.Length == 0)
            {
                setError("Vui lòng chọn phiếu xóa cần xóa");
            }
            else
            {
                int maPhieu = Convert.ToInt32(cbxMaPhieu.Text);
                var result = MessageBox.Show("Bạn có muốn xóa phiếu rút này không?", "Xác minh xóa phiếu rút tiền", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        if (PhieuRutDAO.Instance.RemovePhieuRut(maPhieu))
                        {
                            loadAllPhieuRut();
                            setSuccess("Xóa phiếu thành công");
                            clearTextBox();
                        }
                        else
                        {
                            setError("Xóa phiếu thất bại");
                        }
                    }
                    catch
                    {
                        setError("mã phiếu không hợp lệ hoặc chưa được lập phiếu rút");
                    }


                }
                
            }

        }
    }
}
