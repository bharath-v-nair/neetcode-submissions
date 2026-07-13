public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

//created dict
        Dictionary<char, int> sDict = new Dictionary<char, int>();
        Dictionary<char, int> tDict = new Dictionary<char, int>();
        
        //added kvp to dicts
        for (int i=0; i<s.Length; i++) {
            sDict[s[i]] = sDict.GetValueOrDefault(s[i], 0) +1;
            tDict[t[i]] = tDict.GetValueOrDefault(t[i], 0) +1;
        }

        //for larger strings, we can avoid looping here if wrong.
        if(sDict.Count != tDict.Count) return false;

        foreach( var kvp in sDict) {
            if(!tDict.ContainsKey(kvp.Key) || tDict[kvp.Key] != kvp.Value) return false;
        }

        return true;


    }
}