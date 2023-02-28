using Xunit;

public class Tests
{
    [Fact]
    public void Should_NotCrash()
    {
        var result = new Solution().Main();

        Assert.Equal(0, result);
    }
}
