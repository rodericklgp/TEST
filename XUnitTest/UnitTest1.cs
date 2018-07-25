using System;
using Xunit;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact(DisplayName = "显示为通过测试")]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }
        [Fact(Skip = "显示为跳过测试")]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }
        [Fact(DisplayName = "显示为跳过测试123")]
        public void FailingTest1()
        {
            Assert.Equal(5, Add(2, 2));
        }

        [Theory]
        [InlineData(1, 2)]
        public void TheoryPassingTest(int a, int b)
        {
            Assert.Equal(3, Add(a, b));
        }
        [Theory]
        [InlineData(3, 4)]
        public void TheoryPassingTest2(int a, int b)
        {
            Assert.Equal(3, Add(a, b));
        }

        int Add(int x, int y)
        {
            return x + y;
        }


        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}
