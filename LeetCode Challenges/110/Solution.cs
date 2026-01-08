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
        int[] res = DFS(root);
        return res[0] == 1;
    }

    public int[] DFS(TreeNode root) {
        if (root == null) return new int[]{1, 0};

        int[] l = DFS(root.left);
        int[] r = DFS(root.right);

        int v = (l[0] == 1 && r[0] == 1 && Math.Abs(l[1] - r[1]) <= 1) ? 1 : 0;

        return new int[]{v, 1 + Math.Max(l[1], r[1])};
    }
}