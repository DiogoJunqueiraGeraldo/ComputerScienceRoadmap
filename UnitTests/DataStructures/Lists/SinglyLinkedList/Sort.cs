using DataStructures.Lists;

namespace UnitTests.DataStructures.Lists.SinglyLinkedList
{
    public class Sort
    {
        [Fact]
        public void SLLWontSortOnEmptyLists()
        {
            var sll = new SinglyLinkedList<int>();


            var beforeSort = sll.ToArray();


            sll.Sort(null);

            Assert.Equal(beforeSort, sll.ToArray());
        }

        [Fact]
        public void SLLCanSortOnAscendingOrderByDefault()
        {
            var sll = new SinglyLinkedList<int>();

            sll.InsertAtEnd(3);
            sll.InsertAtEnd(1);
            sll.InsertAtEnd(5);
            sll.InsertAtEnd(-2);
            sll.InsertAtEnd(76);

            sll.Sort((a, b) =>
            {
                return a > b;
            });

            Assert.Equal(new int[] { -2, 1, 3, 5, 76 }, sll.ToArray());
        }

        [Fact]
        public void SLLCanSortOnDescendingOrder()
        {
            var sll = new SinglyLinkedList<int>();

            sll.InsertAtEnd(3);
            sll.InsertAtEnd(1);
            sll.InsertAtEnd(5);
            sll.InsertAtEnd(-2);
            sll.InsertAtEnd(76);

            sll.Sort((a, b) =>
            {
                return a > b;
            }, false);

            Assert.Equal(new int[] { 76, 5, 3, 1, -2 }, sll.ToArray());
        }
    }
}

