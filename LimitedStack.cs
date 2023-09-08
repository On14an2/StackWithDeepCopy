namespace StackQuestion
{
    public class LimitedStack<T>
    {
        private readonly int maxSize;
        private LinkedList<T> list;

        public bool IsEmpty => list.Count == 0;
        public int Count => list.Count;

        public LimitedStack(int maxSize)
        {
            this.maxSize = maxSize;
            list = new LinkedList<T>();
        }
        public LimitedStack(LimitedStack<T> other)
        {
            maxSize = other.maxSize;
            list = new LinkedList<T>(other.list);
        }

        public void Push(T item)
        {
            if (list.Count == maxSize)
            {
                throw new InvalidOperationException("Stack is full");
            }

            list.AddLast(item);
        }

        public T Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T item = list.Last.Value;
            list.RemoveLast();
            return item;
        }
    }
}