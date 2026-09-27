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
    public TreeNode InvertTree(TreeNode root) {
        Invert(root);

        return root;
    }

    public void Invert(TreeNode node) {
        if(node == null)
            return;
        
        TreeNode aux;
        aux = node.left;
        node.left = node.right;
        node.right = aux;

        Invert(node.left);
        Invert(node.right);
    }
}