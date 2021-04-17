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
    public partial class FormGuiTien : Form
    {
        public FormGuiTien()
        {
            InitializeComponent();
        }

  

        private void FormGuiTien_Load(object sender, EventArgs e)
        {
            LoadAllCurrentPhieuGui();
            LoadDichVuLaiSuat();
            dateCMND.Format = DateTimePickerFormat.Custom;
            dateCMND.CustomFormat = "dd/MM/yyyy";
            dateNgayDenHan.Format = DateTimePickerFormat.Custom;
            dateNgayDenHan.CustomFormat = "dd/MM/yyyy";
        }

        private void LoadAllCurrentPhieuGui()
        {
            dgvPhieu.DataSource = PhieuGuiDAO.Instance.LoadAllPhieuGui();
            dgvPhieu.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPhieu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPhieu.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPhieu.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPhieu.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPhieu.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPhieu.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPhieu.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPhieu.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            // set header
            dgvPhieu.Columns[0].HeaderText = "Mã Phiếu";
            dgvPhieu.Columns[1].HeaderText = "CMND";
            dgvPhieu.Columns[2].HeaderText = "Mã DV";
            dgvPhieu.Columns[3].HeaderText = "Ngày gửi";
            dgvPhieu.Columns[4].HeaderText = "Lãi suất";
            dgvPhieu.Columns[5].HeaderText = "Kỳ hạn";
            dgvPhieu.Columns[6].HeaderText = "Số tiền gửi";
            dgvPhieu.Columns[7].HeaderText = "Ngày đến hạn";
            dgvPhieu.Columns[8].HeaderText = "Mã GDV lập phiếu";

            dgvPhieu.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPhieu.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void LoadDichVuLaiSuat()
        {
            List<Service> list = ServiceDAO.Instance.LoadAllService();
            cbxMaDV.DataSource = list;
            cbxMaDV.DisplayMember = "MADV";
        }

        private void cbxMaDV_SelectedValueChanged(object sender, EventArgs e)
        {
          
            ComboBox cb = sender as ComboBox;
            if (cbxMaDV.SelectedItem == null) 
            {
                return ;
            }
            Service selected = cbxMaDV.SelectedItem as Service;
            string maDv = selected.MaDV;
            try
            {
                DichvuLaisuat dvls = DichvuLaisuatDAO.Instance.LoadDVLSByMaDV(maDv);
                txtTenDV.Text = dvls.TenDV;
                txtLaiSuat.Text = dvls.LaiSuat.ToString();
                txtKyHan.Text = dvls.KyHan.ToString();
                int days = dvls.KyHan * 30;
                dateNgayDenHan.Value = DateTime.Today.AddDays(days);
            }
            catch
            {

            }

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnTraCuuSCMND_Click(object sender, EventArgs e)
        {
            string cmnd = txtCMND.Text;
            if(cmnd.Length == 0)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }
        private void clearTextBox()
        {
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtError.Text = "";
            txtMoney.Text = "";
            txtTenKH.Text = "";
            txtMaPhieu.Text = "";
            txtCMND.Enabled = true;
            btnThem.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string cmnd = txtCMND.Text;
            string maDV = cbxMaDV.Text;
            float laiSuat = float.Parse(txtLaiSuat.Text);
            int maGDV = Int32.Parse(txtMaGDV.Text);
            string ngayGui = DateTime.Now.ToString("dd/MM/yyyy");
            string ngayDenHan = dateNgayDenHan.Value.ToString();
            int kyHan = Convert.ToInt32(numericUpDownKyHan.Value);
            long soTienGui = Convert.ToInt64(txtMoney.Text);
            if (cmnd.Length == 0)
            {
                setError("Vui lòng nhập số cmnd khách hàng cần thêm");
            }
            else if(maDV.Length == 0)
            {
                setError("Vui lòng chọn mã dịch vụ");
            }
            else if(txtLaiSuat.Text.Length == 0)
            {
                setError("Dịch vụ này lãi suất không có");
            }
            else if(txtMoney.Text.Length == 0)
            {
                setError("Vui lòng nhập tiền cần gửi");
            }
            else if(kyHan < 0 || kyHan == 0)
            {
                setError("Vui chọn kỳ hạn hợp lệ");
            }
            else if(soTienGui < 100000)
            {
                setError("Số tiền tối thiểu là 100000");
            }
            else
            {
                
                if (txtCMND.Enabled == false)
                {
                    try
                    {

                        try
                        {
                            //textBox1.Text = " set dateformat dmy INSERT INTO [dbo].[PHIEUGUI]([CMND],[MADV],[NGAYGUI],[LAISUAT],[KYHAN],[SOTIEN_GUI],[NGAYDENHAN],[MAGDV_LPG],[rowguid]) VALUES (N'" + cmnd + "','" + maDV + "','" + ngayGui + "'," + laiSuat + "," + kyHan + "," + soTienGui + ",'" + ngayDenHan + "'," + maGDV + ",NEWID()) ";
                            if (PhieuGuiDAO.Instance.AddPhieuGui(cmnd, maDV, ngayGui, laiSuat, kyHan, ngayDenHan, soTienGui, maGDV))
                            {
                                clearTextBox();
                                setSuccess("Lập phiếu thành công");
                                LoadAllCurrentPhieuGui();
                                LoadDichVuLaiSuat();
                            }
                            else
                            {
                                setError("Lập phiếu thất bại");
                            }
                        }
                        catch
                        {
                            setError("Mã GDV không tồn tại trong CN hiện tại");
                        }
                    }
                    catch
                    {
                        setError("Số tiền bạn nhập quá lớn so với quy định");
                    }
                }
                else
                {
                    setError("SCMND chưa được tra cứu, vui lòng tra cứu mới có thể thêm được");
                }
            }
        }

        private void dgvPhieu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clearTextBox();
                txtMaPhieu.Text = dgvPhieu.Rows[e.RowIndex].Cells[0].Value.ToString();
                string customerFind = dgvPhieu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCMND.Text = customerFind;
                LoadCustomerByCMND(customerFind);
                string madv = dgvPhieu.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbxMaDV.SelectedIndex = cbxMaDV.FindStringExact(madv);
                dateNgayDenHan.Text = dgvPhieu.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtMaGDV.Text = dgvPhieu.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtMoney.Text = dgvPhieu.Rows[e.RowIndex].Cells[6].Value.ToString();
                numericUpDownKyHan.Value = Decimal.Parse(dgvPhieu.Rows[e.RowIndex].Cells[5].Value.ToString());
                btnThem.Enabled = false;

            }
            catch
            {

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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string cmnd = txtCMND.Text;
            string maDV = cbxMaDV.Text;
            float laiSuat = float.Parse(txtLaiSuat.Text);
            int maGDV = Int32.Parse(txtMaGDV.Text);
            string ngayGui = DateTime.Now.ToString("dd/MM/yyyy");
            string ngayDenHan = dateNgayDenHan.Text;
            if(txtMaPhieu.Text.Length == 0)
            {
                setError("Vui lòng chọn phiếu cần cập nhật");
            }
            else if (cmnd.Length == 0)
            {
                setError("Vui lòng nhập số cmnd khách hàng cần cập nhật");
            }
            else if (maDV.Length == 0)
            {
                setError("Vui lòng chọn mã dịch vụ");
            }
            else if (txtLaiSuat.Text.Length == 0)
            {
                setError("Dịch vụ này lãi suất không có");
            }
            else if (txtMoney.Text.Length == 0)
            {
                setError("Vui lòng nhập tiền cần cập nhật");
            }
            else
            {
                long soTienGui = Int64.Parse(txtMoney.Text);
                if (txtCMND.Enabled == false)
                {
                    try
                    {
                        //    if (PhieuGuiDAO.Instance.AddPhieuGui(cmnd, maDV, ngayGui, laiSuat, ngayDenHan, soTienGui, maGDV))
                        //    {
                        //        clearTextBox();
                        //        setSuccess("Cập nhật phiếu thành công");
                        //        LoadAllCurrentPhieuGui();
                        //        LoadDichVuLaiSuat();
                        //    }
                        //    else
                        //    {
                        //        setError("Cập nhật phiếu thất bại");
                        //    }
                    }
                    catch
                    {
                        setError("Số tiền bạn nhập quá lớn so với quy định");
                    }
                }
                else
                {
                    setError("SCMND chưa được tra cứu, vui lòng tra cứu mới có thể thêm được");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaPhieu.Text.Length == 0)
            {
                setError("Vui vui lòng chọn phiếu cần xóa");
            }
            else
            {
                try
                {
                    var result = MessageBox.Show("Bạn có muốn xóa phiếu gửi tiền có mã là " + txtMaPhieu.Text + " hay không?", "Xác minh xóa phiếu gửi tiền", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        int maPhieu = Int32.Parse(txtMaPhieu.Text);
                        if (PhieuGuiDAO.Instance.RemovePhieu(maPhieu))
                        {
                            clearTextBox();
                            setSuccess("Xóa phiếu thành công");
                            LoadAllCurrentPhieuGui();
                        }
                        else
                        {
                            setError("Xóa phiếu thất bại");
                        }
                    }
                }
                catch
                {
                    setError("Có vẻ như phiếu gửi tiền này đã được rút, xóa phiếu thất bại");
                }
            }
        }

       
    }
}
