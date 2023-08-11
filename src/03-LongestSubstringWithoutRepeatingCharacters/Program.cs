var lengthOfLongestSubstring = LengthOfLongestSubstring("abcabcbb");
Console.WriteLine(lengthOfLongestSubstring); //3


//03. LongestSubstringWithoutRepeatingCharacters
//Difficulty : Medium
//Link : https://leetcode.com/problems/longest-substring-without-repeating-characters/

int LengthOfLongestSubstring(string s)
{
    //给定一个字符串 s ，请你找出其中不含有重复字符的 最长子串 的长度。
    Dictionary<char, int> dic = new Dictionary<char, int>();
    int max = 0;
    int left = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (dic.ContainsKey(s[i]))
        {
            left = Math.Max(left, dic[s[i]] + 1);
            dic[s[i]] = i;
        }
        else
        {
            dic.Add(s[i], i);
        }

        max = Math.Max(max, i - left + 1);
    }

    return max;
}