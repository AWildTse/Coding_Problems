public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        List<int> counter = new List<int>();
        int count = 0;
        int index = 0;
        if(s.Length == null) {
            return 0;
        }
        
        for(int i = 0; i < s.Length; i++) {
            //If we've never encountered the character before, add to dictionary
            if(!dict.ContainsKey(s[i])) {
                dict.Add(s[i], 1);
                count++;
            }
            
            else {
                //If we have, we want to add to the counter list to update our possible values
                counter.Add(count);
                //reset counter
                count = 0;
                //clear dictionary
                dict.Clear();
                //reset pointer for loop
                i = index;
                //increment pointer
                index++;
            }
        }
        //If the last character is a character we have not countered yet, we would've added to count but never add to counter.
        counter.Add(count);
        return counter.Max();
    }
}

/**
Given a string s, find the length of the longest 
substring without repeating characters.

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

Constraints:

0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.
**/
