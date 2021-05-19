using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRegister.Services
{
    public interface IUser<T>
    {
        bool Register(T t);
        bool Login(T t);
    }
}
