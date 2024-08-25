using DAL_BUS.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
    public class ProductServices
    {
        AppDbContext _context;
        public ProductServices()
        {
            _context = new AppDbContext();
        }
        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }
        public string CreateProduct(Product product)
        {
            if(product.Name.Trim() == "" || product.Details.Trim() == "" || product.From.Trim() == "")
            {
                return "Hãy kiểm tra lại dữ liệu không được trống";
            }
            else if (product.Price < 0 || product.TotalAmount < 0)
            {
                return " Giá và số lượng không thể giá trị âm";
            }
            else if (string.IsNullOrEmpty(product.ImgURL))
            {
                return " Đường dẫn ảnh không được trống";
            }
            //else if (product.SaleId == Guid.Empty)  // Kiểm tra nếu SaleId chưa được chọn         //không cần thiết vì khi thêm đã làm r
            //{
            //    return "Vui lòng chọn Sale trước khi thêm sản phẩm";
            //}
            else
            {
                try
                {
                    _context.Products.Add(product);
                    _context.SaveChanges();
                    return "Thêm sản phẩm thành công";
                }
                catch (Exception e)
                {
                    return "Thêm sản phẩm thất bại" + e.Message;
                }
            }
        }
        public List<Product> SearchByName (string name)
        {
            return _context.Products.Where(p=>p.Name.ToLower().Contains(name.ToLower())).ToList();
        }
        public string UpdateProduct(Product product)
        {
            try
            {
                var updateproduct = _context.Products.Find(product.Id);
                if (updateproduct == null)
                {
                    return "Sản phẩm không tồn tại";
                }
                updateproduct.Name = product.Name;
                updateproduct.Details = product.Details;
                updateproduct.ImgURL = product.ImgURL;
                updateproduct.From = product.From;
                updateproduct.Price = product.Price;
                updateproduct.TotalAmount = product.TotalAmount;
                updateproduct.Status = product.Status;    
                updateproduct.SaleId = product.SaleId;
                _context.Products.Update(updateproduct);
                _context.SaveChanges();
                return "Sửa sản phẩm thành công";
            }
            catch (Exception e)
            {
                return "Sửa sản phẩm thất bại" + e.Message;
            }
        }
        public string DeleteProduct(Guid id)
        {
            try
            {
                var product = _context.Products.Find(id);
                if (product == null)
                {
                    return "Sản phẩm không tồn tại";
                }

                _context.Products.Remove(product);
                _context.SaveChanges();
                return "Xóa sản phẩm thành công";
            }
            catch (Exception e)
            {
                return "Xóa sản phẩm thất bại: " + e.Message;
            }
        }
        public string LockProduct(Guid id)
        {
            var product = _context.Products.Find(id);
            if (product.Status == 0) return "Sản phẩm đã bị khóa ,không thể khóa nữa";
            else
            {
                product.Status = 1;  // Đặt trạng thái là 1 để khóa sản phẩm
                _context.Products.Update(product);
                _context.SaveChanges();
                return "Khóa sản phẩm thành công";
            }
        }
        public string UnLockProduct(Guid id)
        {
            var product = _context.Products.Find(id);
            if (product.Status != 0) return "Sản phẩm không bị khóa,không thể mở khóa";
            else
            {
                product.Status = 0;  // Đặt trạng thái là 0 để mở khóa sản phẩm
                _context.Products.Update(product); 
                _context.SaveChanges();
                return "Khóa sản phẩm thành công";
            }
        }

        // Phương thức kiểm tra số lượng hiện có của sản phẩm
        public int GetSLActive(Guid productId)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
            {
                return product.TotalAmount; // Trả về số lượng hiện có của sản phẩm
            }
            else
            {
                throw new Exception("Sản phẩm không tồn tại");
            }
        }


        // Phương thức để cập nhật số lượng kho sau khi bán hàng
        public string UpdateSL(Guid productId, int quantityToReduce)
        {
            try
            {
                // Tìm sản phẩm theo ID
                var product = _context.Products.Find(productId);

                // Kiểm tra nếu sản phẩm tồn tại
                if (product == null)
                {
                    return "Sản phẩm không tồn tại.";
                }

                // Kiểm tra số lượng cần giảm hợp lệ
                if (quantityToReduce <= 0)
                {
                    return "Số lượng cần giảm phải lớn hơn 0.";
                }

                // Kiểm tra số lượng hiện có có đủ để giảm
                if (product.TotalAmount < quantityToReduce)
                {
                    return "Số lượng trong kho không đủ.";
                }

                // Trừ số lượng trong kho
                product.TotalAmount -= quantityToReduce;

                // Cập nhật sản phẩm trong cơ sở dữ liệu
                _context.Products.Update(product);
                _context.SaveChanges();

                return "Cập nhật số lượng sản phẩm thành công.";
            }
            catch (Exception ex)
            {
                // Log lỗi hoặc xử lý lỗi tại đây
                return "Lỗi khi cập nhật số lượng sản phẩm: " + ex.Message;
            }
        }
    }

}
