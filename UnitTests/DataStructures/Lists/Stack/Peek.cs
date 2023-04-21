using DataStructures.Lists.Stack;

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

        [Fact]
        public void ArrayStackCanPeek()
        {
            var arrs = new ArrayStack<int>();

            arrs.Push(1);
            arrs.Push(2);

            Assert.Equal(2, arrs.Peek());
        }
    }
}
