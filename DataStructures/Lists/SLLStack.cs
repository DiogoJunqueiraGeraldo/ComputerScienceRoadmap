namespace DataStructures.Lists
{
    public class SLLStack<T>
    {
        private SinglyLinkedList<T> _sll;

        // virtual size
        public uint Size {
            get => _sll.Size;
        }
        
        public SLLStack() {
            _sll = new SinglyLinkedList<T>();
        }

        public void Push(T value)
        {
            _sll.InsertAtStart(value);
        }

        public T Peek() {
            if(IsEmpty())
            {
                throw new IndexOutOfRangeException("Can't peek an empty stack");
            }

            return _sll.ValueAt(1);
        }

        public T? Pop()
        {
            if(IsEmpty())
            {
                throw new IndexOutOfRangeException("Can't pop an empty stack");
            }

            var value = _sll.ValueAt(1);
            _sll.DeleteFirst();
            return value;
        }

        public bool IsEmpty()
        {
            return _sll.Size == 0;
        }
    }
}
