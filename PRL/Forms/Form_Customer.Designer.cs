namespace PRL.Forms
{
    partial class Form_Customer
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
            tbt_Point = new TextBox();
            btn_MoKhoa = new Button();
            btn_Khoa = new Button();
            btn_Sua = new Button();
            btn_Them = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbt_Name = new TextBox();
            tbt_PhoneNumber = new TextBox();
            dtg_Data = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_Data).BeginInit();
            SuspendLayout();
            // 
            // tbt_Point
            // 
            tbt_Point.Location = new Point(257, 185);
            tbt_Point.Name = "tbt_Point";
            tbt_Point.Size = new Size(198, 27);
            tbt_Point.TabIndex = 33;
            // 
            // btn_MoKhoa
            // 
            btn_MoKhoa.BackgroundImage = Properties.Resources.tải_xuống;
            btn_MoKhoa.BackgroundImageLayout = ImageLayout.Stretch;
            btn_MoKhoa.Location = new Point(374, 253);
            btn_MoKhoa.Name = "btn_MoKhoa";
            btn_MoKhoa.Size = new Size(81, 81);
            btn_MoKhoa.TabIndex = 32;
            btn_MoKhoa.UseVisualStyleBackColor = true;
            // 
            // btn_Khoa
            // 
            btn_Khoa.BackgroundImage = Properties.Resources._1803612;
            btn_Khoa.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Khoa.Location = new Point(253, 253);
            btn_Khoa.Name = "btn_Khoa";
            btn_Khoa.Size = new Size(87, 81);
            btn_Khoa.TabIndex = 31;
            btn_Khoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            btn_Sua.BackgroundImage = Properties.Resources.tải_xuống__1_;
            btn_Sua.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Sua.Location = new Point(138, 253);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(87, 81);
            btn_Sua.TabIndex = 30;
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Them
            // 
            btn_Them.BackgroundImage = Properties.Resources.tải_xuống__2_;
            btn_Them.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Them.Location = new Point(27, 253);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(86, 81);
            btn_Them.TabIndex = 29;
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 181);
            label3.Name = "label3";
            label3.Size = new Size(71, 31);
            label3.TabIndex = 28;
            label3.Text = "Point";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 100);
            label2.Name = "label2";
            label2.Size = new Size(181, 31);
            label2.TabIndex = 27;
            label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(163, 31);
            label1.TabIndex = 26;
            label1.Text = "Số Điện Thoại";
            // 
            // tbt_Name
            // 
            tbt_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbt_Name.Location = new Point(257, 100);
            tbt_Name.Name = "tbt_Name";
            tbt_Name.Size = new Size(985, 38);
            tbt_Name.TabIndex = 25;
            // 
            // tbt_PhoneNumber
            // 
            tbt_PhoneNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbt_PhoneNumber.Location = new Point(257, 21);
            tbt_PhoneNumber.Name = "tbt_PhoneNumber";
            tbt_PhoneNumber.Size = new Size(987, 38);
            tbt_PhoneNumber.TabIndex = 24;
            // 
            // dtg_Data
            // 
            dtg_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Data.Location = new Point(11, 377);
            dtg_Data.Name = "dtg_Data";
            dtg_Data.RowHeadersWidth = 51;
            dtg_Data.RowTemplate.Height = 29;
            dtg_Data.Size = new Size(1334, 314);
            dtg_Data.TabIndex = 23;
            dtg_Data.CellClick += dtg_Data_CellClick;
            // 
            // Form_Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkViolet;
            ClientSize = new Size(1500, 750);
            Controls.Add(tbt_Point);
            Controls.Add(btn_MoKhoa);
            Controls.Add(btn_Khoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbt_Name);
            Controls.Add(tbt_PhoneNumber);
            Controls.Add(dtg_Data);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Customer";
            Text = "Form_Customer";
            Load += Form_Customer_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbt_Point;
        private Button btn_MoKhoa;
        private Button btn_Khoa;
        private Button btn_Sua;
        private Button btn_Them;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbt_Name;
        private TextBox tbt_PhoneNumber;
        private DataGridView dtg_Data;
    }
}