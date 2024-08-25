namespace PRL.Forms
{
    partial class Form_Main
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
            pn_control = new Panel();
            btn_QLVoucher = new Button();
            btn_QLKhach = new Button();
            btn_thongke = new Button();
            btn_QLSale = new Button();
            btn_banhang = new Button();
            btn_ThanhToan = new Button();
            btn_QLNV = new Button();
            btn_QLSP = new Button();
            pn_Main = new Panel();
            lb_Account = new Label();
            pn_control.SuspendLayout();
            SuspendLayout();
            // 
            // pn_control
            // 
            pn_control.Controls.Add(btn_QLVoucher);
            pn_control.Controls.Add(btn_QLKhach);
            pn_control.Controls.Add(btn_thongke);
            pn_control.Controls.Add(btn_QLSale);
            pn_control.Controls.Add(btn_banhang);
            pn_control.Controls.Add(btn_ThanhToan);
            pn_control.Controls.Add(btn_QLNV);
            pn_control.Controls.Add(btn_QLSP);
            pn_control.Location = new Point(12, 12);
            pn_control.Name = "pn_control";
            pn_control.Size = new Size(182, 585);
            pn_control.TabIndex = 10;
            // 
            // btn_QLVoucher
            // 
            btn_QLVoucher.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_QLVoucher.Location = new Point(9, 380);
            btn_QLVoucher.Name = "btn_QLVoucher";
            btn_QLVoucher.Size = new Size(167, 53);
            btn_QLVoucher.TabIndex = 19;
            btn_QLVoucher.Text = "Quản lý Voucher";
            btn_QLVoucher.UseVisualStyleBackColor = true;
            btn_QLVoucher.Click += btn_QLVoucher_Click;
            // 
            // btn_QLKhach
            // 
            btn_QLKhach.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_QLKhach.Location = new Point(9, 326);
            btn_QLKhach.Name = "btn_QLKhach";
            btn_QLKhach.Size = new Size(167, 53);
            btn_QLKhach.TabIndex = 18;
            btn_QLKhach.Text = "Quản lý khách";
            btn_QLKhach.UseVisualStyleBackColor = true;
            btn_QLKhach.Click += btn_QLKhach_Click;
            // 
            // btn_thongke
            // 
            btn_thongke.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_thongke.Location = new Point(9, 218);
            btn_thongke.Name = "btn_thongke";
            btn_thongke.Size = new Size(167, 53);
            btn_thongke.TabIndex = 6;
            btn_thongke.Text = "Thống kê";
            btn_thongke.UseVisualStyleBackColor = true;
            // 
            // btn_QLSale
            // 
            btn_QLSale.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_QLSale.Location = new Point(9, 272);
            btn_QLSale.Name = "btn_QLSale";
            btn_QLSale.Size = new Size(167, 53);
            btn_QLSale.TabIndex = 5;
            btn_QLSale.Text = "Quản lý Sale";
            btn_QLSale.UseVisualStyleBackColor = true;
            btn_QLSale.Click += btn_sale_Click;
            // 
            // btn_banhang
            // 
            btn_banhang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_banhang.Location = new Point(9, 57);
            btn_banhang.Name = "btn_banhang";
            btn_banhang.Size = new Size(167, 53);
            btn_banhang.TabIndex = 4;
            btn_banhang.Text = "Bán hàng";
            btn_banhang.UseVisualStyleBackColor = true;
            btn_banhang.Click += btn_banhang_Click;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ThanhToan.ForeColor = SystemColors.ControlText;
            btn_ThanhToan.Location = new Point(9, 3);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(167, 53);
            btn_ThanhToan.TabIndex = 3;
            btn_ThanhToan.Text = "Thanh toán";
            btn_ThanhToan.UseVisualStyleBackColor = true;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // btn_QLNV
            // 
            btn_QLNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_QLNV.Location = new Point(9, 165);
            btn_QLNV.Name = "btn_QLNV";
            btn_QLNV.Size = new Size(167, 53);
            btn_QLNV.TabIndex = 2;
            btn_QLNV.Text = "Quản Lý Nhân Viên";
            btn_QLNV.UseVisualStyleBackColor = true;
            btn_QLNV.Click += btn_qlnv_Click;
            // 
            // btn_QLSP
            // 
            btn_QLSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_QLSP.Location = new Point(9, 111);
            btn_QLSP.Name = "btn_QLSP";
            btn_QLSP.Size = new Size(167, 53);
            btn_QLSP.TabIndex = 1;
            btn_QLSP.Text = "Quản lý Sản Phẩm";
            btn_QLSP.UseVisualStyleBackColor = true;
            btn_QLSP.Click += btn_QLSP_Click;
            // 
            // pn_Main
            // 
            pn_Main.BackColor = SystemColors.Info;
            pn_Main.Location = new Point(200, 12);
            pn_Main.Name = "pn_Main";
            pn_Main.Size = new Size(1500, 750);
            pn_Main.TabIndex = 17;
            // 
            // lb_Account
            // 
            lb_Account.AutoSize = true;
            lb_Account.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Account.Location = new Point(31, 734);
            lb_Account.Name = "lb_Account";
            lb_Account.Size = new Size(27, 28);
            lb_Account.TabIndex = 7;
            lb_Account.Text = "...";
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1705, 777);
            Controls.Add(lb_Account);
            Controls.Add(pn_Main);
            Controls.Add(pn_control);
            Name = "Form_Main";
            Load += Form_Main_Load;
            pn_control.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pn_control;
        private Button btn_QLNV;
        private Button btn_QLSP;
        private Panel pn_Main;
        private Button btn_thongke;
        private Button btn_QLSale;
        private Button btn_banhang;
        private Button btn_ThanhToan;
        private Label lb_Account;
        private Button btn_QLKhach;
        private Button btn_QLVoucher;
    }
}