using System.Collections.Generic;

namespace StackAndQueue
{
    class MyQueue<T>
    {
        private List<T> items = new List<T>();
        public void Enqueue(T item)
        {
            items.Add(item);
        }
        public T Dequeue()
        {
            T item = items[0];

            items.Remove(items[0]);

            return item;
        }
    }
}
