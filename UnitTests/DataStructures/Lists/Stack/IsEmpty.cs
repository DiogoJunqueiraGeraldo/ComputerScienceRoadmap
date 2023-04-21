using DataStructures.Lists;

namespace UnitTests.DataStructures.Lists.Stack
{
    public class IsEmpty
    {
        [Fact]
        public void SLLStackInitializeEmpty()
        {
            var slls = new SLLStack<int>();

            Assert.True(slls.IsEmpty());
            Assert.Equal<uint>(0, slls.Size);
        }

        [Fact]
        public void SLLStackThrowsExceptionWhenTryingToPopWhenItsEmpty()
        {
            var slls = new SLLStack<int>();

            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                slls.Pop();
            });
        }

        [Fact]
        public void SLLStackThrowsExceptionWhenTryingToPeekpWhenItsEmpty()
        {
            var slls = new SLLStack<int>();

            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                slls.Peek();
            });
        }
    }
}
