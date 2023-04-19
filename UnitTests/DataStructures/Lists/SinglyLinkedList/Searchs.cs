using DataStructures.Lists;

namespace UnitTests.DataStructures.Lists.SinglyLinkedList
{
    public class Searchs
    {
        [Fact]
        public void SLLCanSearchValueByPosition()
        {
            var sll = new SinglyLinkedList<int>();

            sll.InsertAtEnd(1);
            sll.InsertAtEnd(2);
            sll.InsertAtEnd(3);
            sll.InsertAtEnd(999); 
            sll.InsertAtEnd(5);
            sll.InsertAtEnd(6);

            var value = sll.ValueAt(4);
            Assert.Equal(999, value);
        }

        [Fact]
        public void SLLThrowsIndexOutOfRangeExceptionToAvoidNullReturnsOnZeroIndexSearch()
        {
            var sll = new SinglyLinkedList<int>();

            sll.InsertAtEnd(1);
            sll.InsertAtEnd(2);

            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                sll.ValueAt(0);
            });
        }

        [Fact]
        public void SLLThrowsIndexOutOfRangeExceptionToAvoidNullReturnOnIndexesGreaterThanTheSize()
        {
            var sll = new SinglyLinkedList<int>();

            sll.InsertAtEnd(1);
            sll.InsertAtEnd(2);

            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                sll.ValueAt(sll.Size + 1);
            });
        }
    }
}
