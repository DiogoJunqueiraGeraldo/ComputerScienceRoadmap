using DataStructures.Lists;

namespace UnitTests.DataStructures.Lists.Stack
{
    public class Peek
    {
        [Fact]
        public void SLLStackCanPeek()
        {
            var slls = new SLLStack<int>();

            slls.Push(1);
            slls.Push(2);

            Assert.Equal(2, slls.Peek());
        }
    }
}
