using System;
using Xunit;

namespace Project1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(1 == 1);
        }

        [Fact]
        public void Test2()
        {
            Assert.True(2 == 3);
        }
    }
}