using DAL_BUS.BUS;
using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class Form_Voucher : Form
    {
        VoucherServices _voucherServices;
        public Form_Voucher()
        {
            _voucherServices = new VoucherServices();
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Voucher voucher = new Voucher()
            {
                Id = tbt_MaVoucher.Text,
                Name = tbt_Ten.Text,
                Description = tbt_Mota.Text,
                StarDate = dtp_Start.Value,
                EndDate = dtp_End.Value,
                Value = Convert.ToInt64(tbt_MoneyDown.Text),
                Status = cbb_Status.SelectedIndex
            };
            MessageBox.Show(_voucherServices.CreateVoucher(voucher));
            LoadAllVoucher();
        }

        public void LoadAllVoucher()
        {
            dtg_Data.Rows.Clear();
            var allsale = _voucherServices.GetAllVoucher();
            dtg_Data.ColumnCount = 7;
            dtg_Data.Columns[0].HeaderText = "Mã Sale";
            dtg_Data.Columns[1].HeaderText = "Tên Sale";
            dtg_Data.Columns[2].HeaderText = "Mô tả";
            dtg_Data.Columns[3].HeaderText = "Ngày bắt đầu";
            dtg_Data.Columns[4].HeaderText = "Ngày kết thúc";
            dtg_Data.Columns[5].HeaderText = "Giảm";
            dtg_Data.Columns[6].HeaderText = "Trạng thái";
            foreach (var item in allsale)
            {
                dtg_Data.Rows.Add(item.Id, item.Name, item.Description, item.StarDate, item.EndDate, item.Value, item.Status);
            }
        }
        private void Form_Voucher_Load(object sender, EventArgs e)
        {
            LoadAllVoucher();
        }

        private void dtg_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_Data.Rows[e.RowIndex];
                tbt_MaVoucher.Text = row.Cells[0].Value.ToString();
                tbt_Ten.Text = row.Cells[1].Value.ToString();
                tbt_Mota.Text = row.Cells[2].Value.ToString();
                dtp_Start.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                dtp_End.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                tbt_MoneyDown.Text = row.Cells[5].Value.ToString();
                cbb_Status.SelectedIndex = Convert.ToInt32(row.Cells[6].Value);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbt_MaVoucher.Text))
            {
                MessageBox.Show("Vui lòng chọn một khuyến mãi để cập nhật.");
                return;
            }
            Voucher voucher = new Voucher()
            {
                Id = tbt_MaVoucher.Text,  // Sử dụng Id được chọn để cập nhật
                Name = tbt_Ten.Text,
                Description = tbt_Mota.Text,
                StarDate = dtp_Start.Value,
                EndDate = dtp_End.Value,
                Value = Convert.ToInt64(tbt_MoneyDown.Text),
                Status = cbb_Status.SelectedIndex
            };
            MessageBox.Show(_voucherServices.UpdateVoucher(voucher));
            LoadAllVoucher();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbt_MaVoucher.Text))
            {
                MessageBox.Show(_voucherServices.DeleteVoucher(tbt_MaVoucher.Text));  // Sử dụng Id để xóa
                LoadAllVoucher();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khuyến mãi để xóa.");
            }
        }
    }
}
