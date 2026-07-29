/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        var hash = new Dictionary<int, Node>();

        return Clone(node, hash);
    }

    public Node Clone(Node root, Dictionary<int, Node> hash)
    {
        if (root == null)
            return null;

        if (hash.TryGetValue(root.val, out var duplicate))
            return duplicate;

        duplicate = new Node(root.val);
        hash.Add(root.val, duplicate);

        foreach (var neighbour in root.neighbors)
            duplicate.neighbors.Add(Clone(neighbour, hash));

        return duplicate;
    }
}
