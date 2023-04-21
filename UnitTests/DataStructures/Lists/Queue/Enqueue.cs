using DataStructures.Lists.Queue;

namespace UnitTests.DataStructures.Lists.Queue
{
    public class Enqueue
    {
        [Fact]
        public void SLLQueueCanEnqueueItems()
        {
            var sllq = new SLLQueue<int>();

            sllq.Enqueue(1);
            sllq.Enqueue(2);

            Assert.Equal<uint>(2, sllq.Size);
            Assert.Equal(1, sllq.Dequeue());
            Assert.Equal(2, sllq.Peek());
        }
    }
}
