//This solution is slightly slower but improved because we did not need to use a sort algorithm this time around.
public class Solution {
    public int[] SortedSquares(int[] nums) {
        int lPointer = 0;
        int rPointer = nums.Length - 1;
        int index = 0;
        
        int[] arr = new int[nums.Length];

        //While the left pointer has not passed the right pointer
        while(lPointer <= rPointer) {
            //We check which squared is a greater number
            if(nums[lPointer] * nums[lPointer] >= nums[rPointer] * nums[rPointer]) {
                arr[index] = nums[lPointer] * nums[lPointer];
                lPointer++;
            }
            else {
                arr[index] = nums[rPointer] * nums[rPointer];
                rPointer--;
            }
            //increment the index for our returning array
            index++;
        }
        //We reverse the array because we stored our values from highest to lowest.
        Array.Reverse(arr);
        return arr;
    }
}

/**
Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

Example 1:

Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].
Example 2:

Input: nums = [-7,-3,2,3,11]
Output: [4,9,9,49,121]

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums is sorted in non-decreasing order.

Follow up: Squaring each element and sorting the new array is very trivial, could you find an O(n) solution using a different approach?
**/
