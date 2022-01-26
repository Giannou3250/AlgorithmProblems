public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        bool cas = true;
        int count = 0;
        string s;
        if (strs.Length == 0)
        {
            return "";
        }
        else
        {
            int index = 0;
            int minval = 9999;
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < minval)
                {
                     minval = strs[i].Length;
                    index = i;
                }
            }
            s = strs[index];
            for (int i = 0; i < s.Length; i++)
            {
                
                for (int j = 0; j < strs.Length; j++)
                {
                    if (s[i] != strs[j][i])
                    {
                        cas = false;
                        break;
                    }
                }
                if (cas == false)
                {
                    break;
                }
                count++;
            }
            return s.Substring(0, count);
        }
    }
}
