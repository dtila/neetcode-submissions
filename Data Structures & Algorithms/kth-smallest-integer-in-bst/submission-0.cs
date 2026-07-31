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
    public int KthSmallest(TreeNode root, int k) {
        var list = new List<int>();
        bfs(root, list);

        return list[k - 1];
    }

    private void bfs(TreeNode root, List<int> list)
    {
        if (root == null)
            return;
        
        bfs(root.left, list);
        list.Add(root.val);
        bfs(root.right, list);
    }
}
