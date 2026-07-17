public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int,int> map = new();
        for( int i = 0; i< numbers.Length; i++) {
            int diff = target - numbers[i];

             // 1. Check for the complement first
        if(map.ContainsKey(diff)) {
            // Found it! Return the 1-based indices
            return new int[]{map[diff] + 1, i + 1};
        }
        
        // 2. ONLY add to the map if we haven't seen this number before.
        // This preserves the earliest index!
        if (!map.ContainsKey(numbers[i])) {
            map[numbers[i]] = i; 
        }
        }
        return new int[0];
    }
}


//create hashmap - dict - map
//loop through array with index i to 0 to n-1
// diff = tarhet - number[i]
//if containsKey[diff] return map[diff], i+1
//map[numbers[i]] = i+1

//1,2,3,4 target = 3
//1 -> diff is 3-1 = 2, no , add
//2 -> diff is 3-2 = 1 , yes, map[diff], 