using System;
using Xunit;

namespace Div2
{
    
    public class BouncingBallTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(5.095, BouncingBall.getPosition(981, 10, 0, 1), 9);
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal(6.408564143658009, BouncingBall.getPosition(981, 10, 0, 2), 9);
        }
        [Fact]
        public void Test3()
        {
            Assert.Equal(1.5951180154118365, BouncingBall.getPosition(981, 10, 0, 47), 9);
        }
        [Fact]
        public void Test4()
        {
            Assert.Equal(6.081311391188509, BouncingBall.getPosition(981, 10, 8, 2), 9);
        }
        [Fact]
        public void Test5()
        {
            Assert.Equal(0.7952075484286876, BouncingBall.getPosition(981, 10, 8, 47), 9);
        }
        [Fact]
        public void Test6()
        {
            Assert.Equal(0.036079462357220954, BouncingBall.getPosition(1000, 10, 10, 50), 9);
        }
    }
}
