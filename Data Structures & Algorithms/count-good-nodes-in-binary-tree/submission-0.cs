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
    public int GoodNodes(TreeNode root) {
        if (root == null)
            return 0;
        return bfs(root, root.val);
    }

    private int bfs(TreeNode node, int best)
    {
        if (node == null)
            return 0;

        var max = Math.Max(best, node.val);
        var result = node.val >= best ? 1 : 0;
        
        result += bfs(node.left, max);
        result += bfs(node.right, max);
        return result;
    }

}
