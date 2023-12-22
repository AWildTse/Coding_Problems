public class Solution {
    public bool ValidMountainArray(int[] arr) {
        int peak = arr[0];
        int index = 0;
        int peakIndex = 0;
        //Check if the array is at least length 3
        if(arr.Length < 3)
        {
            return false;
        }
        //We traverse the array until it changes directions
        for(int i = 1; i < arr.Length; i++) {
            if(arr[i] > peak) {
                peak = arr[i];
                //The peak index is to keep track that of whether or not the array increased before it decreases
                peakIndex++;
            }
            else
            {
                index = i;
                //If the array never increased (only downhill), we return false because it is not a strictly increasing then decreasing array.
                if(peakIndex == 0)
                {
                    return false;
                }
                break;
            }
        }
        //We've "peaked"
        //We go through the rest of the array and check whether or not it goes downhill all the way.
        for(int i = index; i < arr.Length; i++) {
            if(arr[i] >= peak)
            {
                return false;
            }
            peak = arr[i];
        }
        return true;
    }
}
/**
Given an array of integers arr, return true if and only if it is a valid mountain array.

Recall that arr is a mountain array if and only if:

arr.length >= 3
There exists some i with 0 < i < arr.length - 1 such that:
arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
arr[i] > arr[i + 1] > ... > arr[arr.length - 1]

Example 1:

Input: arr = [2,1]
Output: false
Example 2:

Input: arr = [3,5,5]
Output: false
Example 3:

Input: arr = [0,3,2,1]
Output: true
 
Constraints:

1 <= arr.length <= 104
0 <= arr[i] <= 104
**/
