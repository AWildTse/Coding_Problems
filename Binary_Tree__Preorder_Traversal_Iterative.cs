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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> list = new List<int>();
        Stack<TreeNode> nodes = new Stack<TreeNode>();
        
        if(root == null) {
            return list;
        }
        nodes.Push(root);
        while(nodes.Count > 0) {
            root = nodes.Pop();
            if(root.right != null) {
                nodes.Push(root.right);
            }
            if(root.left != null) {
                nodes.Push(root.left);
            }
            list.Add(root.val);
        }
        return list;
    }
}

/**
Given the root of a binary tree, return the preorder traversal of its nodes' values.

Example 1:
Input: root = [1,null,2,3]
Output: [1,2,3]
Example 2:

Input: root = []
Output: []
Example 3:

Input: root = [1]
Output: [1]
 
Constraints:

The number of nodes in the tree is in the range [0, 100].
-100 <= Node.val <= 100
 

Follow up: Recursive solution is trivial, could you do it iteratively?
**/
