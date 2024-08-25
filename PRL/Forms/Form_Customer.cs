using DAL_BUS.BUS;
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
    public partial class Form_Customer : Form
    {
        CustomerServices _service;
        public Form_Customer()
        {
            _service = new CustomerServices();
            InitializeComponent();
        }
        public void LoadDataToGridView()
        {
            dtg_Data.DataSource = null;
            var allCustomer = _service.GetAll();
            dtg_Data.DataSource = allCustomer;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbt_PhoneNumber.Text) || string.IsNullOrWhiteSpace(tbt_Name.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm khách hàng.");
                return;
            }
            string phoneNumber = tbt_PhoneNumber.Text;
            string name = tbt_Name.Text;
            int point = 0; // Nếu có sử dụng điểm sau này

            string resultMessage = _service.Create(phoneNumber, name, point);
            MessageBox.Show(resultMessage);

            LoadDataToGridView();
            /* ClearFields(); */// Làm trống các trường sau khi thêm
        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbt_PhoneNumber.Text) || string.IsNullOrWhiteSpace(tbt_Name.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi sửa khách hàng.");
                return;
            }
            string phoneNumber = tbt_PhoneNumber.Text;
            string name = tbt_Name.Text;
            int point = 0; // Nếu có sử dụng điểm sau này

            string resultMessage = _service.Update(phoneNumber, name, point);
            MessageBox.Show(resultMessage);

            LoadDataToGridView();
            /* ClearFields(); */// Nếu bạn muốn xóa các trường sau khi sửa
        }

        private void ClearFields()
        {
            tbt_PhoneNumber.Text = string.Empty;
            tbt_Name.Text = string.Empty;
            // Làm trống các trường khác nếu có, ví dụ:
            // cbb_Status.SelectedIndex = -1; // Nếu có ComboBox cần đặt lại
        }

        private void dtg_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_Data.Rows[e.RowIndex];

                // Lấy giá trị từ hàng được chọn và điền vào các trường nhập liệu
                tbt_PhoneNumber.Text = row.Cells[0].Value.ToString();
                tbt_Name.Text = row.Cells[1].Value.ToString();

                // Kiểm tra nếu cột Point có giá trị
                if (row.Cells[2].Value != null)
                {
                    tbt_Point.Text = row.Cells[2].Value.ToString(); // Giả sử có TextBox tbt_Point
                }
                else
                {
                    tbt_Point.Text = "0"; // Nếu không có, đặt về giá trị mặc định
                }

                // Nếu có các trường khác, điền vào đây
                // Ví dụ: cbb_Status.SelectedIndex = Convert.ToInt32(row.Cells["Status"].Value);
            }
        }
    }
}
