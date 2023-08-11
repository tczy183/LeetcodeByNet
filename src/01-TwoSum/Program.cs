var twoSum = TwoSum(new[] { 2, 7, 11, 15 }, 9);
if (twoSum.Length != 0) Console.WriteLine($"[{twoSum[0]}, {twoSum[1]}]");

// 1. Two Sum
// Difficulty : Easy
// Link : https://leetcode.com/problems/two-sum/
int[] TwoSum(int[] nums, int target)
{
    var dic = new Dictionary<int, int>();
    for (var i = 0; i < nums.Length; i++)
    {
        if (dic.ContainsKey(target - nums[i])) return new[] { i, dic[target - nums[i]] };

        dic.TryAdd(nums[i], i);
    }

    return new int[] { };
}