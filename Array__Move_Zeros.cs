public class Solution {
    public void MoveZeroes(int[] nums) {
        //index is what we use to keep track of what to overwrite
        int index = 0;
        for(int i = 0; i < nums.Length; i++)
        {
          //The index only increments if the number is not a zero, so we don't overwrite a non-zero.
            if(nums[i] != 0) {
                nums[index] = nums[i];
                index++;
            }
        }
        //fill the rest of the array with zeros.
        for(int j = index; j < nums.Length; j++)
        {
            nums[j] = 0;
        }
    }
}

/**
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]

Constraints:

1 <= nums.length <= 104
-231 <= nums[i] <= 231 - 1

Follow up: Could you minimize the total number of operations done?
**/
