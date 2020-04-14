using Xunit;
using System;

public class PosNegDiceTests 
{
    [Fact]
    public void T1Test() 
    {
        var res = PosNegDice.evaluateRoll(4, new int[] {}, new int[] {});
        Assert.Equal(new int[] {0, 0}, res);
    }

    [Fact]
    public void T2Test()
    {
        var res = PosNegDice.evaluateRoll(1, new int[] {1, 6, 2}, new int[] {6});
        Assert.Equal(new int[] {1, 0}, res);
    }
     [Fact]
    public void T3Test()
    {
        var res = PosNegDice.evaluateRoll(4, new int[] {5, 6, 6, 5, 5}, new int[] {});
        Assert.Equal(new int[] {0, 0}, res);
    }

    [Fact]
    public void MyNotSoFailTest() 
    {
        var res = PosNegDice.evaluateRoll(2, new int[] {3}, new int[] {3});
        Assert.Equal(new int[] {0, 0}, res);
    }
    [Fact]
    public void MyFailTest() 
    {
        var res = PosNegDice.evaluateRoll(2, new int[] {2, 5, 6, 6}, new int[] {3, 3, 4, 5});
        Assert.Equal(new int[] {1, 3}, res);
    }
    [Fact]
    public void MyFailTest2() 
    {
        var res = PosNegDice.evaluateRoll(1, new int[] {1, 1, 1, 3}, new int[] {1, 3, 4, 6, 6, 6});
        Assert.Equal(new int[] {1, 4}, res);
    }
}