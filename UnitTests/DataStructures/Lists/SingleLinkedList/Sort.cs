using DataStructures.Lists;

namespace UnitTests.DataStructures.Lists.SingleLinkedList
{
    public class Sort
    {
        [Fact]
        public void SLLWontSortOnEmptyLists()
        {
            var sll = new SingleLinkedList<int>();


            var beforeSort = sll.ToArray();

            sll.Sort(null);

            Assert.Equal(beforeSort, sll.ToArray());
        }

        [Fact]
        public void SLLCanSort()
        {
            var sll = new SingleLinkedList<int>();

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
    }
}

