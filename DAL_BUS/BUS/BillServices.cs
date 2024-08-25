using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
    public class BillServices
    {
        AppDbContext _context;
        public BillServices()
        {
            _context = new AppDbContext();
        }
        public List<Bill> GetAllBills() // Tất cả các HD
        {
            return _context.Bills.ToList();
        }
        public List<Bill> GetWaitBill() // Hóa đơn chờ
        {
            return _context.Bills.Where(p => p.Status == 0).ToList();
        }
        public string Create(string accountID, string customerPhone,string voucherid)
        {
            // Kiểm tra nếu hóa đơn đã tồn tại trước khi tạo hóa đơn mới
            var existingBill = _context.Bills
                .FirstOrDefault(b => b.CustomerPhone == customerPhone && b.Status == 0);
            if (existingBill != null)
            {
                return "Hóa đơn đã tồn tại";
            }
            Bill bill = new Bill()
            {
                Id = Guid.NewGuid(),
                Status = 0,
                TotalMoney = 0,
                AccountId = accountID,
                CustomerPhone = customerPhone,
                CreateDate = DateTime.Now,
                VoucherId = voucherid
            };
            _context.Bills.Add(bill);
            _context.SaveChanges();
            return "Tạo thành công";
        }

        public string UpdateBill(Guid id, int status) // update trạng thái (thanh toán)
        {
            try
            {
                var bill = _context.Bills.Find(id);
                if (bill == null)
                {
                    return "Hóa đơn không tồn tại";
                }
                bill.Status = status;
                _context.SaveChanges();
                return "Update hóa đơn thành công";
            }
            catch (Exception)
            {
                return "Update hóa đơn thất bại";
            }
        }
        public string DeleteBill(Guid id) // Xóa kèm cả những hdct của nó nếu không không thể xóa đc
        {
            try
            {
                var allHDCT = _context.BillDetails.Where(p => p.BillId == id);
                _context.BillDetails.RemoveRange(allHDCT); // Xóa hết hóa đơn chi tiết liên quan
                _context.SaveChanges();

                // Xóa hóa đơn
                var Hd = _context.Bills.Find(id);
                if (Hd == null)
                {
                    return "Hóa đơn không tồn tại";
                }
                _context.Bills.Remove(Hd);
                _context.SaveChanges();
                return "Xóa thành công";
            }
            catch (Exception)
            {
                return "Xóa hóa đơn thất bại";
            }
        }

        public long CalculateTotalMoney(Guid billId)
        {
            // Lấy tất cả các chi tiết hóa đơn cho hóa đơn cụ thể
            var billDetails = _context.BillDetails.Where(detail => detail.BillId == billId).ToList();

            // Tính tổng tiền từ các chi tiết hóa đơn
            long totalPrice = billDetails.Sum(detail => detail.Price * detail.Amount);

            return totalPrice;
        }
        public string UpdateTotalPrice(Guid billId, int status)
        {
            try
            {
                // Tính tổng tiền cho hóa đơn
                long totalMoney = CalculateTotalMoney(billId);

                // Lấy hóa đơn và cập nhật tổng tiền
                var bill = _context.Bills.Find(billId);
                if (bill == null)
                {
                    return "Hóa đơn không tồn tại";
                }
                bill.TotalMoney = totalMoney;
                _context.SaveChanges();
                bill.Status = status;
                _context.SaveChanges();
                return "Cập nhật tổng tiền thành công";
            }
            catch (Exception)
            {
                return "Cập nhật tổng tiền thất bại";
            }
        }


        public long CaculateBill(Guid billId)
        {
            var hdct = _context.BillDetails.Where(p=>p.BillId == billId).ToList();
            long sum = 0;
            foreach (var item in hdct)
            {
                sum += (long)item.Price * (long)item.Amount;
            }
            return sum;
        }

        public string UpdateTotalMoney(Guid billid,int trangthai,long totalMoney) //Cach2 như c1
        {
            try
            {
                var hd = _context.Bills.Find(billid);
                hd.Status = trangthai;
                if(hd != null)
                {
                    hd.TotalMoney = totalMoney;
                    _context.SaveChanges();
                }
                _context.SaveChanges();
                return "Cập nhật đơn hàng thành công";
            }
            catch (Exception)
            {
                return "Cập nhật đơn hàng Thất bại";
            }
        }
    }
}
