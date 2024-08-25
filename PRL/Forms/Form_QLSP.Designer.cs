namespace PRL.Forms
{
    partial class Form_QLSP
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
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            dtg_Data = new DataGridView();
            cbb_Trangthai = new ComboBox();
            tb_Mota = new TextBox();
            tb_Ten = new TextBox();
            tb_Giaban = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ptb_Image = new PictureBox();
            tb_Xuatxu = new TextBox();
            tb_Soluongcon = new TextBox();
            label7 = new Label();
            cbb_SaleActive = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtg_Data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Image).BeginInit();
            SuspendLayout();
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(964, 372);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(275, 77);
            btn_Them.TabIndex = 31;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(964, 474);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(275, 77);
            btn_Sua.TabIndex = 30;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(964, 576);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(275, 77);
            btn_Xoa.TabIndex = 29;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // dtg_Data
            // 
            dtg_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Data.Location = new Point(9, 379);
            dtg_Data.Name = "dtg_Data";
            dtg_Data.RowHeadersWidth = 51;
            dtg_Data.RowTemplate.Height = 29;
            dtg_Data.Size = new Size(825, 281);
            dtg_Data.TabIndex = 28;
            dtg_Data.CellClick += dtg_Data_CellClick;
            // 
            // cbb_Trangthai
            // 
            cbb_Trangthai.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_Trangthai.FormattingEnabled = true;
            cbb_Trangthai.Items.AddRange(new object[] { "Không hoạt động", "Hoạt động" });
            cbb_Trangthai.Location = new Point(270, 330);
            cbb_Trangthai.Name = "cbb_Trangthai";
            cbb_Trangthai.Size = new Size(151, 27);
            cbb_Trangthai.TabIndex = 27;
            // 
            // tb_Mota
            // 
            tb_Mota.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Mota.Location = new Point(270, 90);
            tb_Mota.Name = "tb_Mota";
            tb_Mota.Size = new Size(567, 27);
            tb_Mota.TabIndex = 24;
            // 
            // tb_Ten
            // 
            tb_Ten.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Ten.Location = new Point(270, 30);
            tb_Ten.Name = "tb_Ten";
            tb_Ten.Size = new Size(567, 27);
            tb_Ten.TabIndex = 23;
            // 
            // tb_Giaban
            // 
            tb_Giaban.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Giaban.Location = new Point(270, 270);
            tb_Giaban.Name = "tb_Giaban";
            tb_Giaban.Size = new Size(564, 27);
            tb_Giaban.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 330);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 21;
            label6.Text = "Trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 270);
            label5.Name = "label5";
            label5.Size = new Size(66, 19);
            label5.TabIndex = 20;
            label5.Text = "Giá bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 210);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 19;
            label4.Text = "Số lượng còn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 18;
            label3.Text = "Xuất xứ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 17;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(36, 19);
            label1.TabIndex = 16;
            label1.Text = "Tên";
            // 
            // ptb_Image
            // 
            ptb_Image.BackColor = Color.FromArgb(255, 224, 192);
            ptb_Image.Location = new Point(935, 12);
            ptb_Image.Name = "ptb_Image";
            ptb_Image.Size = new Size(356, 329);
            ptb_Image.TabIndex = 32;
            ptb_Image.TabStop = false;
            ptb_Image.Click += ptb_Image_Click;
            // 
            // tb_Xuatxu
            // 
            tb_Xuatxu.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Xuatxu.Location = new Point(270, 154);
            tb_Xuatxu.Name = "tb_Xuatxu";
            tb_Xuatxu.Size = new Size(567, 27);
            tb_Xuatxu.TabIndex = 33;
            // 
            // tb_Soluongcon
            // 
            tb_Soluongcon.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Soluongcon.Location = new Point(270, 214);
            tb_Soluongcon.Name = "tb_Soluongcon";
            tb_Soluongcon.Size = new Size(564, 27);
            tb_Soluongcon.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(473, 330);
            label7.Name = "label7";
            label7.Size = new Size(41, 19);
            label7.TabIndex = 21;
            label7.Text = "Sale";
            // 
            // cbb_SaleActive
            // 
            cbb_SaleActive.FormattingEnabled = true;
            cbb_SaleActive.Location = new Point(553, 329);
            cbb_SaleActive.Name = "cbb_SaleActive";
            cbb_SaleActive.Size = new Size(277, 28);
            cbb_SaleActive.TabIndex = 35;
            // 
            // Form_QLSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 668);
            Controls.Add(cbb_SaleActive);
            Controls.Add(tb_Soluongcon);
            Controls.Add(tb_Xuatxu);
            Controls.Add(ptb_Image);
            Controls.Add(btn_Them);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Xoa);
            Controls.Add(dtg_Data);
            Controls.Add(cbb_Trangthai);
            Controls.Add(tb_Mota);
            Controls.Add(tb_Ten);
            Controls.Add(tb_Giaban);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_QLSP";
            Text = "Form_QLSP";
            Load += Form_QLSP_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Data).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private DataGridView dtg_Data;
        private ComboBox cbb_Trangthai;
        private TextBox tb_Mota;
        private TextBox tb_Ten;
        private TextBox tb_Giaban;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox ptb_Image;
        private TextBox tb_Xuatxu;
        private TextBox tb_Soluongcon;
        private Label label7;
        private ComboBox cbb_SaleActive;
    }
}