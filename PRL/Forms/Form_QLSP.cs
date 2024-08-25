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
    public partial class Form_QLSP : Form
    {
        ProductServices _services;
        Guid _selectedProductId;
        SaleServices _saleServices;
        List<Sale> activeSales;
        public Form_QLSP()
        {
            _services = new ProductServices();
            _saleServices = new SaleServices();
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (cbb_SaleActive.SelectedIndex == -1) // Kiểm tra nếu ComboBox không được chọn
            {
                MessageBox.Show("Vui lòng chọn Sale trước khi thêm sản phẩm");
                return;
            }
            Product product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = tb_Ten.Text,
                From = tb_Xuatxu.Text,
                Details = tb_Mota.Text,
                Price = Convert.ToInt32(tb_Giaban.Text),
                TotalAmount = Convert.ToInt32(tb_Soluongcon.Text),
                Status = cbb_Trangthai.SelectedIndex,
                ImgURL = ptb_Image.ImageLocation,
                SaleId = activeSales[cbb_SaleActive.SelectedIndex].Id //Vị trí của sale trong list chính là vị trí của nó trong cbb
            };
            MessageBox.Show(_services.CreateProduct(product));
            LoadDataGridView();
            ClearData();
        }
        public void LoadDataGridView()
        {
            dtg_Data.Rows.Clear();
            var allData = _services.GetAll();
            dtg_Data.ColumnCount = 9;
            dtg_Data.Columns[0].HeaderText = "Mã SP";
            dtg_Data.Columns[1].HeaderText = "Tên SP";
            dtg_Data.Columns[2].HeaderText = "Xuất xứ";
            dtg_Data.Columns[3].HeaderText = "Mô tả";
            dtg_Data.Columns[4].HeaderText = "Giá";
            dtg_Data.Columns[5].HeaderText = "Số lượng";
            dtg_Data.Columns[6].HeaderText = "Trạng thái";
            dtg_Data.Columns[7].HeaderText = "ImgURL";
            dtg_Data.Columns[8].HeaderText = "Mã Sale";

            foreach (var item in allData)
            {
                dtg_Data.Rows.Add( item.Id, item.Name, item.From, item.Details, item.Price, item.TotalAmount, item.Status, item.ImgURL,item.SaleId);
            }
        }

        private void Form_QLSP_Load(object sender, EventArgs e)
        {
            activeSales = _saleServices.GetActiveSale(); //Danh sách các sale đang hoạt động
            foreach(var item in activeSales)
            {
                cbb_SaleActive.Items.Add(item.Name);
            }
            LoadDataGridView();
        }

        private void ptb_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            ptb_Image.ImageLocation = dialog.FileName;
            ptb_Image.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void dtg_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_Data.Rows[e.RowIndex];
                _selectedProductId = Guid.Parse(row.Cells[0].Value.ToString());
                tb_Ten.Text = row.Cells[1].Value.ToString();
                tb_Xuatxu.Text = row.Cells[2].Value.ToString();
                tb_Mota.Text = row.Cells[3].Value.ToString();
                tb_Giaban.Text = row.Cells[4].Value.ToString();
                tb_Soluongcon.Text = row.Cells[5].Value.ToString();
                cbb_Trangthai.SelectedIndex = Convert.ToInt32(row.Cells[6].Value);
                ptb_Image.ImageLocation = row.Cells[7].Value.ToString();
                // Find and select the corresponding sale in the ComboBox
                if (activeSales != null && row.Cells[8].Value != null)
                {
                    var saleId = Guid.Parse(row.Cells[8].Value.ToString());
                    cbb_SaleActive.SelectedIndex = activeSales.FindIndex(s => s.Id == saleId);
                }
                else
                {
                    cbb_SaleActive.SelectedIndex = -1;
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = _selectedProductId,
                Name = tb_Ten.Text,
                From = tb_Xuatxu.Text,
                Details = tb_Mota.Text,
                Price = Convert.ToInt32(tb_Giaban.Text),
                TotalAmount = Convert.ToInt32(tb_Soluongcon.Text),
                Status = cbb_Trangthai.SelectedIndex,
                ImgURL = ptb_Image.ImageLocation
            };
            MessageBox.Show(_services.UpdateProduct(product));
            LoadDataGridView();
            ClearData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_services.DeleteProduct(_selectedProductId));
            LoadDataGridView();
            ClearData();
        }

        private void ClearData()
        {
            tb_Ten.Text = string.Empty;
            tb_Xuatxu.Text = string.Empty;
            tb_Mota.Text = string.Empty;
            tb_Giaban.Text = string.Empty;
            tb_Soluongcon.Text = string.Empty;
            cbb_Trangthai.SelectedIndex = -1; // Hoặc đặt giá trị mặc định
            ptb_Image.ImageLocation = string.Empty;
            ptb_Image.Image = null;
        }
    }
}
