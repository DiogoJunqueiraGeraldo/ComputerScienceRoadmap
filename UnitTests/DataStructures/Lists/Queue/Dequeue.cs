using DataStructures.Lists.Queue;

namespace UnitTests.DataStructures.Lists.Queue
{
    public class Dequeue
    {
        [Fact]
        public void SLLQueueCanDequeue()
        {
            var sllq = new SLLQueue<int>();

            sllq.Enqueue(1);
            sllq.Enqueue(2);
            sllq.Enqueue(3);

            Assert.Equal<uint>(3, sllq.Size);

            Assert.Equal(1, sllq.Dequeue());
            Assert.Equal(2, sllq.Dequeue());
            Assert.Equal(3, sllq.Dequeue());

            Assert.Equal<uint>(0, sllq.Size);
        }
    }
}

