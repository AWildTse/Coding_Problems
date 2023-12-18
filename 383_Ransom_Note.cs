public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        //We're going to check whether there are enough letters to nmake the ransom note in the first place
        if(magazine.Length < ransomNote.Length)
        {
            return false;
        }
        foreach(var letter in magazine)
        {
            //Add to dictionary if the letter wasn't already added
            if(!dict.ContainsKey(letter))
            {
                dict.Add(letter, 1);
            }
            //increase the count if the letter was already added
            else
            {
                dict[letter]++;
            }
        }
        foreach(var letter in ransomNote)
        {
            //If the dictionary has the letter, remove it
            if(dict.ContainsKey(letter))
            {
                dict[letter]--;
                //if the value is below 0, we do not have the letter anymore, so the ransom note cannot be made
                if(dict[letter] < 0)
                    return false;
            }
            //if the dictionary does not contain the letter, the ransom note cannot be made
            else
            {
                return false;
            }
        }
        return true;
    }
}

/**
Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true

Constraints:

1 <= ransomNote.length, magazine.length <= 105
ransomNote and magazine consist of lowercase English letters.
**/
