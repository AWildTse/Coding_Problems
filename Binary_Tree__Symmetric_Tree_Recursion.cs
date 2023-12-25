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
    public bool IsSymmetric(TreeNode root) {
        return CheckSymmetry(root.left, root.right);
    }

    public bool CheckSymmetry(TreeNode left, TreeNode right){
        if(left == null || right == null) {
            //if either value is null, we'll just check if the null value is the same as the other value and return true or false
            return left == right;
        }
        //Check left == right
        return (left.val == right.val) &&
            //check if left.left == right.right (outer nodes)
            CheckSymmetry(left.left, right.right) &&
            //check if right.left = left.right (inner nodes)
            CheckSymmetry(right.left, left.right);
        //If they're all true, we know the entire tree has been traversed and that the tree is symmetrical
    }
}

/**
Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).

Example 1:

Input: root = [1,2,2,3,4,4,3]
Output: true
Example 2:

Input: root = [1,2,2,null,3,null,3]
Output: false

Constraints:

The number of nodes in the tree is in the range [1, 1000].
-100 <= Node.val <= 100

Follow up: Could you solve it both recursively and iteratively?
**/
