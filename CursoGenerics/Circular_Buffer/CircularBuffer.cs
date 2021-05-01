
namespace CursoGenerics.Circular_Buffer
{
    public class CircularBuffer<T> : Buffer<T>
    {
        private int capacity;

        public CircularBuffer(int capacity)
        {
            this.capacity = capacity;
        }

        public override void Write(T value)
        {
            base.Write(value);
            if (queue.Count > capacity)
                queue.Dequeue();
        }
    }
}
