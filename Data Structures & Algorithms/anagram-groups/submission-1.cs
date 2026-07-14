public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map= new Dictionary<string, List<string>>();
        foreach ( string str in strs) {
            int[] freqCount = new int[26];
            foreach ( char c in str) {
                freqCount[c-'a']++;
            }
            string key = string.Join(",",freqCount);
            if(!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }
            map[key].Add(str);
        }
        return map.Values.ToList();
    }
}

