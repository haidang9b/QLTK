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
    public partial class FormStatistical : Form
    {
        public FormStatistical()
        {
            InitializeComponent();
        }

        private void FormStatistical_Load(object sender, EventArgs e)
        {
            dateBatDau.Format = DateTimePickerFormat.Custom;
            dateBatDau.CustomFormat = "dd/MM/yyyy";

            dateKetThuc.Format = DateTimePickerFormat.Custom;
            dateKetThuc.CustomFormat = "dd/MM/yyyy";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPhieu.DataSource = null;
                dgvPhieu.Rows.Clear();
                dgvPhieu.Refresh();
                string start = dateBatDau.Text;
                string end = dateKetThuc.Text;
                txtMSG.Text = "Thống kê phiếu gửi " + start + end;
                dgvPhieu.DataSource = PhieuGuiDAO.Instance.LoadPhieuGuiByTime(start, end);

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
            catch
            {

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPhieu.DataSource = null;
                dgvPhieu.Rows.Clear();
                dgvPhieu.Refresh();
                string start = dateBatDau.Text;
                string end = dateKetThuc.Text;
                txtMSG.Text = "Thống kê phiếu rút " + start + end;
                dgvPhieu.DataSource = PhieuRutDAO.Instance.LoadPhieuRutByTime(start, end);
                dgvPhieu.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPhieu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPhieu.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPhieu.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvPhieu.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                dgvPhieu.Columns[0].HeaderText = "Mã Phiếu";
                dgvPhieu.Columns[1].HeaderText = "Ngày rút";
                dgvPhieu.Columns[2].HeaderText = "Tiền lãi";
                dgvPhieu.Columns[3].HeaderText = "Tổng tiền";
                dgvPhieu.Columns[4].HeaderText = "Mã GDV rút";

                dgvPhieu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPhieu.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch
            {

            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string nameCustomize = txtMSG.Text;
                nameCustomize = nameCustomize.Replace('/', ' ');
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "DanhSachPhieu";
                for (int i = 1; i < dgvPhieu.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvPhieu.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvPhieu.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvPhieu.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvPhieu.Rows[i].Cells[j].Value.ToString();
                    }
                }
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = nameCustomize;
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

        //Phieu Rut


    }
}
