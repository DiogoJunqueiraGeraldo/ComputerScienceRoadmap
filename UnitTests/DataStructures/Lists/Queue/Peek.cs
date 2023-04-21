using DataStructures.Lists.Queue;

namespace UnitTests.DataStructures.Lists.Queue
{
    public class Peek
    {
        [Fact]
        public void SLLQueueCanPeek()
        {
            var sllq = new SLLQueue<int>();

            sllq.Enqueue(1);

            Assert.Equal(1, sllq.Peek());
            Assert.Equal<uint>(1, sllq.Size);
        }
    }
}
