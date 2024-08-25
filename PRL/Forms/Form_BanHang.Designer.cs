namespace PRL.Forms
{
    partial class Form_BanHang
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
            lb_Back = new Label();
            lb_Next = new Label();
            tbpl_Sanpham = new TableLayoutPanel();
            btn_TinhTien = new Button();
            btn_CreateBill = new Button();
            tbt_Phone = new TextBox();
            dtg_HDCT = new DataGridView();
            lb_money = new Label();
            lb_MaHD = new Label();
            cbb_Voucher = new ComboBox();
            cbb_Phone = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtg_HD = new DataGridView();
            label6 = new Label();
            lb_Page = new Label();
            lbNext = new Label();
            lbBack = new Label();
            tbt_Name = new Label();
            btn_ThanhToan = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_HDCT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_HD).BeginInit();
            SuspendLayout();
            // 
            // lb_Back
            // 
            lb_Back.AutoSize = true;
            lb_Back.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_Back.Location = new Point(439, 738);
            lb_Back.Name = "lb_Back";
            lb_Back.Size = new Size(54, 28);
            lb_Back.TabIndex = 24;
            lb_Back.Text = "<<<";
            // 
            // lb_Next
            // 
            lb_Next.AutoSize = true;
            lb_Next.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_Next.Location = new Point(623, 738);
            lb_Next.Name = "lb_Next";
            lb_Next.Size = new Size(54, 28);
            lb_Next.TabIndex = 25;
            lb_Next.Text = ">>>";
            // 
            // tbpl_Sanpham
            // 
            tbpl_Sanpham.BackColor = SystemColors.Control;
            tbpl_Sanpham.ColumnCount = 2;
            tbpl_Sanpham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbpl_Sanpham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbpl_Sanpham.Location = new Point(4, 4);
            tbpl_Sanpham.Name = "tbpl_Sanpham";
            tbpl_Sanpham.RowCount = 2;
            tbpl_Sanpham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbpl_Sanpham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbpl_Sanpham.Size = new Size(760, 700);
            tbpl_Sanpham.TabIndex = 23;
            // 
            // btn_TinhTien
            // 
            btn_TinhTien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_TinhTien.Location = new Point(1225, 415);
            btn_TinhTien.Name = "btn_TinhTien";
            btn_TinhTien.Size = new Size(263, 58);
            btn_TinhTien.TabIndex = 42;
            btn_TinhTien.Text = "Tính Tiền";
            btn_TinhTien.UseVisualStyleBackColor = true;
            btn_TinhTien.Click += btn_TinhTien_Click;
            // 
            // btn_CreateBill
            // 
            btn_CreateBill.BackColor = Color.White;
            btn_CreateBill.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CreateBill.Location = new Point(1114, 156);
            btn_CreateBill.Name = "btn_CreateBill";
            btn_CreateBill.Size = new Size(169, 65);
            btn_CreateBill.TabIndex = 41;
            btn_CreateBill.Text = "Tạo hóa đơn";
            btn_CreateBill.UseVisualStyleBackColor = false;
            btn_CreateBill.Click += btn_CreateBill_Click;
            // 
            // tbt_Phone
            // 
            tbt_Phone.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbt_Phone.Location = new Point(943, 37);
            tbt_Phone.Name = "tbt_Phone";
            tbt_Phone.PlaceholderText = "Nhập SDT";
            tbt_Phone.Size = new Size(223, 31);
            tbt_Phone.TabIndex = 39;
            tbt_Phone.TextChanged += tbt_Phone_TextChanged;
            // 
            // dtg_HDCT
            // 
            dtg_HDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HDCT.Location = new Point(770, 479);
            dtg_HDCT.Name = "dtg_HDCT";
            dtg_HDCT.RowHeadersWidth = 51;
            dtg_HDCT.RowTemplate.Height = 29;
            dtg_HDCT.Size = new Size(718, 256);
            dtg_HDCT.TabIndex = 38;
            // 
            // lb_money
            // 
            lb_money.AutoSize = true;
            lb_money.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_money.Location = new Point(943, 156);
            lb_money.Name = "lb_money";
            lb_money.Size = new Size(27, 25);
            lb_money.TabIndex = 37;
            lb_money.Text = "...";
            // 
            // lb_MaHD
            // 
            lb_MaHD.AutoSize = true;
            lb_MaHD.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_MaHD.Location = new Point(943, 6);
            lb_MaHD.Name = "lb_MaHD";
            lb_MaHD.Size = new Size(27, 25);
            lb_MaHD.TabIndex = 36;
            lb_MaHD.Text = "...";
            // 
            // cbb_Voucher
            // 
            cbb_Voucher.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cbb_Voucher.FormattingEnabled = true;
            cbb_Voucher.Location = new Point(943, 114);
            cbb_Voucher.Name = "cbb_Voucher";
            cbb_Voucher.Size = new Size(548, 33);
            cbb_Voucher.TabIndex = 35;
            // 
            // cbb_Phone
            // 
            cbb_Phone.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cbb_Phone.FormattingEnabled = true;
            cbb_Phone.Location = new Point(1200, 35);
            cbb_Phone.Name = "cbb_Phone";
            cbb_Phone.Size = new Size(291, 33);
            cbb_Phone.TabIndex = 34;
            cbb_Phone.TextChanged += cbb_Phone_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(776, 156);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 32;
            label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(776, 117);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 33;
            label3.Text = "Voucher";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(776, 80);
            label5.Name = "label5";
            label5.Size = new Size(140, 25);
            label5.TabIndex = 29;
            label5.Text = "Tên Khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(775, 43);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 30;
            label2.Text = "SDT Khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(776, 6);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 28;
            label1.Text = "Mã Hóa đơn";
            // 
            // dtg_HD
            // 
            dtg_HD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HD.Location = new Point(767, 227);
            dtg_HD.Name = "dtg_HD";
            dtg_HD.RowHeadersWidth = 51;
            dtg_HD.RowTemplate.Height = 29;
            dtg_HD.Size = new Size(721, 182);
            dtg_HD.TabIndex = 27;
            dtg_HD.CellClick += dtg_HD_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(770, 448);
            label6.Name = "label6";
            label6.Size = new Size(307, 25);
            label6.TabIndex = 31;
            label6.Text = "Danh sách sản phẩm trong Hóa đơn";
            // 
            // lb_Page
            // 
            lb_Page.AutoSize = true;
            lb_Page.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_Page.Location = new Point(374, 707);
            lb_Page.Name = "lb_Page";
            lb_Page.Size = new Size(20, 28);
            lb_Page.TabIndex = 45;
            lb_Page.Text = "1";
            // 
            // lbNext
            // 
            lbNext.AutoSize = true;
            lbNext.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbNext.Location = new Point(456, 707);
            lbNext.Name = "lbNext";
            lbNext.Size = new Size(54, 28);
            lbNext.TabIndex = 44;
            lbNext.Text = ">>>";
            lbNext.Click += lbNext_Click;
            // 
            // lbBack
            // 
            lbBack.AutoSize = true;
            lbBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbBack.Location = new Point(248, 707);
            lbBack.Name = "lbBack";
            lbBack.Size = new Size(54, 28);
            lbBack.TabIndex = 43;
            lbBack.Text = "<<<";
            lbBack.Click += lbBack_Click;
            // 
            // tbt_Name
            // 
            tbt_Name.AutoSize = true;
            tbt_Name.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbt_Name.Location = new Point(943, 84);
            tbt_Name.Name = "tbt_Name";
            tbt_Name.Size = new Size(25, 23);
            tbt_Name.TabIndex = 46;
            tbt_Name.Text = "...";
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ThanhToan.Location = new Point(1289, 156);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(199, 65);
            btn_ThanhToan.TabIndex = 47;
            btn_ThanhToan.Text = "Thanh Toán";
            btn_ThanhToan.UseVisualStyleBackColor = true;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // Form_BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 750);
            Controls.Add(btn_ThanhToan);
            Controls.Add(tbt_Name);
            Controls.Add(lb_Page);
            Controls.Add(lbNext);
            Controls.Add(lbBack);
            Controls.Add(btn_TinhTien);
            Controls.Add(btn_CreateBill);
            Controls.Add(tbt_Phone);
            Controls.Add(dtg_HDCT);
            Controls.Add(lb_money);
            Controls.Add(lb_MaHD);
            Controls.Add(cbb_Voucher);
            Controls.Add(cbb_Phone);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtg_HD);
            Controls.Add(lb_Back);
            Controls.Add(lb_Next);
            Controls.Add(tbpl_Sanpham);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_BanHang";
            Text = "Form_BanHang";
            Load += Form_BanHang_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_HDCT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_HD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Back;
        private Label lb_Next;
        private TableLayoutPanel tbpl_Sanpham;
        private Button btn_TinhTien;
        private Button btn_CreateBill;
        private TextBox tbt_Phone;
        private DataGridView dtg_HDCT;
        private Label lb_money;
        private Label lb_MaHD;
        private ComboBox cbb_Voucher;
        private ComboBox cbb_Phone;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label1;
        private DataGridView dtg_HD;
        private Label label6;
        private Label lb_Page;
        private Label lbNext;
        private Label lbBack;
        private Label tbt_Name;
        private Button btn_ThanhToan;
    }
}