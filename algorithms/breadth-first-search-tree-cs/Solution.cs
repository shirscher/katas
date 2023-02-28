public static class Solution 
{
    // Note: could also do many depth first traversals. Inefficient but doesn't use extra storage:
    // 1 Traverse once to get max depth
    // 2 For i = 1 to depth
    // 3   Traverse whole thing and only add when currentDepth == depth

    public static int[] Main(Node root) {
        var result = new List<int>();
        var queue = new Queue<Node>();

        queue.Enqueue(root);
        while (queue.TryDequeue(out var node)) {
            result.Add(node.Value);
            foreach (var child in node.Children) {
                queue.Enqueue(child);
            }
        }

        return result.ToArray();
    }
}

public class Node {
    public Node(int value) : this(value, new Node[0]) { }

    public Node(int value, IEnumerable<Node> children) {
        Value = value;
        Children = children.ToArray();
    }

    public int Value { get; set; }
    public Node[] Children { get; set; }
}