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
    public IList<int> PostorderTraversal(TreeNode root) {
        Stack<TreeNode> nodes = new Stack<TreeNode>();
        List<int> list = new List<int>();
        if(root == null) {
            return list;
        }
        
        nodes.Push(root);
        while(nodes.Count > 0) {
            root = nodes.Pop();
            Console.WriteLine("Popping: " + root.val);
            list.Add(root.val);
            Console.WriteLine("Added pop value to list");
            if(root.left != null) {
                Console.WriteLine("left value is not null");
                nodes.Push(root.left);
                Console.WriteLine("Pushed: " + root.left.val);
            }
            if(root.right!= null) {
                Console.WriteLine("right value is not null");
                nodes.Push(root.right);
                Console.WriteLine("Pushed: " + root.right.val);
            }
        }
        list.Reverse();
        return list;
    }
}

/**Given the root of a binary tree, return the postorder traversal of its nodes' values.

Example 1:

Input: root = [1,null,2,3]
Output: [3,2,1]
Example 2:

Input: root = []
Output: []
Example 3:

Input: root = [1]
Output: [1]

Constraints:

The number of the nodes in the tree is in the range [0, 100].
-100 <= Node.val <= 100

Follow up: Recursive solution is trivial, could you do it iteratively?
**/
