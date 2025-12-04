using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdManagementSys
{
    public interface Irepository<T>
    {
        void Add(T obj);
        void Delete(int id);
        void Update(T obj);
        T GetById(int id);
        List<T> GetAll();

    }
}
