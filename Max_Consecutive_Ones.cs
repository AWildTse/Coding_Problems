//Given a binary array nums, return the maximum number of consecutive 1's in the array.
public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count = 0;
        int longest = 0;
        foreach(var num in nums)
        {
            if(num == 1)
                count++;
            else
            {
                if(count > longest)
                    longest = count;
                count = 0;
            }
        }
        if(count > longest)
            longest = count;
        return longest;
    }
}
