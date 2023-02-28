using Xunit;

public class Tests
{
    [Fact]
    public void GivenMultipleNodes_WhenBFSIsPerformed_ThenReturnValuesInBreadthFirstOrder()
    {
        // arrange (Given)
        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3, new List<Node> { node1, node2 });
        var node4 = new Node(4);
        var root = new Node(0, new List<Node> { node3, node4 });

        // act (When)
        var result = Solution.Main(root);

        Assert.Equal(new int[] { 0, 3, 4, 1, 2 }, result);
    }

    [Fact]
    public void GivenMultipleNodesWithDifferentChildStructure_WhenBFSIsPerformed_ThenReturnValuesInBreadthFirstOrder()
    {
        // arrange (Given)
        var node1 = new Node(1);
        var node2 = new Node(2, new List<Node> { node1 });
        var node3 = new Node(3);
        var node4 = new Node(4, new List<Node> { node2, node3 });
        var root = new Node(0, new List<Node> { node4 });

        // act (When)
        var result = Solution.Main(root);

        // assert (Then)
        Assert.Equal(new int[] { 0, 4, 2, 3, 1 }, result);
    }

    [Fact]
    public void GivenSingleNode_WhenBFSIsPerformed_ThenReturnItsValue()
    {
        // arrange (Given)
        var root = new Node(0);

        // act (When)
        var result = Solution.Main(root);

        // assert (Then)
        Assert.Equal(new int[] { 0 }, result);
    }
}

