/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsBalanced(TreeNode root) {
        var (_, balanced) = bfs(root);
        return balanced;
    }

    private (int height, bool isBalanced) bfs(TreeNode node)
    {
        if (node == null)
            return (0, true);
        
        var left = bfs(node.left);
        var right = bfs(node.right);
        var isBalanced = Math.Abs(left.height - right.height) <= 1
            && left.isBalanced && right.isBalanced;

        return (1 + Math.Max(left.height, right.height), isBalanced);
    }
}
