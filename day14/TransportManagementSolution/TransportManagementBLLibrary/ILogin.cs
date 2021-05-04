using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportManagementBLLibrary
{
    public interface ILogin<T>
    {
        bool Login(T t);
        void Add(T t);
    }
}
