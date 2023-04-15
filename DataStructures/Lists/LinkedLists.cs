using System.Collections.Generic;
using System.Xml.Linq;

namespace DataStructures.Lists
{
    public class SingleLinkedList<T>
    {
        private SingleLinkedListNode<T>? head;
        private SingleLinkedListNode<T>? tail;
        public uint Size { get; private set; }

        public SingleLinkedList() {
            Size = 0;
            head = null;
            tail = null;
        }

        public void Reverse()
        {
            if(Size < 2)
            {
                return;
            }

            var curr = head;
            var next = head.Next;

            tail = curr;
            tail.Next = null;

            while(next is not null)
            {
                var auxNext = next.Next;
                next.Next = curr;

                curr = next;
                next = auxNext;
            }

            head = curr;
        }

        public void Insert(T value)
        {
            var node = new SingleLinkedListNode<T>(value);

            if (head is null)
            {
                head = node;
                tail = node;
            }

            tail.Next = node;
            tail = node;
            Size++;
        }

        public void InsertAt(uint index, T value)
        {
            if(index == 1)
            {
                // Insert at first position will switch the head
                InsertAtStart(value);
            
            } else if(index > Size)
            {
                // Insert at a position greater than the list will append the value at the end
                Insert(value);
            }
            else
            {
                // Insert at a position that is already fulfilled will 
                // replace the value at the position and shift the already existing values to the right
                var curr = head;
                var node = new SingleLinkedListNode<T>(value);
                for(uint i = 1; i < index -1; i++)
                {
                    curr = curr.Next;
                }

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
            Size++;
        }

        // Deletion
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

        public void InsertAfter(T value)
        {
            Next = new SingleLinkedListNode<T>(value, Next);
        }
    }
}
