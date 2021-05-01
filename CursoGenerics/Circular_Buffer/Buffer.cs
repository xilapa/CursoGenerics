using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGenerics.Circular_Buffer
{
    public class Buffer<T> : IBuffer<T>
    {
        private Queue<T> queue = new();

        public bool IsEmpty => queue.Count == 0;

        public T Read()
        {
            return queue.Dequeue();
        }

        public void Write(T value)
        {
            queue.Enqueue(value);
        }
    }
}
