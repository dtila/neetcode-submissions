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
    public List<int> RightSideView(TreeNode root) {
        var result = new List<int>();
        if (root == null)
            return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var len = queue.Count;
            for (int i=0 ; i<len ; i++)
            {
                var element = queue.Dequeue();
                if (element.left != null)
                    queue.Enqueue(element.left);
                if (element.right != null)
                    queue.Enqueue(element.right);

                if (i == len - 1)
                {
                    result.Add(element.val);
                }
            }

        }

        return result;
    }
}
