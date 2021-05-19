using Microsoft.EntityFrameworkCore;
using MvcRegister.Models;
using MvcRegister.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MvcRegister.Services
{
    public class UserService : IUser<UserModel>
    {
        private readonly UserContext _context;
        public UserService()
        {
        }
        public UserService(UserContext context)
        {
            _context = context;
        }

        public bool Login(UserModel t)
        {
            try
            {
                UserModel user = _context.Users.SingleOrDefault(u => u.Username == t.Username);
                if (user.password == t.password)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            return false;

        }

        public bool Register(UserModel t)
        {
            try
            {
                _context.Users.Add(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
    }
}
