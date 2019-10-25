using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleApplication
{
    interface IRepository<T>
    {
        void Add(T value);
        void Clear();
        IRepository<T> GetAll();
        T Get(int index);
    }
}
