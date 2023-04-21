using DataStructures.Lists.Stack;

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

        [Fact]
        public void ArrayStackInitializeEmpty()
        {
            var arrs = new ArrayStack<int>();

            Assert.True(arrs.IsEmpty());
            Assert.Equal<uint>(0, arrs.Size);
        }

        [Fact]
        public void ArrayStackThrowsExceptionWhenTryingToPopWhenItsEmpty()
        {
            var arrs = new ArrayStack<int>();

            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                arrs.Pop();
            });
        }

        [Fact]
        public void ArrayStackThrowsExceptionWhenTryingToPeekpWhenItsEmpty()
        {
            var arrs = new ArrayStack<int>();

            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                arrs.Peek();
            });
        }
    }
}
