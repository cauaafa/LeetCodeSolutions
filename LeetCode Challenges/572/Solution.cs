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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        return Check(root, subRoot);
    }

    public bool CheckTreeNode(TreeNode t1, TreeNode t2) {
        if (t1 == null && t2 == null) {
            return true;
        }
        if (t1 == null || t2 == null) {
            return false;
        }
        if (t1.val != t2.val) {
            return false;
        }
        return CheckTreeNode(t1.left, t2.left) && CheckTreeNode(t1.right, t2.right);
    }

    public bool Check(TreeNode t1, TreeNode t2) {
        if (t1 == null) {
            return false;
        }
        if (CheckTreeNode(t1, t2)) {
            return true;
        }
        return Check(t1.left, t2) || Check(t1.right, t2);
    }
}