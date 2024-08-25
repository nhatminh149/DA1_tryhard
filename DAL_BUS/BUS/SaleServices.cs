using DAL_BUS.DAL;
using DAL_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
    public class SaleServices
    {
        // Chú ý thời gian : ngày bắt đầu < ng kết thúc
        //tạo mới thì ngày bắt đầu là từ ngày hiện tại , kết thúc 0 thể trc ngày hiện tại
        // percent - % giảm phải từ 0 đến  100%
        AppDbContext _context;
        public SaleServices()
        {
            _context = new AppDbContext();
        }
        public List<Sale> GetAllSale()
        {
            return _context.Sales.ToList();
        }
        public string CreateSale(Sale sale)
        {

            if ( sale.EndDate < DateTime.Now || sale.StarDate > sale.EndDate)
            {
                return "Kiểm tra lại thời hạn của chương trình khuyến mãi";
            }
            else if(sale.Percent >100 || sale.Percent < 0)
            {
                return " % giảm không thể ngoài 0 - 100";
            }
            else if (_context.Sales.Any(s => s.Name == sale.Name))
            {
                return "Tên khuyến mãi đã tồn tại";
            }
            else
            {
                try
                {
                    _context.Sales.Add(sale);
                    _context.SaveChanges();
                    return "Thêm khuyến mãi thành công";
                }
                catch (Exception e)
                {
                    return "Thêm khuyến mãi thất bại" + e.Message;
                }
            }
        }
        public string UpdateSale(Sale sale)
        {
            // Validate
            if ( sale.EndDate < DateTime.Now || sale.StarDate > sale.EndDate)
            {
                return "Kiểm tra lại thời hạn của chương trình khuyến mãi";
            }
            else if (sale.Percent > 100 || sale.Percent < 0)
            {
                return " % giảm không thể ngoài 0 - 100";
            }
            else if (_context.Sales.Any(s => s.Name == sale.Name))
            {
                return "Tên khuyến mãi đã tồn tại";
            }
            else
            {
                //try
                //{
                var updatesale = _context.Sales.Find(sale.Id);
                updatesale.Name = sale.Name;
                updatesale.Description = sale.Description;
                updatesale.Percent = sale.Percent;
                updatesale.StarDate = sale.StarDate;
                updatesale.EndDate = sale.EndDate;
                updatesale.Status = sale.Status;
                _context.Sales.Update(updatesale);
                    _context.SaveChanges();
                    return "Sửa khuyến mãi thành công";
                //}
                //catch (Exception e)
                //{
                //    return "Sửa khuyến mãi thất bại" + e.Message;
                //}
            }
        }
        public string DeleteSale(Guid id)
        {
            try
            {
                var sale = _context.Sales.Find(id);
                if (sale == null)
                {
                    return "Khuyến mãi không tồn tại";
                }

                _context.Sales.Remove(sale);
                _context.SaveChanges();
                return "Xóa khuyến mãi thành công";
            }
            catch (Exception e)
            {
                return "Xóa khuyến mãi thất bại: " + e.Message;
            }
        }
        public List<Sale> GetActiveSale()
        {
            return _context.Sales.Where(p => p.StarDate <= DateTime.Now 
            && p.EndDate >= DateTime.Now && p.Status == 1).ToList();
        }
    }
}
