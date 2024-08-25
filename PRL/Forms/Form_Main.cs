using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class Form_Main : Form
    {
        string accountInfor;
        public Form_Main(string accountInfor)
        {
            InitializeComponent();
            this.accountInfor = accountInfor;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            string[] infor = accountInfor.Split(':'); //Cắt role và username để xử lý
            lb_Account.Text = infor[1];
            if (infor[0] == "2")
            {
                btn_QLNV.Visible = false;
                btn_QLSP.Visible = false;
                btn_QLSale.Visible = false;
            }
        }
        private void btn_qlnv_Click(object sender, EventArgs e)
        {
            pn_Main.Controls.Clear();
            Form_Account form_Account = new Form_Account();
            form_Account.TopLevel = false;
            pn_Main.Controls.Add(form_Account);
            form_Account.FormBorderStyle = FormBorderStyle.None;
            form_Account.Show();
        }


        private void btn_sale_Click(object sender, EventArgs e)
        {
            pn_Main.Controls.Clear();
            Form_QLSale form_QLSale = new Form_QLSale();
            form_QLSale.TopLevel = false;
            pn_Main.Controls.Add(form_QLSale);
            form_QLSale.FormBorderStyle = FormBorderStyle.None;
            form_QLSale.Show();
        }

        private void btn_QLSP_Click(object sender, EventArgs e)
        {
            pn_Main.Controls.Clear();
            Form_QLSP form_QLSP = new Form_QLSP();
            form_QLSP.TopLevel = false;
            pn_Main.Controls.Add(form_QLSP);
            form_QLSP.FormBorderStyle = FormBorderStyle.None;
            form_QLSP.Show();
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            pn_Main.Controls.Clear();
            Form_BanHang form_BanHang = new Form_BanHang();
            form_BanHang.TopLevel = false;
            pn_Main.Controls.Add(form_BanHang);
            form_BanHang.FormBorderStyle = FormBorderStyle.None;
            form_BanHang.Show();
        }

        private void btn_QLKhach_Click(object sender, EventArgs e)
        {
            pn_Main.Controls.Clear();
            Form_Customer form_Cus = new Form_Customer();
            form_Cus.TopLevel = false;
            pn_Main.Controls.Add(form_Cus);
            form_Cus.FormBorderStyle = FormBorderStyle.None;
            form_Cus.Show();
        }

        private void btn_QLVoucher_Click(object sender, EventArgs e)
        {
            pn_Main.Controls.Clear();
            Form_Voucher form_Voucher = new Form_Voucher();
            form_Voucher.TopLevel = false;
            pn_Main.Controls.Add(form_Voucher);
            form_Voucher.FormBorderStyle = FormBorderStyle.None;
            form_Voucher.Show();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
