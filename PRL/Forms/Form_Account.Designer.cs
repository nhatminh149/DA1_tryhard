namespace PRL.Forms
{
    partial class Form_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Account));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_password = new TextBox();
            tb_username = new TextBox();
            tb_role = new ComboBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dtg_data = new DataGridView();
            btn_lock = new Button();
            btn_them = new Button();
            btn_sua = new Button();
            btn_unlock = new Button();
            cb_showpass = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dtg_data).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 94);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 158);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 2;
            label3.Text = "Role";
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tb_password.Location = new Point(240, 89);
            tb_password.Margin = new Padding(3, 2, 3, 2);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(670, 32);
            tb_password.TabIndex = 3;
            // 
            // tb_username
            // 
            tb_username.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tb_username.Location = new Point(240, 32);
            tb_username.Margin = new Padding(3, 2, 3, 2);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(670, 32);
            tb_username.TabIndex = 4;
            // 
            // tb_role
            // 
            tb_role.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tb_role.FormattingEnabled = true;
            tb_role.Items.AddRange(new object[] { "Tài khoản bị khóa", "Admin", "Nhân viên" });
            tb_role.Location = new Point(240, 152);
            tb_role.Margin = new Padding(3, 2, 3, 2);
            tb_role.Name = "tb_role";
            tb_role.Size = new Size(421, 33);
            tb_role.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // dtg_data
            // 
            dtg_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_data.Location = new Point(3, 280);
            dtg_data.Margin = new Padding(3, 2, 3, 2);
            dtg_data.Name = "dtg_data";
            dtg_data.RowHeadersWidth = 51;
            dtg_data.RowTemplate.Height = 29;
            dtg_data.Size = new Size(1196, 218);
            dtg_data.TabIndex = 6;
            dtg_data.CellClick += dtg_data_CellClick;
            // 
            // btn_lock
            // 
            btn_lock.BackgroundImage = Properties.Resources._1803612;
            btn_lock.BackgroundImageLayout = ImageLayout.Stretch;
            btn_lock.Location = new Point(519, 198);
            btn_lock.Margin = new Padding(3, 2, 3, 2);
            btn_lock.Name = "btn_lock";
            btn_lock.Size = new Size(106, 68);
            btn_lock.TabIndex = 10;
            btn_lock.UseVisualStyleBackColor = true;
            btn_lock.Click += btn_lock_Click;
            // 
            // btn_them
            // 
            btn_them.BackgroundImage = Properties.Resources.tải_xuống__2_;
            btn_them.BackgroundImageLayout = ImageLayout.Stretch;
            btn_them.Location = new Point(96, 198);
            btn_them.Margin = new Padding(3, 2, 3, 2);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(106, 68);
            btn_them.TabIndex = 8;
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.BackgroundImage = Properties.Resources.tải_xuống__1_;
            btn_sua.BackgroundImageLayout = ImageLayout.Stretch;
            btn_sua.Location = new Point(310, 198);
            btn_sua.Margin = new Padding(3, 2, 3, 2);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(106, 68);
            btn_sua.TabIndex = 9;
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_unlock
            // 
            btn_unlock.BackgroundImage = (Image)resources.GetObject("btn_unlock.BackgroundImage");
            btn_unlock.BackgroundImageLayout = ImageLayout.Stretch;
            btn_unlock.Location = new Point(737, 198);
            btn_unlock.Margin = new Padding(3, 2, 3, 2);
            btn_unlock.Name = "btn_unlock";
            btn_unlock.Size = new Size(106, 68);
            btn_unlock.TabIndex = 11;
            btn_unlock.UseVisualStyleBackColor = true;
            btn_unlock.Click += btn_unlock_Click;
            // 
            // cb_showpass
            // 
            cb_showpass.AutoSize = true;
            cb_showpass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cb_showpass.Location = new Point(730, 157);
            cb_showpass.Margin = new Padding(3, 2, 3, 2);
            cb_showpass.Name = "cb_showpass";
            cb_showpass.Size = new Size(166, 25);
            cb_showpass.TabIndex = 12;
            cb_showpass.Text = "Hiển thị mật khẩu";
            cb_showpass.UseVisualStyleBackColor = true;
            cb_showpass.CheckedChanged += cb_showpass_CheckedChanged;
            // 
            // Form_Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 562);
            Controls.Add(cb_showpass);
            Controls.Add(btn_unlock);
            Controls.Add(btn_lock);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(tb_role);
            Controls.Add(dtg_data);
            Controls.Add(tb_username);
            Controls.Add(tb_password);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Account";
            Text = "Form_Account";
            Load += Form_Account_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_password;
        private TextBox tb_username;
        private ComboBox tb_role;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dtg_data;
        private Button btn_lock;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_unlock;
        private CheckBox cb_showpass;
    }
}