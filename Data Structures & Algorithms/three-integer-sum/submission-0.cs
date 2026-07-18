public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        Dictionary<int, int> countMap = new();
        foreach (int num in nums) {
            if(!countMap.ContainsKey(num)) countMap[num] = 0;
            countMap[num]++;
        }

        HashSet<(int,int,int)> seenTriplets = new();
        
        List<List<int>> result = new();
        for(int i = 0; i<nums.Length;i++) {
            countMap[nums[i]]--;
            for(int j = i+1; j<nums.Length; j++) {
                countMap[nums[j]]--;
                int target = -(nums[i]+nums[j]);
                if(countMap.ContainsKey(target) && countMap[target] > 0 && target >= nums[j]) {
                    var triplet = (nums[i], nums[j], target);
                    if(seenTriplets.Add(triplet)) {
                        result.Add(new List<int>{nums[i], nums[j], target});
                    }
                }
                countMap[nums[j]]++;
            }
            countMap[nums[i]]++;
        }
        return result;
        
    }
}
