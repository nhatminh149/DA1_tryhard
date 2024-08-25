using DAL_BUS.BUS;
using DAL_BUS.DAL;
using DAL_BUS.ViewModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public partial class Form_BanHang : Form
    {
        CustomerServices _customerServices;
        ProductServices _productServices;
        SaleServices _saleServices;
        BillServices _billServices;
        BillDetailServices _billDetailsService;
        List<Product> _products;
        List<Customer> _customers;
        List<Voucher> _vouchersActive;
        VoucherServices _voucherServices;
        public Form_BanHang()
        {
            _billServices = new BillServices();
            _billDetailsService = new BillDetailServices();
            _voucherServices = new VoucherServices();
            _productServices = new ProductServices();
            _customerServices = new CustomerServices();
            InitializeComponent();
        }
        private void Form_BanHang_Load(object sender, EventArgs e)
        {
            _vouchersActive = _voucherServices.GetActiveVoucher(); //Danh sách các sale đang hoạt động
            foreach (var item in _vouchersActive)
            {
                cbb_Voucher.Items.Add(item.Name);
            }
            LoadSPByPage(Convert.ToInt32(lb_Page.Text));
            LoadBill();
        }
        public Panel CreatePanelSP(SaleProduct sp)
        {
            PictureBox ptb_Image = new PictureBox();
            Label Lb_Ten = new Label();
            Label lb_Gia = new Label();
            Label lb_GiaMoi = new Label();
            Label lb_GiaValue = new Label();
            Label lb_Soluong = new Label();
            Label lb_SoluongValue = new Label();
            Label lb_Mota = new Label();
            Label lb_MotaValue = new Label();
            Label lb_XuatXu = new Label();
            Label lb_XuatXuValue = new Label();
            Button btn_Mua = new Button();
            TextBox tb_SoluongMua = new TextBox();
            // 
            // ptb_Image
            // 
            ptb_Image.Location = new Point(1, 2);
            ptb_Image.Name = "ptb_Image";
            ptb_Image.Size = new Size(189, 202);
            ptb_Image.TabIndex = 0;
            ptb_Image.TabStop = false;
            ptb_Image.ImageLocation = sp.ImgURL;
            ptb_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // Lb_Ten
            // 
            Lb_Ten.AutoSize = true;
            Lb_Ten.Location = new Point(193, 2);
            Lb_Ten.Name = "Lb_Ten";
            Lb_Ten.Size = new Size(69, 20);
            Lb_Ten.TabIndex = 1;
            Lb_Ten.Text = sp.Name;
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
            lb_GiaValue.Text = sp.Price + ""; lb_GiaValue.Font = new Font(lb_GiaValue.Font, FontStyle.Strikeout);
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
            lb_SoluongValue.Text = sp.TotalAmount + "";
            // 
            // lb_MotaValue
            // 
            lb_MotaValue.AutoSize = true;
            lb_MotaValue.Location = new Point(3, 237);
            lb_MotaValue.Name = "lb_MotaValue";
            lb_MotaValue.Size = new Size(104, 20);
            lb_MotaValue.TabIndex = 5;
            lb_MotaValue.Text = sp.Details;
            // 
            // lb_XuatXuValue
            // 
            lb_XuatXuValue.AutoSize = true;
            lb_XuatXuValue.Location = new Point(3, 300);
            lb_XuatXuValue.Name = "lb_XuatXuValue";
            lb_XuatXuValue.Size = new Size(131, 20);
            lb_XuatXuValue.TabIndex = 5;
            lb_XuatXuValue.Text = sp.From;
            // 
            // btn_Mua
            // 
            btn_Mua.Location = new Point(234, 248);
            btn_Mua.Name = "btn_Mua";
            btn_Mua.Size = new Size(124, 64);
            btn_Mua.TabIndex = 6;
            btn_Mua.Text = "Mua hàng";
            btn_Mua.UseVisualStyleBackColor = true;
            btn_Mua.Click += Btn_Mua_Click;
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
            lb_GiaMoi.Text = sp.SalePrice.ToString();
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
            Panel pn = new Panel();
            pn.Name = sp.Id.ToString();
            pn.Size = new Size(380, 350);
            pn.Controls.Add(tb_SoluongMua);
            pn.Controls.Add(btn_Mua);
            pn.Controls.Add(lb_XuatXu);
            pn.Controls.Add(lb_Mota);
            pn.Controls.Add(lb_SoluongValue);
            pn.Controls.Add(lb_Soluong);
            pn.Controls.Add(lb_GiaValue);
            pn.Controls.Add(lb_Gia);
            pn.Controls.Add(Lb_Ten);
            pn.Controls.Add(ptb_Image);
            pn.Controls.Add(lb_GiaMoi);
            pn.Controls.Add(lb_XuatXuValue);
            pn.Controls.Add(lb_MotaValue);
            return pn;
        }
        public void LoadSPByPage(int page)
        {
            tbpl_Sanpham.Controls.Clear();
            _products = _productServices.GetAll(); // Lấy ra tất cả SP
            _saleServices = new SaleServices();
            var sales = _saleServices.GetAllSale();
            // Join để lấy data
            var saleProducts =
                from product in _products
                join sale in sales
                on product.SaleId equals sale.Id
                select new SaleProduct
                {
                    Id = product.Id,
                    Name = product.Name,
                    Details = product.Details,
                    ImgURL = product.ImgURL,
                    From = product.From,
                    Price = product.Price,
                    TotalAmount = product.TotalAmount,
                    Status = product.Status,
                    SalePrice = Convert.ToInt64(product.Price - product.Price * (sale.Percent / 100))
                };
            // Khi có danh sách sản phẩm ta kiểm tra xem page có vi phạm không
            if (page * 4 - 4 < saleProducts.ToList().Count)
            {
                SaleProduct sp = saleProducts.ToList()[page * 4 - 4];
                Panel p1 = CreatePanelSP(sp);
                tbpl_Sanpham.Controls.Add(p1, 0, 0);
            }
            if (page * 4 - 3 < saleProducts.ToList().Count)
            {
                SaleProduct sp = saleProducts.ToList()[page * 4 - 3];
                Panel p2 = CreatePanelSP(sp);
                tbpl_Sanpham.Controls.Add(p2, 0, 1);
            }
            if (page * 4 - 2 < saleProducts.ToList().Count)
            {
                SaleProduct sp = saleProducts.ToList()[page * 4 - 2];
                Panel p3 = CreatePanelSP(sp);
                tbpl_Sanpham.Controls.Add(p3, 1, 0);
            }
            if (page * 4 - 1 < saleProducts.ToList().Count)
            {
                SaleProduct sp = saleProducts.ToList()[page * 4 - 1];
                Panel p4 = CreatePanelSP(sp);
                tbpl_Sanpham.Controls.Add(p4, 1, 1);
            }
            // Để xử lý Join không ra kết quả chúng ta có thể tạo 1 bản ghi sale 0% cho những cái nào ko sale
        }
        public void LoadBillDetails(Guid billId)
        {
            dtg_HDCT.Rows.Clear();

            var billDetails = _billDetailsService.GetAllByBillId(billId);
            dtg_HDCT.ColumnCount = 5;
            dtg_HDCT.Columns[0].HeaderText = "Mã HDCT";
            dtg_HDCT.Columns[1].HeaderText = "Mã Hóa Đơn";
            dtg_HDCT.Columns[2].HeaderText = "Mã Sản phẩm";
            dtg_HDCT.Columns[3].HeaderText = "Đơn giá";
            dtg_HDCT.Columns[4].HeaderText = "Số lượng mua";
            foreach (var item in billDetails)
            {
                dtg_HDCT.Rows.Add(item.Id, item.BillId, item.ProductId, item.Price, item.Amount);
            }
        }
        public void LoadBill()
        {
            dtg_HD.Rows.Clear();

            var bills = _billServices.GetWaitBill();
            dtg_HD.ColumnCount = 7;
            dtg_HD.Columns[0].HeaderText = "Mã Hóa đơn";
            dtg_HD.Columns[1].HeaderText = "Trạng thái";
            dtg_HD.Columns[2].HeaderText = "Tổng tiền";
            dtg_HD.Columns[3].HeaderText = "Mã Nhân viên";
            dtg_HD.Columns[4].HeaderText = "SDT khách hàng";
            dtg_HD.Columns[5].HeaderText = "Ngày tạo";
            dtg_HD.Columns[6].HeaderText = "Mã Voucher";
            foreach (var item in bills)
            {
                dtg_HD.Rows.Add(item.Id, 0, item.TotalMoney, item.AccountId, item.CustomerPhone, item.CreateDate, item.VoucherId);
            }
        }
        private void Btn_Mua_Click(object? sender, EventArgs e) //nút mua
        {
            long price = 0; // Biến lưu giá của sản phẩm
            int amount = 0; // Biến lưu số lượng sản phẩm

            // Lấy thông tin của panel chứa sản phẩm từ nút nhấn
            Button btnMua = sender as Button; // Chuyển đổi sender thành Button
            Panel cpnSP = btnMua.Parent as Panel; // Lấy Panel chứa Button từ thuộc tính Parent của nó

            // Tạo danh sách để chứa các Label và TextBox trong Panel
            List<Label> labels = new List<Label>();
            List<TextBox> textboxs = new List<TextBox>();

            // Duyệt qua tất cả các điều khiển trong Panel
            foreach (var item in cpnSP.Controls)
            {
                if (item is Label) labels.Add(item as Label); // Thêm Label vào danh sách
                if (item is TextBox) textboxs.Add(item as TextBox); // Thêm TextBox vào danh sách
            }


            // Duyệt qua danh sách các Label để tìm giá sản phẩm
            foreach (var item in labels)
            {
                if (item.Name == "lb_GiaMoi") // Tìm Label có tên là "lb_GiaMoi"
                {
                    // Kiểm tra giá có hợp lệ không trước khi chuyển đổi
                    if (!long.TryParse(item.Text, out price) || price <= 0)
                    {
                        MessageBox.Show("Giá sản phẩm không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break; // Thoát khỏi vòng lặp sau khi tìm thấy giá
                }
            }

            // Duyệt qua danh sách các TextBox để tìm số lượng sản phẩm
            foreach (var item in textboxs)
            {
                if (item.Name == "tb_SoluongMua") // Tìm TextBox có tên là "tb_SoluongMua"
                {
                    // Kiểm tra số lượng có hợp lệ không trước khi chuyển đổi
                    if (!int.TryParse(item.Text, out amount) || amount <= 0)
                    {
                        MessageBox.Show("Số lượng mua không hợp lệ. Vui lòng nhập số lượng lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break; // Thoát khỏi vòng lặp sau khi tìm thấy số lượng
                }
            }

            // Kiểm tra xem hóa đơn đã được tạo chưa
            if (string.IsNullOrEmpty(lb_MaHD.Text))
            {
                MessageBox.Show("Chưa có hóa đơn. Vui lòng tạo hóa đơn trước khi thực hiện mua hàng.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return; // Ngừng thực hiện hành động mua hàng
            }

            // Kiểm tra số lượng sản phẩm hiện có
            // Giả sử bạn có một phương thức trong dịch vụ để lấy số lượng hiện có của sản phẩm
            _productServices = new ProductServices(); // Tạo một đối tượng dịch vụ sản phẩm
            int soluongcon = _productServices.GetSLActive(Guid.Parse(cpnSP.Name)); // Lấy số lượng hiện có của sản phẩm từ dịch vụ

            if (amount > soluongcon) // So sánh số lượng mua với số lượng hiện có
            {
                MessageBox.Show("Số lượng mua không thể lớn hơn số lượng hiện có. Số lượng hiện có là: " + soluongcon,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }



            // Xác nhận việc mua hàng từ người dùng
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn mua hàng với số lượng " + amount + " và giá " + price + " không?",
                                                "Xác nhận mua hàng",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes) // Kiểm tra xem người dùng đã chọn "Yes"
            {
                // Lấy các thuộc tính cần thiết để thực hiện việc mua hàng
                Guid productId = Guid.Parse(cpnSP.Name); // Chuyển đổi tên của Panel (sử dụng ID sản phẩm) thành Guid
                Guid billId = Guid.Parse(lb_MaHD.Text); // Chuyển đổi văn bản của Label lb_MaHD (mã hóa đơn) thành Guid

                // Tạo một đối tượng dịch vụ để xử lý chi tiết hóa đơn
                _billDetailsService = new BillDetailServices();

                // Gọi phương thức AddToBill để thêm sản phẩm vào hóa đơn và nhận kết quả
                string result = _billDetailsService.AddToBill(billId, productId, price, amount);

                // Hiển thị kết quả của việc thêm sản phẩm vào hóa đơn
                MessageBox.Show(result);

                // Cập nhật số lượng trong kho ***
                _productServices.UpdateSL(productId, amount);


                //// Cập nhật tổng tiền cho hóa đơn  C1
                _billServices.UpdateTotalPrice(billId, 0);
                /// Cập nhật tổng tiền cho hóa đơn C2 
                //long totalMoney = _billServices.CaculateBill(billId);
                ////MessageBox.Show("Tổng tiền hóa đơn là : "  + totalMoney.ToString());
                //_billServices.UpdateTotalMoney(billId, 0, totalMoney);

                LoadBill();
                // Tải lại chi tiết hóa đơn
                LoadBillDetails(Guid.Parse(lb_MaHD.Text));

                // Tải lại danh sách sản phẩm theo trang hiện tại
                LoadSPByPage(Convert.ToInt32(lb_Page.Text));
            }
        }

        private void lbNext_Click(object sender, EventArgs e)
        {
            var products = _productServices.GetAll();
            int count = products.Count;
            if (Convert.ToInt32(lb_Page.Text) < count / 4 && count % 4 == 0
                || Convert.ToInt32(lb_Page.Text) <= count / 4 && count % 4 != 0)
            {
                lb_Page.Text = Convert.ToInt32(lb_Page.Text) + 1 + "";
                LoadSPByPage(Convert.ToInt32(lb_Page.Text));
            }
        }


        private void lbBack_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_Page.Text) >= 2)
            {
                lb_Page.Text = Convert.ToInt32(lb_Page.Text) - 1 + "";
                LoadSPByPage(Convert.ToInt32(lb_Page.Text));
            }
        }

        private void btn_CreateBill_Click(object sender, EventArgs e)                ///Nút tạo hóa đơn
        {

            string accountId = "";
            var formMain = this.Parent.Parent as Form; // Lấy từ form Cha là form Main
                                                       //// this là formBanHang cho nên Parent của nó là Panel, Parent của panel mới là form Main
            List<Label> labels = new List<Label>();
            foreach (var item in formMain.Controls)
            {
                if (item is Label) labels.Add((Label)item);
            } //// Lấy hết label từ form cha
            foreach (var item in labels)
            {
                if (item.Name == "lb_Account")
                {
                    accountId = item.Text; break;
                }
            } // từ các label mình lấy ra label nào có tên là Account ID để thông qua đó lấy ID

            _billServices = new BillServices();
            string voucherId = cbb_Voucher.SelectedIndex >= 0 ? _vouchersActive[cbb_Voucher.SelectedIndex].Id.ToString() : null;
            if (string.IsNullOrEmpty(voucherId))
            {
                MessageBox.Show("Vui lòng chọn voucher hợp lệ.");
                return;
            }

            // Kiểm tra số điện thoại của khách hàng
            bool isCustomerExists = _customerServices.CheckCustomerExistsByPhone(tbt_Phone.Text);
            if (!isCustomerExists)
            {
                MessageBox.Show("Số điện thoại khách hàng không tồn tại.");
                return;
            }

            // Tạo hóa đơn mới
            var result = _billServices.Create(accountId, tbt_Phone.Text, voucherId);
            LoadBill();


        }

        private void tbt_Phone_TextChanged(object sender, EventArgs e)
        {
            cbb_Phone.Items.Clear();
            string searchPhone = tbt_Phone.Text;
            _customers = _customerServices.GetByPhone(searchPhone); // tìm kiếm và hiện ra khi cần
            if (_customers.Count > 0)
            {
                foreach (var customer in _customers)
                {
                    cbb_Phone.Items.Add(customer.Name); // Thêm tên khách hàng vào combobox
                }

                // Nếu chỉ có một khách hàng, chọn khách hàng đó và cập nhật label
                if (_customers.Count == 1)
                {
                    cbb_Phone.SelectedIndex = 0; // Chọn mục đầu tiên trong combobox  // Tự động chọn mục đầu tiên để hiển thị tên khách hàng lên label
                }
            }
            else
            {
                // Nếu không có khách hàng nào, xóa label
                cbb_Phone.SelectedIndex = -1;
                tbt_Name.Text = "";
            }


            //if (_customers.Count == 1)
            //{
            //    tbt_Name.Text = _customers[0].Name + " - " + _customers[0].PhoneNumber; ///Khi chọn khách trong combobox sẽ hiện Tên khách hàng trên label
            //}
            //else
            //{
            //    tbt_Name.Text = ""; // Clear label if multiple or no matches
            //}

            //foreach (var item in _customers)
            //{
            //    cbb_Phone.Items.Add(item.Name);
            //}
        }


        private void dtg_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ số hàng có hợp lệ không
            {
                DataGridViewRow row = dtg_HD.Rows[e.RowIndex];
                lb_MaHD.Text = row.Cells[0].Value.ToString();
                tbt_Phone.Text = row.Cells[4].Value.ToString();
                lb_money.Text = row.Cells[2].Value.ToString();
                string selectedVoucherId = row.Cells[6].Value.ToString();

                // Đặt voucher trong combobox
                if (!string.IsNullOrEmpty(selectedVoucherId))
                {
                    // Lấy ID voucher từ DataGridView
                    var voucher = _vouchersActive.FirstOrDefault(v => v.Id.ToString() == selectedVoucherId);
                    if (voucher != null)
                    {
                        cbb_Voucher.SelectedItem = voucher.Name;
                    }
                }

                LoadBillDetails(Guid.Parse(row.Cells[0].Value.ToString()));
            }
        }

        private void cbb_Phone_TextChanged(object sender, EventArgs e)
        {
            int index = cbb_Phone.SelectedIndex;
            if (index >= 0 && index < _customers.Count)
            {
                tbt_Phone.Text = _customers[index].PhoneNumber; // Cập nhật số điện thoại khi chọn khách hàng   // bugg
                tbt_Name.Text = _customers[index].Name + " - " + _customers[index].PhoneNumber;
            }
        }

        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            Guid billId = Guid.Parse(lb_MaHD.Text); // Chuyển đổi văn bản của Label lb_MaHD (mã hóa đơn) thành Guid
            // Cập nhật tổng tiền cho hóa đơn

            MessageBox.Show(_billServices.UpdateTotalPrice(billId, 0));
            // Tải lại chi tiết hóa đơn
            LoadBillDetails(Guid.Parse(lb_MaHD.Text));

            LoadBill();


            //long totalMoney = _billServices.CaculateBill(billId);
            ////MessageBox.Show("Tổng tiền hóa đơn là : "  + totalMoney.ToString());
            //_billServices.UpdateTotalMoney(billId, 0, totalMoney);

            //LoadBill();
            //// Tải lại chi tiết hóa đơn
            //LoadBillDetails(Guid.Parse(lb_MaHD.Text));
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            Guid billId = Guid.Parse(lb_MaHD.Text);
            if (billId != null)
            {
                _billServices.UpdateTotalPrice(billId, 1);
                MessageBox.Show("Cảm ơn bạn đã mua hàng! Chúng tôi rất vui được phục vụ bạn. Hẹn gặp lại lần sau!",
                "Thanh toán thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                dtg_HDCT.Rows.Clear();
                LoadBill();
            }
        }
    }
}
