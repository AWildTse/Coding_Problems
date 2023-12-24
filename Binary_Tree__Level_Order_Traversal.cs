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
    public IList<IList<int>> LevelOrder(TreeNode root) {

        Queue<TreeNode> q = new Queue<TreeNode>();
        IList<IList<int>> list = new List<IList<int>>();

        //We return an empty list if our tree is empty        
        if(root == null) {
            return list;
        }
        //We load up the head of our tree
        q.Enqueue(root);

        //Until the tree is traversed        
        while(q.Count > 0) {
            //for every element in the queue, we have to traverse each one to check left and right elements
            int count = q.Count;
            //this will keep track of all elements on this level
            List<int> level = new List<int>();
            for(int i = 0; i < count; i++) {
                root = q.Dequeue();
                //We add our current head to the list
                level.Add(root.val);

                if(root.left != null) {
                    q.Enqueue(root.left);
                }
                if(root.right != null) {
                    q.Enqueue(root.right);
                }
            }
            //When we exit the for loop, we've traversed every element of the level.
            list.Add(level);
        }
        
        return list;
    }
}

/**
Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).

Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: [[3],[9,20],[15,7]]
Example 2:

Input: root = [1]
Output: [[1]]
Example 3:

Input: root = []
Output: []
 
Constraints:

The number of nodes in the tree is in the range [0, 2000].
-1000 <= Node.val <= 1000
**/
