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
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
        }

        private void FormService_Load(object sender, EventArgs e)
        {
            LoadAllDVLS();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            List<Service> services = ServiceDAO.Instance.LoadAllService();
            cbxMaDV.DataSource = services;
            cbxMaDV.DisplayMember = "MADV";
        }

        private void LoadAllDVLS()
        {

            dgvPhieu.DataSource = DichvuLaisuatDAO.Instance.LoadAllDVLS();
            dgvPhieu.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPhieu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPhieu.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPhieu.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPhieu.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvPhieu.Columns[0].HeaderText = "Mã dịch vụ";
            dgvPhieu.Columns[1].HeaderText = "Kỳ hạn";
            dgvPhieu.Columns[2].HeaderText = "Tên dịch vụ";
            dgvPhieu.Columns[3].HeaderText = "Ngày áp dụng";
            dgvPhieu.Columns[4].HeaderText = "Lãi suất";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var isNumeric = float.TryParse(txtLaiSuat.Text, out float n);
            if (txtLaiSuat.Text.Length == 0)
            {
                setError("Vui lòng nhập lãi suất");
            }
            else if(isNumeric == false)
            {
                setError("Lãi suất không hợp lệ");
            }
            else
            {
                
                try
                {
                    double laiSuat = Convert.ToDouble(txtLaiSuat.Text);
                    string ngayAD = DateTime.Now.ToString("dd/MM/yyyy");
                    string maDV = cbxMaDV.Text;
                    if (DichvuLaisuatDAO.Instance.InsertLaiSuat(maDV, ngayAD, laiSuat))
                    {
                        txtLaiSuat.Text = "";
                        LoadAllDVLS();
                        setSuccess("Cập nhật thành công");
                    }
                }
                catch
                {
                    setError("Có vẻ như đã cập nhật hôm nay rồi");
                }

            }
        }
        private void setSuccess(string msg)
        {
            txtError.Text = msg;
            txtError.ForeColor = Color.Green;

        }
        private void setError(string msg)
        {
            txtError.Text = msg;
            txtError.ForeColor = Color.Red;
        
        }
        private void cbxMaDV_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cbxMaDV.SelectedItem == null)
            {
                return;
            }
            Service selected = cbxMaDV.SelectedItem as Service;
            try
            {
                txtTenDV.Text = selected.TenDV;
                txtThangKy.Text = selected.KyHan.ToString();
            }
            catch
            {

            }
        }
    }
}
