using QuanLyTaiKhoan.DAO;
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
    public partial class FormCustomers : Form
    {
        private string macn;
        public FormCustomers(string macn, string quyen)
        {
            InitializeComponent();
            this.macn = macn;
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            loadDataCustomer();
            txtMaCN.Text = macn;
            dateCMND.Format = DateTimePickerFormat.Custom;
            dateCMND.CustomFormat = "dd/MM/yyyy";
        }

        private void loadDataCustomer()
        {
            // load data gridview
            dgvKhachHang.DataSource = CustomerDAO.Instance.LoadAllCustomers();
            // set data columns
            dgvKhachHang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKhachHang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvKhachHang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKhachHang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            // set header columns
            dgvKhachHang.Columns[0].HeaderText = "Họ và tên";
            dgvKhachHang.Columns[1].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[2].HeaderText = "Số CMND";
            dgvKhachHang.Columns[3].HeaderText = "Ngày cấp";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoten.Text;
            string diaChi = txtDiaChi.Text;
            string cmnd = txtCMND.Text;
            string ngayCap = dateCMND.Text;

            if (hoTen.Length == 0)
            {
                txtError.ForeColor = Color.Red;
                txtError.Text = "Vui lòng nhập họ tên khách hàng";
            }
            else if (diaChi.Length == 0)
            {
                txtError.ForeColor = Color.Red;
                txtError.Text = "Vui lòng nhập địa chỉ khách hàng";
            }
            else if (cmnd.Length == 0)
            {
                txtError.ForeColor = Color.Red;
                txtError.Text = "Vui lòng nhập số CMND khách hàng";
            }
            else if (ngayCap.Length == 0)
            {
                txtError.ForeColor = Color.Red;
                txtError.Text = "Vui lòng chọn ngày cấp CMND";
            }
            else
            {

                if (CustomerDAO.Instance.HaveACustomerByCMND(cmnd))
                {
                    txtError.ForeColor = Color.Red;
                    txtError.Text = "Khách hàng này đã tồn tại";
                }
                else
                {
                    if (CustomerDAO.Instance.AddCustomer(hoTen, diaChi, cmnd, ngayCap, macn))
                    {
                        txtError.ForeColor = Color.Green;
                        clearTextBox();
                        txtError.Text = "Thêm khách hàng " + hoTen + " thành công";
                        loadDataCustomer();

                    }
                    else
                    {
                        txtError.ForeColor = Color.Red;
                        txtError.Text = "Thêm khách hàng " + hoTen + " Thất bại";
                    }
                }
                btnThem.Enabled = true;
                btnClear.Enabled = true;
                btnXoa.Enabled = true;
            }
        }


        private void clearTextBox()
        {
            txtHoten.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            dateCMND.Text = "";
            txtError.Text = "";
            btnThem.Enabled = true;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string cmnd = txtCMND.Text;
            if (cmnd.Length == 0)
            {
                txtError.ForeColor = Color.Red;
                txtError.Text = "Vui lòng nhập số CMND của khách cần xóa";
            }
            else
            {
                if (CustomerDAO.Instance.HaveACustomerByCMND(cmnd))
                {
                    try
                    {
                        var result = MessageBox.Show("Bạn có muốn xóa khách hàng có số CMND là " + cmnd + " hay không?", "Xác minh xóa khách hàng", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            if (CustomerDAO.Instance.RemoveCustomer(cmnd))
                            {
                                txtError.ForeColor = Color.Green;
                                txtError.Text = "Xóa khách hàng thành công";
                                loadDataCustomer();
                                clearTextBox();
                            }
                            else
                            {
                                txtError.ForeColor = Color.Red;
                                txtError.Text = "Xóa khách hàng thất bại";
                            }
                        }
                    }
                    catch (Exception)
                    {
                        txtError.ForeColor = Color.Red;
                        txtError.Text = "Có vẻ như khách hàng này đang có ràng buộc khóa, vui lòng thử lại sau";
                    }


                }
                else
                {
                    txtError.ForeColor = Color.Red;
                    txtError.Text = "Không tồn tại khách hàng này";
                }
            }

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                clearTextBox();
                //txtError.Text = "Đang click dòng " + dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoten.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCMND.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateCMND.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                btnThem.Enabled = false;
                btnClear.Enabled = true;
                btnXoa.Enabled = true;
                btnCapNhat.Enabled = true;
            }
            catch (Exception)
            {
                clearTextBox();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoten.Text;
            string diaChi = txtDiaChi.Text;
            string cmnd = txtCMND.Text;
            string ngayCap = dateCMND.Text;

            if (hoTen.Length == 0)
            {
                txtError.ForeColor = Color.Red;
                txtError.Text = "Vui lòng nhập họ tên khách hàng";
            }
            else if (diaChi.Length == 0)
            {
                txtError.ForeColor = Color.Red;
                txtError.Text = "Vui lòng nhập địa chỉ khách hàng";
            }
            else if (cmnd.Length == 0)
            {
                txtError.ForeColor = Color.Red;
                txtError.Text = "Vui lòng nhập số CMND khách hàng";
            }
            else if (ngayCap.Length == 0)
            {
                txtError.ForeColor = Color.Red;
                txtError.Text = "Vui lòng chọn ngày cấp CMND";
            }
            else
            {
                if (CustomerDAO.Instance.HaveACustomerByCMND(cmnd.TrimEnd()))
                {
                    //try
                    //{
                        var result = MessageBox.Show("Bạn có muốn cập nhât khách hàng có số CMND là " + cmnd + " hay không?", "Xác minh cập nhật khách hàng", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            if (CustomerDAO.Instance.UpdateCustomer(hoTen, diaChi, cmnd, ngayCap))
                            {
                                txtError.ForeColor = Color.Green;
                                clearTextBox();
                                txtError.Text = "Cập nhật khách hàng thành công";
                                loadDataCustomer();
                                
                            }
                            else
                            {
                                txtError.ForeColor = Color.Red;
                                txtError.Text = "Cập nhật khách hàng thất bại";
                            }


                        }
                    //}
                    //catch (Exception)
                    //{
                    //    txtError.ForeColor = Color.Red;
                    //    txtError.Text = "Cập nhật khách hàng thất bại";
                    //}
                }
                else
                {
                    txtError.ForeColor = Color.Red;
                    txtError.Text = "Có vẻ như khách hàng này không tồn tại, xin vui lòng thử lại sau";
                }
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
