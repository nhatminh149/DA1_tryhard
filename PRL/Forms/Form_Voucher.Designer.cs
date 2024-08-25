namespace PRL.Forms
{
    partial class Form_Voucher
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
            btn_Delete = new Button();
            btn_Update = new Button();
            btn_Add = new Button();
            dtg_Data = new DataGridView();
            cbb_Status = new ComboBox();
            tbt_MoneyDown = new TextBox();
            dtp_End = new DateTimePicker();
            dtp_Start = new DateTimePicker();
            tbt_Mota = new TextBox();
            tbt_Ten = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lb_MaVoucher = new Label();
            tbt_MaVoucher = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_Data).BeginInit();
            SuspendLayout();
            // 
            // btn_Delete
            // 
            btn_Delete.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Delete.Location = new Point(1042, 285);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(262, 77);
            btn_Delete.TabIndex = 47;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.Location = new Point(1042, 158);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(262, 81);
            btn_Update.TabIndex = 46;
            btn_Update.Text = "Sửa";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Add.Location = new Point(1040, 34);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(263, 80);
            btn_Add.TabIndex = 45;
            btn_Add.Text = "Thêm mới";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // dtg_Data
            // 
            dtg_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Data.Location = new Point(12, 382);
            dtg_Data.Name = "dtg_Data";
            dtg_Data.RowHeadersWidth = 51;
            dtg_Data.RowTemplate.Height = 29;
            dtg_Data.Size = new Size(975, 249);
            dtg_Data.TabIndex = 44;
            dtg_Data.CellClick += dtg_Data_CellClick;
            // 
            // cbb_Status
            // 
            cbb_Status.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_Status.FormattingEnabled = true;
            cbb_Status.Items.AddRange(new object[] { "Không hoạt động", "Hoạt động" });
            cbb_Status.Location = new Point(163, 332);
            cbb_Status.Name = "cbb_Status";
            cbb_Status.Size = new Size(251, 33);
            cbb_Status.TabIndex = 43;
            // 
            // tbt_MoneyDown
            // 
            tbt_MoneyDown.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbt_MoneyDown.Location = new Point(163, 279);
            tbt_MoneyDown.Name = "tbt_MoneyDown";
            tbt_MoneyDown.Size = new Size(125, 30);
            tbt_MoneyDown.TabIndex = 42;
            // 
            // dtp_End
            // 
            dtp_End.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_End.Location = new Point(679, 225);
            dtp_End.Name = "dtp_End";
            dtp_End.Size = new Size(308, 30);
            dtp_End.TabIndex = 41;
            // 
            // dtp_Start
            // 
            dtp_Start.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_Start.Location = new Point(163, 224);
            dtp_Start.Name = "dtp_Start";
            dtp_Start.Size = new Size(324, 30);
            dtp_Start.TabIndex = 40;
            // 
            // tbt_Mota
            // 
            tbt_Mota.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbt_Mota.Location = new Point(163, 152);
            tbt_Mota.Name = "tbt_Mota";
            tbt_Mota.Size = new Size(570, 30);
            tbt_Mota.TabIndex = 39;
            // 
            // tbt_Ten
            // 
            tbt_Ten.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbt_Ten.Location = new Point(163, 80);
            tbt_Ten.Name = "tbt_Ten";
            tbt_Ten.Size = new Size(570, 30);
            tbt_Ten.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(10, 340);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 37;
            label6.Text = "Trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 285);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 36;
            label5.Text = "Giá trị giảm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(545, 230);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 35;
            label4.Text = "Kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 230);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 34;
            label3.Text = "Bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 158);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 33;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 86);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 32;
            label1.Text = "Tên";
            // 
            // lb_MaVoucher
            // 
            lb_MaVoucher.AutoSize = true;
            lb_MaVoucher.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_MaVoucher.Location = new Point(12, 20);
            lb_MaVoucher.Name = "lb_MaVoucher";
            lb_MaVoucher.Size = new Size(119, 25);
            lb_MaVoucher.TabIndex = 48;
            lb_MaVoucher.Text = "Mã Voucher";
            // 
            // tbt_MaVoucher
            // 
            tbt_MaVoucher.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbt_MaVoucher.Location = new Point(163, 20);
            tbt_MaVoucher.Name = "tbt_MaVoucher";
            tbt_MaVoucher.Size = new Size(570, 30);
            tbt_MaVoucher.TabIndex = 49;
            // 
            // Form_Voucher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 641);
            Controls.Add(tbt_MaVoucher);
            Controls.Add(lb_MaVoucher);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Add);
            Controls.Add(dtg_Data);
            Controls.Add(cbb_Status);
            Controls.Add(tbt_MoneyDown);
            Controls.Add(dtp_End);
            Controls.Add(dtp_Start);
            Controls.Add(tbt_Mota);
            Controls.Add(tbt_Ten);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Voucher";
            Text = "Form_Voucher";
            Load += Form_Voucher_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Add;
        private DataGridView dtg_Data;
        private ComboBox cbb_Status;
        private TextBox tbt_MoneyDown;
        private DateTimePicker dtp_End;
        private DateTimePicker dtp_Start;
        private TextBox tbt_Mota;
        private TextBox tbt_Ten;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lb_MaVoucher;
        private TextBox tbt_MaVoucher;
    }
}