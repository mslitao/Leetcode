using System;
using System.Collections.Generic;


class SolutionMock0419
{
    public string ToLowerCase(string str) {
        if(string.IsNullOrEmpty(str)) return str;
        return str.ToLower();
    }

    public int NumPairsDivisibleBy60(int[] time) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int result = 0;
        for(int i = 0; i < time.Length; ++i)
        {
            var t = time[i] % 60;
            var s = t == 0 ? 0 : 60 - t;
            if(map.ContainsKey(s))
            {
                result += map[s];
            }
            
            if(map.ContainsKey(t))
                map[t]++;
            else
                map.Add(t, 1);
        }

        return result;
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public TreeNode InvertTree(TreeNode root) {
        if(root == null) return null;
        var tmp = root.left;
        root.left = InvertTree(root.right);
        root.right = InvertTree(tmp);

        return root;
    }
}