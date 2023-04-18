
using DataStructures.Lists;

namespace UnitTests.DataStructures.Lists.SingleLinkedList
{
    public class Deletes
    {
        [Fact]
        public void SLLWontDoAnythingPerformingDeleteOperationsOnAnEmptyList()
        {
            var sll = new SingleLinkedList<int>();

            sll.DeleteFirst();
            sll.DeleteLast();
            sll.DeleteAt(3);

            Assert.Equal<uint>(0, sll.Size);
            Assert.Equal(new int[] { }, sll.ToArray());
        }

        [Fact]
        public void SLLDeleteFirstOrDeleteLastOnListWithOnlyOneElementDoTheSameThing()
        {
            var sll1 = new SingleLinkedList<int>();

            sll1.InsertAtEnd(1);
            sll1.DeleteFirst();

            Assert.Equal(new int[] { }, sll1.ToArray());

            var sll2 = new SingleLinkedList<int>();

            sll2.InsertAtEnd(1);
            sll2.DeleteLast();

            Assert.Equal(new int[] { }, sll2.ToArray());
        }

        [Fact]
        public void SLLCanDeleteTheFirstElement()
        {
            var sll = new SingleLinkedList<int>();

            sll.InsertAtEnd(1);
            sll.InsertAtEnd(2);

            sll.DeleteFirst();
            Assert.Equal(new int[] { 2 }, sll.ToArray());
        }

        [Fact]
        public void SLLCanDeleteTheLastElement()
        {
            var sll = new SingleLinkedList<int>();

            sll.InsertAtEnd(1);
            sll.InsertAtEnd(2);

            sll.DeleteLast();
            Assert.Equal(new int[] { 1 }, sll.ToArray());
        }

        [Fact]
        public void SLLCanDeleteAtSpecifiedIndex()
        {
            var sll = new SingleLinkedList<int>();

            sll.InsertAtEnd(1);
            sll.InsertAtEnd(2);
            sll.InsertAtEnd(3);

            sll.DeleteAt(2);

            Assert.Equal(new int[] { 1, 3 }, sll.ToArray());
        }

        [Fact]
        public void SLLCanDeleteFirstWhenInputsZeroOrOneToDeleteAt()
        {
            var sll1 = new SingleLinkedList<int>();
            sll1.InsertAtEnd(1);
            sll1.InsertAtEnd(2);

            sll1.DeleteAt(0);
            Assert.Equal(new int[] { 2 }, sll1.ToArray());

            var sll2 = new SingleLinkedList<int>();
            sll2.InsertAtEnd(1);
            sll2.InsertAtEnd(2);

            sll2.DeleteAt(1);
            Assert.Equal(new int[] { 2 }, sll2.ToArray());
        }

        [Fact]
        public void SLLCanDeleteLastWhenInputsAreGreaterOrEqualToTheSizeOfTheList()
        {
            var sll = new SingleLinkedList<int>();

            sll.InsertAtEnd(1);
            sll.InsertAtEnd(2);
            sll.InsertAtEnd(3);

            sll.DeleteAt(uint.MaxValue);
            Assert.Equal(new int[] { 1, 2 }, sll.ToArray());

            sll.DeleteAt(2);
            Assert.Equal(new int[] { 1 }, sll.ToArray());
        }
    }
}


