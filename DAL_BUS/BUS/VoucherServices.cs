using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
    public class VoucherServices
    {
        AppDbContext _context;
        public VoucherServices()
        {
            _context = new AppDbContext();
        }
        public List<Voucher> GetAllVoucher()
        {
            return _context.Vouchers.ToList();
        }
        public string CreateVoucher(Voucher voucher)
        {
            // Validate
            if (voucher.EndDate < DateTime.Now || voucher.StarDate > voucher.EndDate)
            {
                return "Kiểm tra lại thời hạn của chương trình khuyến mãi";
            }
            else if (voucher.Value < 0)
            {
                return "Không thể giảm giá âm";
            }
            else if (_context.Vouchers.Any(s => s.Name == voucher.Name))
            {
                return "Tên khuyến mãi đã tồn tại";
            }
            else
            {
                try
                {
                    _context.Vouchers.Add(voucher);
                    _context.SaveChanges();
                    return "Thêm khuyến mãi thành công";
                }
                catch (Exception e)
                {
                    return "Thêm khuyến mãi thất bại" + e.Message;
                }
            }
        }
       
        public string UpdateVoucher(Voucher voucher)
        {
            if (voucher.EndDate < DateTime.Now || voucher.StarDate > voucher.EndDate)
            {
                return "Kiểm tra lại thời hạn của chương trình khuyến mãi";
            }
            else if (voucher.Value < 0)
            {
                return "Không thể giảm giá âm";
            }
            else
            if (_context.Vouchers.Any(s => s.Name == voucher.Name && s.Id != voucher.Id))
            {
                return "Tên khuyến mãi đã tồn tại";
            }
            else
            {
                //try
                //{
                var update = _context.Vouchers.Find(voucher.Id);
                update.Name = voucher.Name;
                update.Description = voucher.Description;
                update.Value = voucher.Value;
                update.StarDate = voucher.StarDate;
                update.EndDate = voucher.EndDate;
                update.Status = voucher.Status;
                _context.Vouchers.Update(update);
                _context.SaveChanges();
                return "Sửa khuyến mãi thành công";
                //}
                //catch (Exception e)
                //{
                //    return "Sửa khuyến mãi thất bại" + e.Message;
                //}
            }
        }
        public string DeleteVoucher(string id)
        {
            try
            {
                var voucher = _context.Vouchers.Find(id);
                if (voucher == null)
                {
                    return "Khuyến mãi không tồn tại";
                }

                _context.Vouchers.Remove(voucher);
                _context.SaveChanges();
                return "Xóa khuyến mãi thành công";
            }
            catch (Exception e)
            {
                return "Xóa khuyến mãi thất bại: " + e.Message;
            }
        }
        public List<Voucher> GetActiveVoucher()
        {
            return _context.Vouchers.Where(p => p.StarDate <= DateTime.Now
            && p.EndDate >= DateTime.Now && p.Status == 1).ToList();
        }
    }
}
