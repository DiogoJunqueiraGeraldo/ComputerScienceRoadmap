namespace DataStructures.Lists
{
    public class SinglyLinkedList<T>
    {
        private SinglyLinkedListNode<T>? head;
        private SinglyLinkedListNode<T>? tail;
        public uint Size { get; private set; }

        public SinglyLinkedList()
        {
            Size = 0;
            head = null;
            tail = null;
        }

        private SinglyLinkedListNode<T>? FindAt(uint index)
        {
            var curr = head;
            for (uint i = 1; i < index; i++)
            {
                curr = curr.Next;
            }

            return curr;
        }

        public T[] ToArray()
        {
            var arr = new T[Size];

            var curr = head;

            for(uint i = 0; i < arr.Length; i++)
            {
                arr[i] = curr.Value;
                curr = curr.Next;
            }

            return arr;
        }

        public void Reverse()
        {
            if (Size < 2)
            {
                return;
            }

            var curr = head;
            var next = head.Next;

            tail = curr;
            tail.Next = null;

            while (next is not null)
            {
                var auxNext = next.Next;
                next.Next = curr;

                curr = next;
                next = auxNext;
            }

            head = curr;
        }

        public void InsertAtEnd(T value)
        {
            var node = new SinglyLinkedListNode<T>(value);

            if (head is null)
            {
                head = node;
            } else
            {
                tail.Next = node;
            }

            tail = node;

            Size++;
        }

        public void InsertAt(uint index, T value)
        {
            if (index <= 1)
            {
                InsertAtStart(value);

            }
            else if (index > Size)
            {
                InsertAtEnd(value);
            }
            else
            {
                // Insert at a position that is already fulfilled will replace the value at the position
                // and shift the already existing values to the right
                var node = new SinglyLinkedListNode<T>(value);
                var curr = FindAt(index -1);
                var next = curr.Next;

                curr.Next = node;
                node.Next = next;

                Size++;
            }
        }

        public void InsertAtStart(T value)
        {
            var node = new SinglyLinkedListNode<T>(value);
            node.Next = head;
            head = node;

            if(tail is null)
            {
                tail = node;
            }

            Size++;
        }

        public void DeleteAt(uint index)
        {
            if (index <= 1)
            {
                DeleteFirst();
            }
            else if (index >= Size)
            {
                DeleteLast();
            }
            else
            {
                var before = FindAt(index -1);
                before.Next = before.Next.Next;
                Size--;
            }
        }

        public void DeleteLast()
        {
            if (Size > 1)
            {
                var before = FindAt(Size - 1);
                before.Next = null;
                tail = before;
                Size--;
            }
            else
            {
                DeleteFirst();
            }
        }

        public void DeleteFirst()
        {
            if(Size == 0)
            {
                return;
            }

            head = head.Next;

            if (head is null)
            {
                tail = null;
            }

            Size--;
        }

        public T ValueAt(uint index)
        {
            if(index < 1 || index > Size)
            {
                throw new IndexOutOfRangeException("Out of bounds");
            }

            var curr = FindAt(index);
            return curr.Value;
        }

        /// <param name="isGreaterThan">Returns if the first param is greater than the second</param>
        /// <param name="asc">Sort in ascending order</param>
        public void Sort(Func<T, T, bool> isGreaterThan, bool asc = true)
        {
            if(head == null)
            {
                return;
            }

            var curr = head;

            while(curr != null)
            {
                var aux = curr.Next;

                while(aux != null)
                {
                    var shouldSwap = asc == isGreaterThan(curr.Value, aux.Value);

                    if (shouldSwap)
                    {
                        var tmp = curr.Value;
                        curr.Value = aux.Value;
                        aux.Value = tmp;
                    }
                    aux = aux.Next;
                }
                curr = curr.Next;
            }
        }
    }

    internal class SinglyLinkedListNode<T>
    {
        public T Value { set; get; }
        public SinglyLinkedListNode<T>? Next { get; set; }

        public SinglyLinkedListNode(T value, SinglyLinkedListNode<T>? next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
