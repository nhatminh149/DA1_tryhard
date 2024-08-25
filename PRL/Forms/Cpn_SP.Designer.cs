namespace PRL.Forms
{
    partial class Cpn_SP
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
            ptb_Image = new PictureBox();
            Lb_Ten = new Label();
            lb_Gia = new Label();
            lb_GiaValue = new Label();
            lb_Soluong = new Label();
            lb_SoluongValue = new Label();
            lb_MotaValue = new Label();
            lb_XuatXuValue = new Label();
            btn_Mua = new Button();
            tb_SoluongMua = new TextBox();
            lb_GiaMoi = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            lb_Mota = new Label();
            lb_XuatXu = new Label();
            ((System.ComponentModel.ISupportInitialize)ptb_Image).BeginInit();
            SuspendLayout();
            // 
            // ptb_Image
            // 
            ptb_Image.Location = new Point(1, 2);
            ptb_Image.Name = "ptb_Image";
            ptb_Image.Size = new Size(189, 202);
            ptb_Image.TabIndex = 0;
            ptb_Image.TabStop = false;
            // 
            // Lb_Ten
            // 
            Lb_Ten.AutoSize = true;
            Lb_Ten.Location = new Point(193, 2);
            Lb_Ten.Name = "Lb_Ten";
            Lb_Ten.Size = new Size(69, 20);
            Lb_Ten.TabIndex = 1;
            Lb_Ten.Text = "Giày nike";
            // 
            // lb_Gia
            // 
            lb_Gia.AutoSize = true;
            lb_Gia.Location = new Point(193, 36);
            lb_Gia.Name = "lb_Gia";
            lb_Gia.Size = new Size(60, 20);
            lb_Gia.TabIndex = 2;
            lb_Gia.Text = "Giá bán";
            // 
            // lb_GiaValue
            // 
            lb_GiaValue.AutoSize = true;
            lb_GiaValue.Location = new Point(193, 101);
            lb_GiaValue.Name = "lb_GiaValue";
            lb_GiaValue.Size = new Size(57, 20);
            lb_GiaValue.TabIndex = 3;
            lb_GiaValue.Text = "100000";
            // 
            // lb_Soluong
            // 
            lb_Soluong.AutoSize = true;
            lb_Soluong.Location = new Point(193, 134);
            lb_Soluong.Name = "lb_Soluong";
            lb_Soluong.Size = new Size(69, 20);
            lb_Soluong.TabIndex = 4;
            lb_Soluong.Text = "Số lượng";
            // 
            // lb_SoluongValue
            // 
            lb_SoluongValue.AutoSize = true;
            lb_SoluongValue.Location = new Point(193, 169);
            lb_SoluongValue.Name = "lb_SoluongValue";
            lb_SoluongValue.Size = new Size(57, 20);
            lb_SoluongValue.TabIndex = 5;
            lb_SoluongValue.Text = "100000";
            // 
            // lb_MotaValue
            // 
            lb_MotaValue.AutoSize = true;
            lb_MotaValue.Location = new Point(3, 237);
            lb_MotaValue.Name = "lb_MotaValue";
            lb_MotaValue.Size = new Size(104, 20);
            lb_MotaValue.TabIndex = 5;
            lb_MotaValue.Text = "Bánh mỳ ngon";
            // 
            // lb_XuatXuValue
            // 
            lb_XuatXuValue.AutoSize = true;
            lb_XuatXuValue.Location = new Point(3, 300);
            lb_XuatXuValue.Name = "lb_XuatXuValue";
            lb_XuatXuValue.Size = new Size(131, 20);
            lb_XuatXuValue.TabIndex = 5;
            lb_XuatXuValue.Text = "Sản xuất tại hà nội";
            // 
            // btn_Mua
            // 
            btn_Mua.Location = new Point(234, 248);
            btn_Mua.Name = "btn_Mua";
            btn_Mua.Size = new Size(124, 64);
            btn_Mua.TabIndex = 6;
            btn_Mua.Text = "Mua hàng";
            btn_Mua.UseVisualStyleBackColor = true;
            btn_Mua.Click += btn_Mua_Click;
            // 
            // tb_SoluongMua
            // 
            tb_SoluongMua.Location = new Point(196, 208);
            tb_SoluongMua.Multiline = true;
            tb_SoluongMua.Name = "tb_SoluongMua";
            tb_SoluongMua.PlaceholderText = "Nhập số lượng ";
            tb_SoluongMua.Size = new Size(162, 27);
            tb_SoluongMua.TabIndex = 7;
            // 
            // lb_GiaMoi
            // 
            lb_GiaMoi.AutoSize = true;
            lb_GiaMoi.Location = new Point(193, 68);
            lb_GiaMoi.Name = "lb_GiaMoi";
            lb_GiaMoi.Size = new Size(57, 20);
            lb_GiaMoi.TabIndex = 8;
            lb_GiaMoi.Text = "100000";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // lb_Mota
            // 
            lb_Mota.AutoSize = true;
            lb_Mota.Location = new Point(3, 207);
            lb_Mota.Name = "lb_Mota";
            lb_Mota.Size = new Size(48, 20);
            lb_Mota.TabIndex = 9;
            lb_Mota.Text = "Mô tả";
            // 
            // lb_XuatXu
            // 
            lb_XuatXu.AutoSize = true;
            lb_XuatXu.Location = new Point(3, 269);
            lb_XuatXu.Name = "lb_XuatXu";
            lb_XuatXu.Size = new Size(59, 20);
            lb_XuatXu.TabIndex = 11;
            lb_XuatXu.Text = "Xuất xứ";
            // 
            // Cpn_SP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 350);
            Controls.Add(lb_XuatXu);
            Controls.Add(lb_Mota);
            Controls.Add(lb_GiaMoi);
            Controls.Add(tb_SoluongMua);
            Controls.Add(btn_Mua);
            Controls.Add(lb_XuatXuValue);
            Controls.Add(lb_MotaValue);
            Controls.Add(lb_SoluongValue);
            Controls.Add(lb_Soluong);
            Controls.Add(lb_GiaValue);
            Controls.Add(lb_Gia);
            Controls.Add(Lb_Ten);
            Controls.Add(ptb_Image);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cpn_SP";
            Text = "Cpn_SP";
            Load += Cpn_SP_Load;
            ((System.ComponentModel.ISupportInitialize)ptb_Image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptb_Image;
        private Label Lb_Ten;
        private Label lb_Gia;
        private Label lb_GiaValue;
        private Label lb_Soluong;
        private Label lb_SoluongValue;
        private Label lb_MotaValue;
        private Label lb_XuatXuValue;
        private Button btn_Mua;
        private TextBox tb_SoluongMua;
        private Label lb_GiaMoi;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lb_Mota;
        private Label lb_XuatXu;
    }
}