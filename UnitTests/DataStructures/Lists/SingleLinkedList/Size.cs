using DataStructures.Lists;

namespace UnitTests.DataStructures.Lists.SingleLinkedList
{
    public class Size
    {
        [Fact]
        public void SLLIsCreatedEmpty()
        {
            var sll = new SingleLinkedList<int>();
            Assert.Equal<uint>(0, sll.Size);
            Assert.Equal(new int[] { }, sll.ToArray());
        }

        [Fact]
        public void SLLInsertOperationsUpdateTheSize() {
            var sll = new SingleLinkedList<int>();

            sll.InsertAtStart(1);
            Assert.Equal<uint>(1, sll.Size);

            sll.InsertAtEnd(3);
            Assert.Equal<uint>(2, sll.Size);

            sll.InsertAt(2, 2);
            Assert.Equal<uint>(3, sll.Size);
        }

        [Fact]
        public void SLLDeleteOperationsUpdateTheSize()
        {
            var sll = new SingleLinkedList<int>();

            sll.InsertAtEnd(1);
            sll.InsertAtEnd(2);
            sll.InsertAtEnd(3);
            sll.InsertAtEnd(4);
            Assert.Equal<uint>(4, sll.Size);

            sll.DeleteFirst();
            Assert.Equal<uint>(3, sll.Size);

            sll.DeleteLast();
            Assert.Equal<uint>(2, sll.Size);

            sll.DeleteAt(2);
            Assert.Equal<uint>(1, sll.Size);
        }

        [Fact]
        public void SLLReverseOperationWontAffectItsSize()
        {
            var sll = new SingleLinkedList<int>();

            sll.InsertAtEnd(1);
            sll.InsertAtEnd(2);
            sll.InsertAtEnd(3);
            Assert.Equal<uint>(3, sll.Size);

            sll.Reverse();
            Assert.Equal<uint>(3, sll.Size);
        }
    }
}
