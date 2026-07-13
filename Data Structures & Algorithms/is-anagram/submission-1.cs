public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] freqCount = new int[26];
        for(int i =0; i< s.Length; i++) {
            freqCount[s[i] - 'a']++;
            freqCount[t[i] - 'a']--;
        }
        foreach ( int val in freqCount) {
            if (val != 0) return false;
        }
        return true;

    }
}
