using DataStructures.Lists.Stack;

namespace UnitTests.DataStructures.Lists.Stack
{
    public class Capacity
    {
        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000)]
        public void SLLStackCanGrowIndefinitely(uint size)
        {
            var slls = new SLLStack<int>();

            for(int i = 0; i < size; i++)
            {
                slls.Push(i);
            }

            Assert.Equal(size, slls.Size);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000)]
        public void ArrayStackCanGrowIndefinitely(uint size)
        {
            var arrs = new ArrayStack<int>();

            for (int i = 0; i < size; i++)
            {
                arrs.Push(i);
            }

            Assert.Equal(size, arrs.Size);
        }
    }
}
