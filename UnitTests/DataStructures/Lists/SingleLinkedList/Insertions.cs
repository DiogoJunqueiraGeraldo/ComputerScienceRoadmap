using DataStructures.Lists;

namespace UnitTests.DataStructures.Lists.SingleLinkedList
{
    public class Insertions
    {
        [Fact]
        public void SLLCanInsertAtStartOnEmptyList()
        {
            var sll = new SingleLinkedList<int>();

            sll.InsertAtStart(1);

            Assert.Equal(new int[] { 1 }, sll.ToArray());
        }

        [Fact]
        public void SLLCanInsertAtStart()
        {
            var sll = new SingleLinkedList<int>();

            sll.InsertAtStart(3);
            sll.InsertAtStart(2);
            sll.InsertAtStart(1);
            
            Assert.Equal(new int[] { 1, 2, 3 }, sll.ToArray());
        }

        [Fact]
        public void SLLCanInsertAtEndOnEmptyList()
        {
            var sll = new SingleLinkedList<int>();

            sll.InsertAtEnd(1);

            Assert.Equal(new int[] { 1 }, sll.ToArray());
        }

        [Fact]
        public void SLLCanInsertAtEnd()
        {
            var sll = new SingleLinkedList<int>();

            sll.InsertAtEnd(1);
            sll.InsertAtEnd(2);
            sll.InsertAtEnd(3);

            Assert.Equal(new int[] { 1, 2, 3 }, sll.ToArray());
        }

        [Fact]
        public void SLLCanInsertAtWhereverOnEmptyList()
        {
            var sll1 = new SingleLinkedList<int>();
            var sll2 = new SingleLinkedList<int>();

            sll1.InsertAt(uint.MinValue, 1);
            Assert.Equal(new int[] { 1 }, sll1.ToArray());

            sll2.InsertAt(uint.MaxValue, 1);
            Assert.Equal(new int[] { 1 }, sll2.ToArray());
        }

        [Fact]
        public void SLLCanInsertAtWillInsertAtStartWithIndexLowerOrEqualToOne()
        {
            var sll = new SingleLinkedList<int>();

            sll.InsertAt(0, 1);
            Assert.Equal(new int[] { 1 }, sll.ToArray());

            sll.InsertAt(1, 0);
            Assert.Equal(new int[] { 0, 1 }, sll.ToArray());
        }

        [Fact]
        public void SLLInsertAtWillInsertAtEndWithIndexGreaterOrEqualToSize()
        {
            var sll = new SingleLinkedList<int>();
            sll.InsertAtStart(1);

            sll.InsertAt(2, 2);
            Assert.Equal(new int[] { 1, 2 }, sll.ToArray());

            sll.InsertAt(uint.MaxValue, 3);
            Assert.Equal(new int[] { 1, 2, 3 }, sll.ToArray());
        }

        [Fact]
        public void SLLInsertAtWillInsertAtIndexAndPushPreviousValueToRight()
        {
            var sll = new SingleLinkedList<int>();

            sll.InsertAtEnd(1);
            sll.InsertAtEnd(3);
            sll.InsertAtEnd(4);

            sll.InsertAt(2, 2);

            Assert.Equal(new int[] { 1, 2, 3, 4 }, sll.ToArray());
        }
    }
}
