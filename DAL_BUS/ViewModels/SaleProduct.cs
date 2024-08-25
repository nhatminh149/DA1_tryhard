using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.ViewModels
{
    public class SaleProduct
    {
        // Chúng ta tạo ra 1 view model để chứa sản phẩm sau khi đã sale, giá bán thực tế
        // lưu trong hoá đơn là giá SalePrice
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string ImgURL { get; set; }
        public string From { get; set; } //Xuất xứ
        public long Price { get; set; }
        public int TotalAmount { get; set; }
        public int Status { get; set; }
        public long SalePrice { get; set; }
    }
}
