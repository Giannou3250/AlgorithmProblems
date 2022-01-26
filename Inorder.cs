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

//Perform an inorder traversal given the root node of a binary tree
public class Solution {
    List<int> l1 = new List<int>();
    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root == null)
        {
            return l1;
        }
        InorderTraversal(root.left);
        
        l1.Add(root.val);
        
        InorderTraversal(root.right);
        
        return l1;
    }
}
