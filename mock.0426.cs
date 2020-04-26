using System;
using System.Collections.Generic;
using System.Linq;

class SolutionMock0426
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        var oldColor = image[sr][sc];
        int m = image.Length;
        int n = image[0].Length;
        Queue<int> qr = new Queue<int>();
        Queue<int> qc = new Queue<int>();
        qr.Enqueue(sr);
        qc.Enqueue(sc);

        int[] dr = new int[]{0, 0, 1, -1};
        int[] dc = new int[]{-1, 1, 0, 0};
        while(qr.Any())
        {
            var tr = qr.Dequeue();
            var tc = qc.Dequeue();
            image[tr][tc] = -1;

            for(int k = 0; k < 4; ++k)
            {
                var nr = tr + dr[k];
                var nc = tc + dc[k];

                if(nr>=0 && nr< m && nc >=0 && nc< n && image[nr][nc] == oldColor)
                {
                    qr.Enqueue(nr);
                    qc.Enqueue(nc);
                }
            }
        }

        for(int i = 0; i< m; ++i)
            for(int j = 0; j < n; ++j)
            {
                if(image[i][j] == -1)
                {
                    image[i][j] = newColor;
                }
            }
        return image;
    }


    public TreeNode SufficientSubset(TreeNode root, int limit) {
        if(root == null) return null;
        var result = DFS(root, 0, limit);

        if(result)
        {
            return root;
        }
        else
        {
            return null;
        }
    }

    public bool DFS(TreeNode root, int current,  int limit)
    {
        current += root.val;
        if(root.left == null && root.right == null)
        {
            return current >= limit;
        }
        
        var checkL = root.left == null? false: DFS(root.left, current, limit);
        var checkR = root.right == null? false: DFS(root.right, current, limit);
        if(!checkL)
        {
            root.left = null;
        }

        if(!checkR)
        {
            root.right = null;
        }
        
        return checkL || checkR;
    }

    public Tuple<TreeNode, int> RecursiveUpdate(TreeNode root, int limit) 
    {
        if(root == null) return Tuple.Create((TreeNode)null, 0);
        if(root.left == null && root.right == null )
        { 
            return root.val > limit? Tuple.Create(root, root.val) : Tuple.Create((TreeNode)null, 0);
        }

        var pathL = 0;
        if(root.left!= null)
        {
            var tmp = RecursiveUpdate(root.left, limit);
            pathL = tmp.Item2;
            root.left = tmp.Item1;
        }

        var pathR = 0;
        if(root.right != null)
        {
            var tmp = RecursiveUpdate(root.right, limit);
            pathR = tmp.Item2;
            root.right = tmp.Item1;
        }

        var maxPath = Math.Max(pathL, pathR) + root.val;

        return maxPath > limit? Tuple.Create(root, maxPath) : Tuple.Create((TreeNode)null, 0);
    }

    public int RemoveDuplicates(int[] nums) {
        int lastNum = -1;
        int len = 0;
        for(int i = 0; i < nums.Length; ++ i)
        {
            if(i == 0)
            {
                lastNum = nums[i];
                len ++;
            }
            else
            {
                if(nums[i] != lastNum)
                {
                    nums[len ] = nums[i];
                    lastNum = nums[i];
                    len ++;
                }
            }
        }

        return len;
    }

    public IList<string> RestoreIpAddresses(string s) {
        List<string> current  = new List<string>();
        List<string> results = new List<string>();

        BacktrackingIPAddress(s, current, results);
        return results;
    }

    public void BacktrackingIPAddress(string s, List<string> current, List<string> result)
    {
        if(string.IsNullOrEmpty(s) &&  current.Count == 4)
        {
            result.Add(string.Join('.', current));
        }
        else if (string.IsNullOrEmpty(s) || current.Count == 4)
        {
            return;
        }

        for(int i = 1; i <= 3; ++i)
        {
            if(i > s.Length) 
                break;
            var str = s.Substring(0, i);
            if(i > 1 && s.StartsWith("0")) continue;
            var part = int.Parse(str);
            if(part >=0 && part<=255)
            {
                var left = i == s.Length ? "" : s.Substring(i);
                int pos = current.Count;
                current.Add(str);
                BacktrackingIPAddress(left, current, result);
                current.RemoveAt(pos);
            }
        }
    }

    public int Candy(int[] ratings) {
        Stack<int> stack = new Stack<int>();
        int[] candies = new int[ratings.Length];
        int candy = 1;
        for(int i = 0; i < ratings.Length; ++ i)
        {
            if(i == 0 )
            {
                stack.Push(i);
            }
            else if (ratings[i] < ratings[i - 1])
            {
                stack.Push(i);
            }
            else
            {
                candy = 1;
                while(stack.Any())
                {
                    candies[stack.Pop()] =candy ++;
                }
                
                if(ratings[i] == ratings[i - 1])
                    candies[i] = 1;
                else
                    candies[i] = candies[i -1 ] + 1;
            }
        }

        candy =1;
        while(stack.Any())
        {
            candies[stack.Pop()] =candy ++;
        }

        for(int i = ratings.Length -2; i >=0; i --)
        {
            if(ratings[i] > ratings[i + 1] && candies[i] < candies[i + 1])
            {
                candies[i] = candies[i + 1] + 1;
            }
        }

        return candies.Sum();
    }
}