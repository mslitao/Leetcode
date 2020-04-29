using System;
using System.Collections.Generic;
using System.Linq;

public class Mock0428
{
    public bool IsAnagram(string s, string t) {
        if(string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t)) return true;
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return false;

        if(s.Length != t.Length) return false;
        Dictionary<char, int> maps = new Dictionary<char, int>();
        foreach(var c in s)
        {
            if(!maps.ContainsKey(c))
            {
                maps.Add(c, 0);
            }

            maps[c]++;
        }

        foreach(var c in t)
        {
            if(!maps.ContainsKey(c)) return false;
            maps[c] --;
            if(maps[c] < 0) return false;
        }

        return true;
    }

    public int TitleToNumber(string s) {
        int sum = 0;

        foreach(var c in s)
        {
            var num = c - 'A' + 1;
            sum = sum* 26 + num;
        }

        return sum;
    }

    public bool Exist(char[][] board, string word) {
        int m = board.Length;
        int n = board[0].Length;
        for(int i = 0; i < m; ++ i)
            for(int j = 0; j < n; ++ j)
            {
                HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>();
                List<int> results = new List<int>();

                if(DFSLookup(board, word, 0, i, j, m, n, visited, results))
                    return true;
            }
        
        return false;
    }

    // DFS  -> Dictionary<>
    // Turn the word into trie
    public bool DFSLookup(char[][] board, string word, int idx, 
                          int i, int j, int m, int n, HashSet<Tuple<int, int>> visited, List<int> results)
    {
        if(i <0 || i>=m ||j< 0 || j>= n) return false;
        if(results.Count >0) return true;
        if(visited.Contains(Tuple.Create(i, j))) return false;
        if(board[i][j] != word[idx]) return false;
        
        if(idx == word.Length -1 )
        {
            results.Add(1); 
            return true;
        }
        
        int[] di = new int[]{0,0, 1, -1};
        int[] dj = new int[]{1, -1, 0, 0};
        visited.Add(Tuple.Create(i, j));
        for(int k = 0; k < 4; ++k)
        {
            if(DFSLookup(board, word, idx + 1, i + di[k], j + dj[k], m, n, visited, results ))
            {
                return true;
            }
        }
        visited.Remove(Tuple.Create(i, j));
        return false;
    }
}