public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        int[] arr = new int[nums.Length];
        int pointer = 0;

        for(int i = 0; i < nums.Length; i++) {
            //We map the index
            int index = Math.Abs(nums[i]) - 1;
            //We go to the that index and as long as it's within the array
            if(nums[index] >= 1 && nums[index] <= nums.Length) {
                //We put a negative flag on it
                nums[index] = -nums[index];
            }
        }
        //We loop through the array and if it was never marked negative, we know j + 1 is not in the array
        for(int j = 0; j < nums.Length; j++) {
            if(nums[j] > 0) {
                arr[pointer] = j + 1;
                pointer++;
            }
        }
        Array.Resize(ref arr, pointer);
        return arr;
    }
}
/**
Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.

Example 1:

Input: nums = [4,3,2,7,8,2,3,1]
Output: [5,6]
Example 2:

Input: nums = [1,1]
Output: [2]

Constraints:

n == nums.length
1 <= n <= 105
1 <= nums[i] <= n

Follow up: Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.
**/
