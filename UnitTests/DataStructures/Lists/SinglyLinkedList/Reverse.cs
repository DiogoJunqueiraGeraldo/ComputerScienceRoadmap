using DataStructures.Lists;

namespace UnitTests.DataStructures.Lists.SinglyLinkedList
{
    public class Reverse
    {
        [Fact]
        public void SLLCanReverseTheListValues()
        {
            var sll = new SinglyLinkedList<int>();

            sll.InsertAtEnd(3);
            sll.InsertAtEnd(2);
            sll.InsertAtEnd(1);

            sll.Reverse();

            Assert.Equal(new int[] { 1, 2, 3 }, sll.ToArray());
        }

        [Fact]
        public void SLLWontReverseAListWithLessThanTwoElements()
        {
            var sll = new SinglyLinkedList<int>();

            var emptyList = sll.ToArray();
            sll.Reverse();
            Assert.Equal(emptyList, sll.ToArray());

            sll.InsertAtEnd(1);
            var listWithOneElement = sll.ToArray();
            sll.Reverse();
            Assert.Equal(listWithOneElement, sll.ToArray());
        }
    }
}
