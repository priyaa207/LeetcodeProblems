/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            int diff=target-nums[i];
            if(dict.ContainsKey(diff)){
                return new int[]{dict[diff],i};
            }
            dict[nums[i]]=i;
        }
     return new int[0];
    }
}
// @lc code=end

