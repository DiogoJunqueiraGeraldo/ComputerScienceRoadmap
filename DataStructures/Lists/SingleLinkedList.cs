namespace DataStructures.Lists
{
    public class SingleLinkedList<T>
    {
        private SingleLinkedListNode<T>? head;
        private SingleLinkedListNode<T>? tail;
        public uint Size { get; private set; }

        public SingleLinkedList()
        {
            Size = 0;
            head = null;
            tail = null;
        }

        private SingleLinkedListNode<T>? FindAt(uint index)
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
            var node = new SingleLinkedListNode<T>(value);

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

        /// <summary>
        ///     InsertAt won't accept your index if it doesn't make sense
        ///     this design decision avoid throwing out of bounds
        ///     since this don't make sense on a Single Linked List.
        ///     
        ///     If there is already a value on the position, it will be pushed to the right.
        /// </summary>
        /// <param name="index">the position you want the value to be</param>
        /// <param name="value">an awesome value</param>
        public void InsertAt(uint index, T value)
        {
            if (index <= 1)
            {
                // Insert at first position will switch the head
                InsertAtStart(value);

            }
            else if (index > Size)
            {
                // Insert at a position greater than the list will InsertAtEnd the value at the end
                InsertAtEnd(value);
            }
            else
            {
                // Insert at a position that is already fulfilled will 
                // replace the value at the position and shift the already existing values to the right
                var node = new SingleLinkedListNode<T>(value);
                var curr = FindAt(index -1);
                var next = curr.Next;

                curr.Next = node;
                node.Next = next;

                Size++;
            }
        }

        public void InsertAtStart(T value)
        {
            var node = new SingleLinkedListNode<T>(value);
            node.Next = head;
            head = node;

            if(tail is null)
            {
                tail = node;
            }

            Size++;
        }

        /// <summary>
        ///     DeleteAt won't accept your index if it doesn't make sense
        ///     this design decision avoid throwing out of bounds
        ///     since this don't make sense on a Single Linked List.
        ///     
        ///     Deleting on position 0 or 1 will delete the first element,
        ///     Deleting on a position greater than the size will delete the last element
        ///     
        ///     Be careful
        /// </summary>
        /// <param name="index">the position you want the value to be</param>
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

        // Search
        // Sort
    }

    /// <summary>
    /// Reference: https://archive.org/details/ucberkeley_webcast_htzJdKoEmO0
    /// </summary>
    /// <typeparam name="T">List generic data type</typeparam>
    internal class SingleLinkedListNode<T>
    {
        public T Value { init; get; }
        public SingleLinkedListNode<T>? Next { get; set; }

        public SingleLinkedListNode(T value, SingleLinkedListNode<T>? next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
