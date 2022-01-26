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

// Complete a Preorder traversal given the root node of a binary search tree
public class Solution {
    List<int> l1 = new List<int>();
    public IList<int> PreorderTraversal(TreeNode root) 
    {
      
         if (root == null)
            return l1;
        
         l1.Add(root.val);
           
         PreorderTraversal(root.left) ;
             
         PreorderTraversal(root.right);

        return l1;
    }
}
