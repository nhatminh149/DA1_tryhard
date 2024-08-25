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
    public partial class Form_Login : Form
    {
        AccountServices _accountSevices;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            _accountSevices = new AccountServices();
            string username = txt_username.Text;
            string password = txt_password.Text;
            string accountInfor = _accountSevices.Login(username, password);
            if (string.IsNullOrEmpty(accountInfor))
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
            else if (accountInfor.Split(':')[0] == "0")
            {
                MessageBox.Show("Tài khoản đã bị khóa,kiểm tra xem bị đuổi việc chưa");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn đăng nhập", "Đăng nhập", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    Form_Main main = new Form_Main(accountInfor);
                    main.ShowDialog();
                    main.FormClosed += Main_FormClosed;
                    this.Show();
                }
            }

        }

        private void Main_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void ck_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_showpass.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_closes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_QuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_QuenMK form_QuenMK = new Form_QuenMK();
            form_QuenMK.ShowDialog();
            form_QuenMK.FormClosed += Main_FormClosed;
            this.Show();

        }
    }
}
