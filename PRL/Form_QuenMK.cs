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

namespace PRL
{
    public partial class Form_QuenMK : Form
    {
        public Form_QuenMK()
        {
            InitializeComponent();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {

            string username = tbt_usernameback.Text.Trim();
            string newPassword = tbt_passwordmoi.Text.Trim();
            string confirmPassword = tbt_checkpass.Text.Trim();

            lb_messageUser.ForeColor = Color.Black;
            lb_messagePass.ForeColor = Color.Black;
            lb_messConfirm.ForeColor = Color.Black;

            // Kiểm tra các trường hợp rỗng
            if (string.IsNullOrEmpty(username))
            {
                lb_messageUser.Text = "Vui lòng nhập tên đăng nhập.";
                lb_messageUser.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrEmpty(newPassword))
            {
                lb_messagePass.Text = "Vui lòng nhập mật khẩu mới.";

                lb_messagePass.ForeColor = Color.Red;

                return;
            }
            if (string.IsNullOrEmpty(confirmPassword))
            {
                lb_messConfirm.Text = "Vui lòng xác nhận mật khẩu.";
                lb_messConfirm.ForeColor = Color.Red;

                return;
            }

            // Kiểm tra mật khẩu mới và xác nhận mật khẩu
            if (newPassword != confirmPassword)
            {
                lb_messConfirm.Text = "Mật khẩu xác nhận không khớp.";
                lb_messConfirm.ForeColor = Color.Red;
                return;
            }

            AccountServices accountServices = new AccountServices();

            // Xác nhận tài khoản tồn tại
            string validation = accountServices.ValidateAccount(username);
            if (validation != "Tài khoản tồn tại. Bạn có thể đổi mật khẩu.")
            {
                lb_messageUser.Text = validation;
                lb_messageUser.ForeColor = Color.Red;
                return;
            }

            // Đổi mật khẩu
            string changePasswordMessage = accountServices.ChangePassword(username, newPassword);
            MessageBox.Show(changePasswordMessage);
        }

        private void btn_sendCode_Click(object sender, EventArgs e)
        {

            string username = tbt_usernameback.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                lb_messageUser.Text = "Vui lòng nhập tên đăng nhập.";
                lb_messageUser.ForeColor = Color.Red;
                return;
            }

            AccountServices accountServices = new AccountServices();

            // Kiểm tra tài khoản có tồn tại hay không
            string validationMessage = accountServices.ValidateAccount(username);
            if (validationMessage == "Tài khoản tồn tại. Bạn có thể đổi mật khẩu.")
            {
                lb_messageUser.Text = "Tài khoản tồn tại. Mã xác nhận đã được gửi!";
                lb_messageUser.ForeColor = Color.Red;
            }
            else
            {
                lb_messageUser.Text = validationMessage;
                lb_messageUser.ForeColor = Color.Red;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
