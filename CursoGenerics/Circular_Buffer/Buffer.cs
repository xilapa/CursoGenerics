using System;
using System.Collections;
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

        bool IBuffer<T>.IsEmpty => throw new NotImplementedException();

        public virtual T Read()
        {
            return queue.Dequeue();
        }

        public virtual void Write(T value)
        {
            queue.Enqueue(value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in queue)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
