﻿using DataStructures.Lists.Stack;

namespace UnitTests.DataStructures.Lists.Stack
{
    public class Push
    {
        [Fact]
        public void SLLStackCanPush()
        {
            var slls = new SLLStack<int>();

            slls.Push(1);

            Assert.Equal(1, slls.Pop());

            slls.Push(2);

            Assert.Equal(2, slls.Peek());
        }

        [Fact]
        public void ArrayStackCanPush()
        {
            var arrs = new ArrayStack<int>();

            arrs.Push(1);

            Assert.Equal(1, arrs.Pop());

            arrs.Push(2);

            Assert.Equal(2, arrs.Peek());
        }
    }
}
