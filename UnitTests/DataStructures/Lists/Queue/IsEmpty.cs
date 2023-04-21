using DataStructures.Lists.Queue;

namespace UnitTests.DataStructures.Lists.Queue
{
    public class IsEmpty
    {
        [Fact]
        public void SLLQueueInitializeEmpty()
        {
            var sllq = new SLLQueue<int>();

            Assert.True(sllq.IsEmpty());
            Assert.Equal<uint>(0, sllq.Size);
        }

        [Fact]
        public void SLLQueueThrowsAnErrorWhenDequeueFromEmptyQueue()
        {
            var sllq = new SLLQueue<int>();

            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                sllq.Dequeue();
            });
        }

        [Fact]
        public void SLLQueueThrowsAnErrorWhenPeekingFromEmptyQueue()
        {
            var sllq = new SLLQueue<int>();

            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                sllq.Peek();
            });
        }
    }
}
