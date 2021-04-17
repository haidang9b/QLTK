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
    public partial class FormStaffs : Form
    {
        private string macn;
        private string quyen;
        public FormStaffs(string macn, string quyen)
        {
            InitializeComponent();
            this.macn = macn;
            this.quyen = quyen;
        }

        private void LoadAllStaffs()
        {
            dgvNhanVien.DataSource = DAO.StaffDAO.Instance.LoadAllStaffs();
            // set size
            dgvNhanVien.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhanVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhanVien.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhanVien.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            // set header
            dgvNhanVien.Columns[0].HeaderText = "Họ và tên";
            dgvNhanVien.Columns[1].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[2].HeaderText = "Mã GDV";
            dgvNhanVien.Columns[3].HeaderText = "Mã CN";
        }

        private void FormStaffs_Load(object sender, EventArgs e)
        {
            LoadAllStaffs();
        }

        private void clearTextBox()
        {
            txtDiaChi.Text = "";
            txtHoten.Text = "";
            txtMaNV.Text = "";
            txtError.Text = "";
            txtError.ForeColor = Color.Red;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = false;
            txtMaNV.ReadOnly = true;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clearTextBox();
                txtHoten.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMaCN.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMaNV.ReadOnly = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
            }
            catch(Exception)
            {
                clearTextBox();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoten.Text;
            string diaChi = txtDiaChi.Text;
            string maCN = macn;
            if (hoTen.Length == 0)
            {
                txtError.ForeColor = Color.Red;
                txtError.Text = "Vui lòng nhập họ tên giao dịch viên";
            }
            else if (diaChi.Length == 0)
            {
                txtError.ForeColor = Color.Red;
                txtError.Text = "Vui lòng nhập địa chỉ giao dịch viên";
            }
            else
            {
                if (StaffDAO.Instance.AddStaff(hoTen, diaChi, macn))
                {
                    txtError.ForeColor = Color.Green;
                    clearTextBox();
                    setSuccess("Thêm giao dịch viên " + hoTen + " thành công");
                    LoadAllStaffs();
                }
                else
                {
                    txtError.ForeColor = Color.Red;
                    txtError.Text = "Thêm giao dịch viên thất bại";
                }
            }



        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maGDV = Int32.Parse(txtMaNV.Text);

            if(txtMaNV.Text.Length > 0)
            {
                if (StaffDAO.Instance.HaveAStaff(maGDV))
                {
                    try
                    {
                        var result = MessageBox.Show("Bạn có muốn xóa Giao dịch viên mã là " + maGDV + " hay không?", "Xác minh xóa giao dịch viên", MessageBoxButtons.YesNo);
                        if(result == DialogResult.Yes)
                        {
                            if (StaffDAO.Instance.RemoveStaff(maGDV))
                            {
                                LoadAllStaffs();
                                clearTextBox();
                                setSuccess("Xóa giao dịch viên có mã là " + maGDV.ToString() + " thành công");
                            }
                        }
                    }
                    catch
                    {
                        setError("Có vẻ như GDV này đang ràng buộc ở chi nhánh khác, hoặc đang ràng buộc khóa");
                    }
                }
                else
                {
                    setError("Giao dịch viên này không tồn tại");
                }
              
            }
            else
            {
                setError("Vui lòng chọn mã Giao dịch viên hợp lệ");
            }
            
        }

        private void setError(string error)
        {
            txtError.ForeColor = Color.Red;
            txtError.Text = error;
        }

        private void setSuccess(string msg)
        {
            txtError.ForeColor = Color.Green;
            txtError.Text = msg;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoten.Text;
            string diaChi = txtDiaChi.Text;
            int maGDV = Int32.Parse(txtMaNV.Text);

            if(hoTen.Length == 0)
            {
                setError("Vui lòng nhập tên Giao dịch viên");
            }
            else if(diaChi.Length == 0)
            {
                setError("Vui lòng nhập địa chỉ Giao dịch viên");
            }
            else if(txtMaNV.Text.Length == 0)
            {
                setError("Vui lòng lựa chọn Giao dịch viên cần cập nhật");
            }
            else
            {
                if (StaffDAO.Instance.HaveAStaff(maGDV))
                {
                    try
                    {
                        if(StaffDAO.Instance.UpdateStaff(hoTen, diaChi, maGDV))
                        {
                            clearTextBox();
                            setSuccess("Cập nhật giao dịch viên có mã GDV " + maGDV + " thành công");
                            LoadAllStaffs();
                        }
                        else
                        {
                            setError("Cập nhật thất bại");
                        }
                    }
                    catch
                    {
                        setError("Giao dịch viên này ở chi nhánh khác");
                    }
                }
                else
                {
                    setError("Mã giao dịch viên này không tồn tại");
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "DanhSachNhanVien";
                for (int i = 1; i < dgvNhanVien.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvNhanVien.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvNhanVien.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvNhanVien.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvNhanVien.Rows[i].Cells[j].Value.ToString();
                    }
                }
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "DanhSachNhanVien";
                saveFileDialog.DefaultExt = ".xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
            }
            catch
            {

            }
            
        }
    }
}
