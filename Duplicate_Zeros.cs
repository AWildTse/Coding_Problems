public class Solution {
    public void DuplicateZeros(int[] arr) {  
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == 0)
            {
                ShiftRight(arr, i);
                //increase the index so we don't keep depositing 0's
                i++;
            }
        }
    }
    
    public void ShiftRight(int[] arr, int index)
    {
        for(int i = arr.Length - 1; i >= index; i--)
        {
            //Skip the end value in the array
            if(i == arr.Length - 1)
                continue;
            //We want to shift everything to the right
            arr[i + 1] = arr[i];
        }
    }
}

/**
Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.

Note that elements beyond the length of the original array are not written. Do the above modifications to the input array in place and do not return anything.

Example 1:

Input: arr = [1,0,2,3,0,4,5,0]
Output: [1,0,0,2,3,0,0,4]
Explanation: After calling your function, the input array is modified to: [1,0,0,2,3,0,0,4]
Example 2:

Input: arr = [1,2,3]
Output: [1,2,3]
Explanation: After calling your function, the input array is modified to: [1,2,3]

Constraints:

1 <= arr.length <= 104
0 <= arr[i] <= 9
**/
