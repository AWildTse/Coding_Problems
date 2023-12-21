public class Solution {
    public bool CheckIfExist(int[] arr) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        //Check if the array given is null or empty
        if(arr == null || arr.Length == 0)
        {
            return false;
        }
        CreateDict(arr, dict);
        CheckContents(arr, dict);
        return CheckContents(arr, dict);
    } 
    //We create a dictionary that will house all the contents of the array. If it already exists, we increment the value.
    public void CreateDict(int[] arr, Dictionary<int, int> dict) {
        for(int i = 0; i < arr.Length; i++) {
            if(!(dict.ContainsKey(arr[i]))) {
                dict.Add(arr[i], 1);
            }
            else
                dict[arr[i]]++;
        }
    }
    //Here we check each index of the array and compare it to the entire dictionary checking if (index/2) has been stored.
    public bool CheckContents(int[] arr, Dictionary<int, int> dict) {
        for(int i = 0; i < arr.Length; i++) {
            if(dict.ContainsKey(arr[i]/2)) {
                //Since 0/2 passes, we have to make sure there's more than one 0 in the array because i != j.
                if(arr[i] == 0) {
                    if(dict[arr[i]] <= 1) {
                        continue;
                    }
                }
                //Here we confirm that the (index/2) is an even number.
                if(arr[i] % 2 == 0) {
                    return true;
                }
            }
        }
        return false;
    }
}

/**
Given an array arr of integers, check if there exist two indices i and j such that :

i != j
0 <= i, j < arr.length
arr[i] == 2 * arr[j]
 
Example 1:

Input: arr = [10,2,5,3]
Output: true
Explanation: For i = 0 and j = 2, arr[i] == 10 == 2 * 5 == 2 * arr[j]
Example 2:

Input: arr = [3,1,7,11]
Output: false
Explanation: There is no i and j that satisfy the conditions.

Constraints:

2 <= arr.length <= 500
-103 <= arr[i] <= 103
**/
