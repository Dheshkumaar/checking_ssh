using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFandLINQProject.Models
{
    public interface IRepo<T>
    {
        bool Add(T t);
        IList<T> GetAll();
        T Get(int id);
    }
}
