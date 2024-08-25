using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
    public class AccountServices
    {
        AppDbContext _context;
        public AccountServices()
        {
            _context = new AppDbContext();
        }
        public string Login (string username,string password)
        {
            var account = _context.Accounts.FirstOrDefault(p => p.Username == username && p.Password == password);
            if(account == null)
            {
                return "";
            }else
            {
                return account.Role + ":" + account.Username;
            }
        }
        public string CreateAccount(string username,string password,int role)
        {
            try
            {
                Account account = new Account()
                {
                    Username = username,
                    Password = password,
                    Role = role
                };
                if (_context.Accounts.Any(s => s.Username == account.Username))
                {
                    return "Tên khuyến mãi đã tồn tại";
                }
                _context.Accounts.Add(account);
                _context.SaveChanges();
                return "Tạo thành công";
            }
            catch (Exception e)
            {
                return "Tạo thất bại " + e.Message;
            }
        }
        public List<Account> GetAll() // lấy all danh sách account
        {
            return _context.Accounts.ToList();
        }
        public string LockAccount(string username)
        {
            var account = _context.Accounts.Find(username); //tìm user bị khóa
            if (account.Role == 1)
            {
                return " Không thể khóa tài khoản admin";
            }else if(account.Role == 0)
            {
                return "Không thể khóa thêm, tài khoản đã bị khóa";
            }
            account.Role = 0; // tự hiểu 0 là khóa
            try
            {
                _context.Accounts.Update(account);
                _context.SaveChanges();
                return "Đã khóa tài khoản" + username;
            }
            catch (Exception e)
            {
                return " Khóa thất bại" + e.Message;
            }
        }
        public string UnLockAccount(string username)
        {
            var account = _context.Accounts.Find(username); //tìm user bị khóa
            if(account.Role != 0)
            {
                return "Không thể mở khóa tài khoản không bị khóa";
            }
            account.Role = 2; // tự hiểu 2 là nv trong db
            try
            {
                _context.Accounts.Update(account);
                _context.SaveChanges();
                return "Đã mở khóa tài khoản" + username;
            }
            catch (Exception e)
            {
                return "Mở khóa thất bại" + e.Message;
            }
        }
        public string UpdateAccount(string username, string password, int status)
        {
            var account = _context.Accounts.Find(username);
            if(account == null)
            {
                return " Không tìm thấy tài khoản cần sửa";
            }
            try
            {
                account.Password = password;
                account.Role = status;
                _context.Accounts.Update(account);
                _context.SaveChanges();
                return "Sửa thành công" + username;
            }
            catch (Exception e)
            {
                return "Sửa thất bại " + e.Message;
            }
        }




        public string ValidateAccount(string username)
        {
            var account = _context.Accounts.FirstOrDefault(p => p.Username == username);
            if (account == null)
            {
                return "Tài khoản không tồn tại.";
            }
            else
            {
                return "Tài khoản tồn tại. Bạn có thể đổi mật khẩu.";
            }
        }
        public string ChangePassword(string username, string newPassword) // QMK
        {
            var account = _context.Accounts.FirstOrDefault(p => p.Username == username);
            if (account == null)
            {
                return "Tài khoản không tồn tại.";
            }
            try
            {
                account.Password = newPassword;
                _context.Accounts.Update(account);
                _context.SaveChanges();
                return "Đổi mật khẩu thành công.";
            }
            catch (Exception e)
            {
                return "Đổi mật khẩu thất bại: " + e.Message;
            }
        }
    }
}
