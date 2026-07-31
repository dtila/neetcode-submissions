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
    public bool IsValidBST(TreeNode root) {
        if (root == null)
            return true;
        
        return bfs(root, int.MinValue, int.MaxValue);
    }

    private bool bfs(TreeNode node, int min, int max)
    {
        if (node == null)
            return true;
        
        if (!(min < node.val && node.val < max))
            return false;

        return bfs(node.left, min, node.val) && bfs(node.right, node.val, max);
    }
}
