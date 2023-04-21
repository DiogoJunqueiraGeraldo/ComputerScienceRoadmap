namespace DataStructures.Lists.Stack
{
    public class ArrayStack<T>
    {
        private T[] _array;
        private uint _capacity;
        private uint _top;
        public uint Size { get => _top; private set { } }

        public ArrayStack(uint capacity = 10)
        {
            _capacity = capacity;
            _top = 0;
            _array= new T[capacity];
        }

        public bool IsEmpty()
        {
            return _top == 0;
        }

        public void Push(T item) {
            if(_top == _capacity)
            {
                var tmp = _array;
                _capacity = _capacity * 2;
                _array = new T[_capacity];
                
                for(var i = 0; i < tmp.Length; i++)
                {
                    _array[i] = tmp[i];
                }
            }

            _array[_top++] = item;
        }

        public T Pop()
        {
            if(IsEmpty())
            {
                throw new IndexOutOfRangeException("Can't pop an empty stack");
            }

            var item = _array[_top -1];
            _array[_top--] = default(T);
            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("Can't peek an empty stack");
            }

            return _array[_top -1];
        }
    }
}
