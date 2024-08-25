namespace PRL
{
    partial class Form_QuenMK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_sendCode = new Button();
            btn_back = new Button();
            tbt_checkpass = new TextBox();
            tbt_passwordmoi = new TextBox();
            btn_XacNhan = new Button();
            label1 = new Label();
            lb_messageUser = new Label();
            lb_messConfirm = new Label();
            tbt_usernameback = new TextBox();
            lb_messagePass = new Label();
            SuspendLayout();
            // 
            // btn_sendCode
            // 
            btn_sendCode.Location = new Point(521, 139);
            btn_sendCode.Name = "btn_sendCode";
            btn_sendCode.Size = new Size(88, 29);
            btn_sendCode.TabIndex = 68;
            btn_sendCode.Text = "Gửi mã";
            btn_sendCode.UseVisualStyleBackColor = true;
            btn_sendCode.Click += btn_sendCode_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(315, 383);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 67;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // tbt_checkpass
            // 
            tbt_checkpass.Location = new Point(192, 293);
            tbt_checkpass.Name = "tbt_checkpass";
            tbt_checkpass.PlaceholderText = "ConfirmPassword";
            tbt_checkpass.Size = new Size(323, 27);
            tbt_checkpass.TabIndex = 64;
            // 
            // tbt_passwordmoi
            // 
            tbt_passwordmoi.Location = new Point(192, 213);
            tbt_passwordmoi.Name = "tbt_passwordmoi";
            tbt_passwordmoi.PlaceholderText = "Password...";
            tbt_passwordmoi.Size = new Size(323, 27);
            tbt_passwordmoi.TabIndex = 65;
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.BackColor = Color.Red;
            btn_XacNhan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_XacNhan.ForeColor = Color.White;
            btn_XacNhan.Location = new Point(274, 336);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new Size(171, 41);
            btn_XacNhan.TabIndex = 66;
            btn_XacNhan.Text = "Xác Nhận";
            btn_XacNhan.UseVisualStyleBackColor = false;
            btn_XacNhan.Click += btn_XacNhan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(241, 49);
            label1.Name = "label1";
            label1.Size = new Size(269, 46);
            label1.TabIndex = 59;
            label1.Text = "Quên Mật Khẩu";
            // 
            // lb_messageUser
            // 
            lb_messageUser.AutoSize = true;
            lb_messageUser.Location = new Point(192, 107);
            lb_messageUser.Name = "lb_messageUser";
            lb_messageUser.Size = new Size(110, 20);
            lb_messageUser.TabIndex = 60;
            lb_messageUser.Text = "Nhập tài khoản";
            // 
            // lb_messConfirm
            // 
            lb_messConfirm.AutoSize = true;
            lb_messConfirm.Location = new Point(192, 261);
            lb_messConfirm.Name = "lb_messConfirm";
            lb_messConfirm.Size = new Size(160, 20);
            lb_messConfirm.TabIndex = 61;
            lb_messConfirm.Text = "Nhập lại mật khẩu mới";
            // 
            // tbt_usernameback
            // 
            tbt_usernameback.Location = new Point(192, 139);
            tbt_usernameback.Name = "tbt_usernameback";
            tbt_usernameback.PlaceholderText = "Username...";
            tbt_usernameback.Size = new Size(323, 27);
            tbt_usernameback.TabIndex = 63;
            // 
            // lb_messagePass
            // 
            lb_messagePass.AutoSize = true;
            lb_messagePass.Location = new Point(192, 181);
            lb_messagePass.Name = "lb_messagePass";
            lb_messagePass.Size = new Size(140, 20);
            lb_messagePass.TabIndex = 62;
            lb_messagePass.Text = "Nhập mật khẩu mới";
            // 
            // Form_QuenMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_sendCode);
            Controls.Add(btn_back);
            Controls.Add(tbt_checkpass);
            Controls.Add(tbt_passwordmoi);
            Controls.Add(btn_XacNhan);
            Controls.Add(label1);
            Controls.Add(lb_messageUser);
            Controls.Add(lb_messConfirm);
            Controls.Add(tbt_usernameback);
            Controls.Add(lb_messagePass);
            Name = "Form_QuenMK";
            Text = "Form_QuenMK";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_sendCode;
        private Button btn_back;
        private TextBox tbt_checkpass;
        private TextBox tbt_passwordmoi;
        private Button btn_XacNhan;
        private Label label1;
        private Label lb_messageUser;
        private Label lb_messConfirm;
        private TextBox tbt_usernameback;
        private Label lb_messagePass;
    }
}