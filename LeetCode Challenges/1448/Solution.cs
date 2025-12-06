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
    public int total = 0;
    public int GoodNodes(TreeNode root) {

        isGood(root, int.MinValue);

        return total;
    }

    public void isGood(TreeNode selNode, int value) {
        if (selNode.val >= value) {
            total++;
        }

        value = Math.Max(value, selNode.val);
        if (selNode.left != null) {
            isGood(selNode.left, value);
        }
        if (selNode.right != null) {
            isGood(selNode.right, value);
        }
    }
}