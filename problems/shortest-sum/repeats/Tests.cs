using Xunit;

public class Tests
{
    [Fact]
    public void Should_NotCrash()
    {
        var result = new Solution().Main(new Node() { Value = 0, Children = new Node[0] });

        Assert.Equal(0, result);
    }
}
