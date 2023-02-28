using System.Collections.Generic;
using System.Collections.ObjectModel;

public static class Solution
{
    public Node Main(Node root, int valueToFind)
    {
        Node? result = null;
        var queue = new PriorityQueue<Node, int>();

        queue.Enqueue(Node, 0);
        while (!queue.TryDequeue(out var currentNode)) {
            if (currentNode.Value == valueToFind)
            {
                result = currentNode;
                break;
            }

            foreach (var childNode in currentNode.Children)
            {
                queue.Enqueue(childNode, Hueristic(childNode));
            }
        }

        return result;        
    }

    public static int Hueristic(Node node)
    {
        return 1;
    }
}

public class Node
{
    public int Value { get; set;}
    public Node[] Children { get; set;}
}