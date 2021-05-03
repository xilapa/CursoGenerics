using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGenerics.Circular_Buffer
{
    public interface IBuffer<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }
        void Write(T value);
        T Read();

    }
}
