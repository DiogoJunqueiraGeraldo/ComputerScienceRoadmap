﻿using DataStructures.Lists;

namespace UnitTests.DataStructures.Lists.Stack
{
    public class Pop
    {
        [Fact]
        public void SLLStackCanPop()
        {
            var slls = new SLLStack<int>();

            slls.Push(1);
            slls.Push(2);

            Assert.Equal(2, slls.Pop());
            Assert.Equal(1, slls.Pop());

            Assert.True(slls.IsEmpty());
        }
    }
}
