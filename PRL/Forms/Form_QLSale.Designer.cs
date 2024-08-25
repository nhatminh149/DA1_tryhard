namespace PRL.Forms
{
    partial class Form_QLSale
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
            dtp_Start = new DateTimePicker();
            dtp_End = new DateTimePicker();
            tb_Mota = new TextBox();
            tb_Ten = new TextBox();
            tb_Percent = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_Data).BeginInit();
            SuspendLayout();
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(961, 36);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(275, 77);
            btn_Them.TabIndex = 48;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click_1;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(961, 183);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(275, 77);
            btn_Sua.TabIndex = 47;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(961, 328);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(275, 77);
            btn_Xoa.TabIndex = 46;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // dtg_Data
            // 
            dtg_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Data.Location = new Point(6, 379);
            dtg_Data.Name = "dtg_Data";
            dtg_Data.RowHeadersWidth = 51;
            dtg_Data.RowTemplate.Height = 29;
            dtg_Data.Size = new Size(825, 281);
            dtg_Data.TabIndex = 45;
            dtg_Data.CellClick += dtg_Data_CellClick;
            // 
            // cbb_Trangthai
            // 
            cbb_Trangthai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbb_Trangthai.FormattingEnabled = true;
            cbb_Trangthai.Items.AddRange(new object[] { "Không hoạt động", "Hoạt động" });
            cbb_Trangthai.Location = new Point(267, 319);
            cbb_Trangthai.Name = "cbb_Trangthai";
            cbb_Trangthai.Size = new Size(301, 36);
            cbb_Trangthai.TabIndex = 44;
            // 
            // dtp_Start
            // 
            dtp_Start.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtp_Start.Location = new Point(267, 139);
            dtp_Start.Name = "dtp_Start";
            dtp_Start.Size = new Size(279, 34);
            dtp_Start.TabIndex = 43;
            // 
            // dtp_End
            // 
            dtp_End.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtp_End.Location = new Point(267, 199);
            dtp_End.Name = "dtp_End";
            dtp_End.Size = new Size(279, 34);
            dtp_End.TabIndex = 42;
            // 
            // tb_Mota
            // 
            tb_Mota.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Mota.Location = new Point(267, 79);
            tb_Mota.Name = "tb_Mota";
            tb_Mota.Size = new Size(567, 34);
            tb_Mota.TabIndex = 41;
            // 
            // tb_Ten
            // 
            tb_Ten.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Ten.Location = new Point(267, 19);
            tb_Ten.Name = "tb_Ten";
            tb_Ten.Size = new Size(567, 34);
            tb_Ten.TabIndex = 40;
            // 
            // tb_Percent
            // 
            tb_Percent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Percent.Location = new Point(267, 259);
            tb_Percent.Name = "tb_Percent";
            tb_Percent.Size = new Size(218, 34);
            tb_Percent.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(9, 319);
            label6.Name = "label6";
            label6.Size = new Size(102, 28);
            label6.TabIndex = 38;
            label6.Text = "Trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(9, 259);
            label5.Name = "label5";
            label5.Size = new Size(157, 28);
            label5.TabIndex = 37;
            label5.Text = "Phần trăm giảm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(9, 199);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 36;
            label4.Text = "Kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 139);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 35;
            label3.Text = "Bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 79);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 34;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 19);
            label1.Name = "label1";
            label1.Size = new Size(44, 28);
            label1.TabIndex = 33;
            label1.Text = "Tên";
            // 
            // Form_QLSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 668);
            Controls.Add(btn_Them);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Xoa);
            Controls.Add(dtg_Data);
            Controls.Add(cbb_Trangthai);
            Controls.Add(dtp_Start);
            Controls.Add(dtp_End);
            Controls.Add(tb_Mota);
            Controls.Add(tb_Ten);
            Controls.Add(tb_Percent);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_QLSale";
            Text = "Form_QLSale";
            Load += Form_QLSale_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private DataGridView dtg_Data;
        private ComboBox cbb_Trangthai;
        private DateTimePicker dtp_Start;
        private DateTimePicker dtp_End;
        private TextBox tb_Mota;
        private TextBox tb_Ten;
        private TextBox tb_Percent;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}