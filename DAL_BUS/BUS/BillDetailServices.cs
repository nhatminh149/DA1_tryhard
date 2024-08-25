using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
    public class BillDetailServices
    {
        AppDbContext _context;
        public BillDetailServices()
        {
            _context = new AppDbContext();
        }
        public List<BillDetails> GetAllByBillId(Guid billId)
        {
            return _context.BillDetails.Where(p => p.BillId == billId).ToList();

        }
        public string AddToBill(Guid billID, Guid productID, long price, int amount)
        {
            var product = _context.Products.Find(productID);
            //if (product == null)
            //{
            //    return "Sản phẩm không tồn tại.";
            //}
            //// Kiểm tra số lượng tồn kho có đủ không
            //if (product.TotalAmount < amount)
            //{
            //    return "Số lượng tồn kho không đủ.";
            //}
            //// Trừ số lượng sản phẩm trong kho
            //product.TotalAmount -= amount;

            // Kiểm tra xem sản phẩm đã có trong hóa đơn chưa
            var check = _context.BillDetails.FirstOrDefault(p => p.BillId == billID && p.ProductId == productID);

            // Nếu sản phẩm chưa có trong hóa đơn, thêm mới vào hóa đơn
            if (check == null)
            {
                BillDetails details = new BillDetails()
                {
                    Id = Guid.NewGuid(),
                    BillId = billID,
                    ProductId = productID,
                    Price = price, // Đặt giá cho sản phẩm mới
                    Amount = amount
                };
                _context.BillDetails.Add(details);
                _context.SaveChanges();
            }
            else
            {
                // Cập nhật số lượng của sản phẩm đã có trong hóa đơn
                check.Amount += amount;
                // Nếu giá thay đổi, hãy xử lý giá theo cách phù hợp
                _context.BillDetails.Update(check);
                _context.SaveChanges();
            }

            // Cập nhật số lượng sản phẩm trong kho
            if (product != null)
            {
                product.TotalAmount -= amount;
                _context.Products.Update(product);
                _context.SaveChanges();
            }
            else
            {
                return "Sản phẩm không tồn tại trong kho.";
            }

            return check == null ? "Thêm thành công vào hóa đơn" : "Cập nhật hóa đơn thành công";





            //// Check xem SP đã nằm trong hóa đơn hay chưa????
            //var check = _context.BillDetails.FirstOrDefault(p => p.BillId == billID && p.ProductId == productID);
            //// Nếu chưa tồn tại => Tạo mới 1 HDCT
            //if (check == null)// SP mới chưa có trong hóa đơn
            //{
            //    BillDetails details = new BillDetails()
            //    {
            //        Id = Guid.NewGuid(),
            //        BillId = billID,
            //        ProductId = productID,
            //        Price = price,
            //        Amount = amount
            //    };
            //    _context.BillDetails.Add(details);
            //    _context.SaveChanges();
            //    // Update số lượng của sản phẩm trong kho
            //    var product = _context.Products.Find(productID);
            //    product.TotalAmount = product.TotalAmount - amount;
            //    _context.Products.Update(product);
            //    _context.SaveChanges();
            //    return "Thêm thành công vào hóa đơn";
            //}
            //else // SP đã có trong hóa đơn rồi => Update số lượng
            //{
            //    check.Price = check.Price + price;
            //    check.Amount = check.Amount + amount; // update số lượng trong bill Details
            //    _context.BillDetails.Update(check); _context.SaveChanges();
            //    // Update số lượng của sản phẩm trong kho
            //    var product = _context.Products.Find(productID);
            //    product.TotalAmount = product.TotalAmount - amount;
            //    _context.Products.Update(product);
            //    _context.SaveChanges();

            //    return "Thêm mới và cộng dồn thành công";
            //}
        }
    }
}
