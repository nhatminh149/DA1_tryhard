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
    public partial class Form_QLSale : Form
    {
        SaleServices _saleServices;
        Guid _selectedSaleId;
        public Form_QLSale()
        {
            _saleServices = new SaleServices();
            InitializeComponent();
        }
        public void LoadAllSale()
        {
            dtg_Data.Rows.Clear();
            var allsale = _saleServices.GetAllSale();
            dtg_Data.ColumnCount = 7;
            dtg_Data.Columns[0].HeaderText = "Mã Sale";
            dtg_Data.Columns[1].HeaderText = "Tên Sale";
            dtg_Data.Columns[2].HeaderText = "Mô tả";
            dtg_Data.Columns[3].HeaderText = "Ngày bắt đầu";
            dtg_Data.Columns[4].HeaderText = "Ngày kết thúc";
            dtg_Data.Columns[5].HeaderText = "Sale(%)";
            dtg_Data.Columns[6].HeaderText = "Trạng thái";
            foreach (var item in allsale)
            {
                dtg_Data.Rows.Add(item.Id, item.Name, item.Description, item.StarDate, item.EndDate, item.Percent, item.Status);
            }
        }

        private void Form_QLSale_Load(object sender, EventArgs e)
        {
            LoadAllSale();
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            Sale sale = new Sale()
            {
                Id = Guid.NewGuid(),
                Name = tb_Ten.Text,
                Description = tb_Mota.Text,
                StarDate = dtp_Start.Value,
                EndDate = dtp_End.Value,
                Percent = Convert.ToDouble(tb_Percent.Text),
                Status = cbb_Trangthai.SelectedIndex
            };
            MessageBox.Show(_saleServices.CreateSale(sale));
            LoadAllSale();
        }

        private void dtg_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_Data.Rows[e.RowIndex];
                _selectedSaleId = Guid.Parse(row.Cells[0].Value.ToString());
                tb_Ten.Text = row.Cells[1].Value.ToString();
                tb_Mota.Text = row.Cells[2].Value.ToString();
                dtp_Start.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                dtp_End.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                tb_Percent.Text = row.Cells[5].Value.ToString();
                cbb_Trangthai.SelectedIndex = Convert.ToInt32(row.Cells[6].Value);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale()
            {
                Id = _selectedSaleId,
                Name = tb_Ten.Text,
                Description = tb_Mota.Text,
                StarDate = dtp_Start.Value,
                EndDate = dtp_End.Value,
                Percent = Convert.ToDouble(tb_Percent.Text),
                Status = cbb_Trangthai.SelectedIndex
            };
            MessageBox.Show(_saleServices.UpdateSale(sale));
            LoadAllSale();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_saleServices.DeleteSale(_selectedSaleId));
            LoadAllSale();
        }
    }
}
