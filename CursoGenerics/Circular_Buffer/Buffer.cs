using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGenerics.Circular_Buffer
{
    public class Buffer<T> : IBuffer<T>
    {
        protected Queue<T> queue = new();

        public virtual bool IsEmpty => queue.Count == 0;

        public virtual T Read()
        {
            return queue.Dequeue();
        }

        public virtual void Write(T value)
        {
            queue.Enqueue(value);
        }
    }
}
