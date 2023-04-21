using DataStructures.Lists;

namespace UnitTests.DataStructures.Lists.Stack
{
    public class Push
    {
        [Fact]
        public void StackCanPush()
        {
            var slls = new SLLStack<int>();

            slls.Push(1);

            Assert.Equal(1, slls.Pop());

            slls.Push(2);

            Assert.Equal(2, slls.Peek());
        }
    }
}
