namespace PRL.Forms
{
    partial class Form_Login
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
            btn_login = new Button();
            ck_showpass = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            pictureBox1 = new PictureBox();
            lb_QuenMK = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.Location = new Point(897, 281);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(130, 50);
            btn_login.TabIndex = 13;
            btn_login.Text = "Đăng Nhập";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // ck_showpass
            // 
            ck_showpass.AutoSize = true;
            ck_showpass.Location = new Point(717, 267);
            ck_showpass.Name = "ck_showpass";
            ck_showpass.Size = new Size(148, 24);
            ck_showpass.TabIndex = 12;
            ck_showpass.Text = "Hiển thị mật khẩu";
            ck_showpass.UseVisualStyleBackColor = true;
            ck_showpass.CheckedChanged += ck_showpass_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(808, 67);
            label3.Name = "label3";
            label3.Size = new Size(110, 46);
            label3.TabIndex = 10;
            label3.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(555, 223);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 11;
            label2.Text = "Mật Khẩu :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(555, 168);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 9;
            label1.Text = "Tài Khoản :";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(717, 168);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Username...";
            txt_username.Size = new Size(310, 27);
            txt_username.TabIndex = 14;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(717, 223);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.PlaceholderText = "Password...";
            txt_password.Size = new Size(310, 27);
            txt_password.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.hero11;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-1, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(672, 461);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // lb_QuenMK
            // 
            lb_QuenMK.AutoSize = true;
            lb_QuenMK.Location = new Point(717, 310);
            lb_QuenMK.Name = "lb_QuenMK";
            lb_QuenMK.Size = new Size(125, 20);
            lb_QuenMK.TabIndex = 18;
            lb_QuenMK.TabStop = true;
            lb_QuenMK.Text = "Forgot Password?";
            lb_QuenMK.LinkClicked += lb_QuenMK_LinkClicked;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1079, 450);
            Controls.Add(lb_QuenMK);
            Controls.Add(pictureBox1);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(btn_login);
            Controls.Add(ck_showpass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Login";
            Load += Form_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private CheckBox ck_showpass;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_username;
        private TextBox txt_password;
        private PictureBox pictureBox1;
        private LinkLabel lb_QuenMK;
    }
}