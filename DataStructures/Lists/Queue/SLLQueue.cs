namespace DataStructures.Lists.Queue
{
    public class SLLQueue<T>
    {
        private SinglyLinkedList<T> sll;
        public uint Size { get => sll.Size; private set { }  }

        public SLLQueue()
        {
            sll = new SinglyLinkedList<T>();
        }

        public bool IsEmpty()
        {
            return sll.Size == 0;
        }

        public void Enqueue(T item)
        {
            sll.InsertAtEnd(item);
        }

        public T Dequeue()
        {
            if(IsEmpty())
            {
                throw new IndexOutOfRangeException("Can't dequeue an empty queue");
            }

            var item = sll.ValueAt(1);
            sll.DeleteFirst();
            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("Can't peek an empty queue");
            }

            return sll.ValueAt(1);
        }
    }
}
