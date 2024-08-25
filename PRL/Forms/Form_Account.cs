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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PRL.Forms
{
    public partial class Form_Account : Form
    {
        AccountServices _services;
        public Form_Account()
        {
            _services = new AccountServices();
            InitializeComponent();
            dtg_data.CellFormatting += Dtg_data_CellFormatting;
        }

        private void Dtg_data_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtg_data.Columns[e.ColumnIndex].Name == "Password" && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            int role = tb_role.SelectedIndex;// selectedindex mặc định là -1
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || role == -1)
            {
                MessageBox.Show("Dữ liệu sai,Kiểm tra lại");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thêm mới", "Thêm mới", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string message = _services.CreateAccount(username, password, role);
                    MessageBox.Show(message);
                    LoadDataGridView();
                }
            }
        }

        private void Form_Account_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            dtg_data.DataSource = null;
            var data = _services.GetAll();
            dtg_data.DataSource = data;
        }

        private void dtg_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_password.PasswordChar = '*';
            DataGridViewRow row = dtg_data.Rows[e.RowIndex];
            tb_username.Text = row.Cells[0].Value.ToString();
            tb_password.Text = row.Cells[1].Value.ToString();
            tb_role.SelectedIndex = Convert.ToInt32(row.Cells[2].Value);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            int role = tb_role.SelectedIndex;// selectedindex mặc định là -1
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || role == -1)
            {
                MessageBox.Show("Dữ liệu sai,Kiểm tra lại");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn sửa chứ", "Sửa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string message = _services.UpdateAccount(username, password, role);
                    MessageBox.Show(message);
                    LoadDataGridView();
                }
            }
        }

        private void btn_lock_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            DialogResult result = MessageBox.Show("Bạn muốn khóa tài khoản chứ", "Lock", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string message = _services.LockAccount(username);
                MessageBox.Show(message);
                LoadDataGridView();
            }

        }

        private void btn_unlock_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            DialogResult result = MessageBox.Show("Bạn muốn mở khóa tài khoản chứ", "Unlock", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string message = _services.UnLockAccount(username);
                MessageBox.Show(message);
                LoadDataGridView();
            }

        }

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked)
            {
                tb_password.PasswordChar = '\0';
            }
            else
            {
                tb_password.PasswordChar = '*';
            }
        }
    }
}
