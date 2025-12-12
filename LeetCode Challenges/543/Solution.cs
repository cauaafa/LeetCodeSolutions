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
    public int DiameterOfBinaryTree(TreeNode root) {
        int diameter = 0;
        DFS(root, ref diameter);
        return diameter;
    }

    public int DFS(TreeNode t, ref int diameter) {
        if (t == null) return 0;

        int leftHeight = DFS(t.left, ref diameter);
        int rightHeight = DFS(t.right, ref diameter);

        diameter = Math.Max(diameter, leftHeight + rightHeight);

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}