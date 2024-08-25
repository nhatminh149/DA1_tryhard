using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
    public class CustomerServices
    {
        AppDbContext _context;
        public CustomerServices()
        {
            _context = new AppDbContext();
        }
        // Get ALl
        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }
        public List<Customer> GetByPhone(string phoneNumber)
        {
            var check = _context.Customers.Where(p => p.PhoneNumber.Contains(phoneNumber)).ToList();
            return _context.Customers.Where(p => p.PhoneNumber.Contains(phoneNumber)).ToList();
        } // Danh sách chứa để add Vào combobox khi muốn tìm kiếm
        // Tạo mới
       
            public string Create(string phoneNumber, string name, int point)
            {
                
                var existingCustomer = _context.Customers.FirstOrDefault(c => c.PhoneNumber == phoneNumber);
                if (existingCustomer != null)
                {
                    return "Khách hàng với số điện thoại này đã tồn tại.";
                }

                Customer customer = new Customer()
                {
                    PhoneNumber = phoneNumber,
                    Name = name,
                    Point = point
                };

                try
                {
                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                    return "Tạo mới khách hàng thành công.";
                }
                catch (Exception e)
                {
                    return "Đã xảy ra lỗi khi tạo mới khách hàng: " + e.Message;
                }
            }
        
        public string Update(string phoneNumber, string name, int point)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.PhoneNumber == phoneNumber);
            if (customer != null)
            {
                customer.Name = name;
                customer.Point = point;
                _context.Customers.Update(customer);
                _context.SaveChanges();
                return "Cập nhật thông tin khách hàng thành công.";
            }
            else
            {
                return "Không tìm thấy khách hàng với số điện thoại này.";
            }
        }

        public bool CheckCustomerExistsByPhone(string phoneNumber)
        {
            return _context.Customers.Any(c => c.PhoneNumber == phoneNumber);
        }
    }
}
