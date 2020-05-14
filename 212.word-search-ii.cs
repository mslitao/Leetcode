using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Solution212 {
    public IList<string> FindWords(char[][] board, string[] words) {
        var result = new HashSet<string>();
        var n = board.Length;
        if (n == 0) return new List<string>();
        var m = board[0].Length;

        var trie = new Trie();
        foreach (var word in words) {
            trie.Insert(word);
        }

        var isVisited = new bool[n, m];

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                var index = board[i][j] - 'a';
                if (trie.root.nodes[index] != null) {
                    DFS(i, j, trie.root, board, isVisited, result);
                }
            }
        }

        return result.ToList();
    }

    private void DFS(int x, int y, TrieNode node, char[][] board, bool[,] isVisited, HashSet<string> result) {
        var n = board.Length;
        var m = board[0].Length;

        if (node.isWord) {
            result.Add(node.word);
        }

        if (x >= n || x < 0 || y >= m || y < 0) {
            return;
        }
        if (isVisited[x, y]) return;
        var index = board[x][y] - 'a';
        if (node.nodes[index] == null) return;

        var next = node.nodes[index];

        isVisited[x, y] = true;

        var directions = new (int, int)[] { (0, 1), (0, -1), (1, 0), (-1, 0) };
        foreach (var direction in directions) {
            var nextX = x + direction.Item1;
            var nextY = y + direction.Item2;

            DFS(nextX, nextY, next, board, isVisited, result);
        }

        isVisited[x, y] = false;
    }


    class Trie {

        public TrieNode root;
        public Trie() {
            root = new TrieNode();
        }
        public void Insert(string word) {
            var n = word.Length;
            TrieNode curNode = root;
            for (int i = 0; i < n; i++) {
                var index = word[i] - 'a';
                if (curNode.nodes[index] == null) {
                    curNode.nodes[index] = new TrieNode();
                }
                curNode = curNode.nodes[index];

                if (i == n - 1) {
                    curNode.isWord = true;
                    curNode.word = word;
                }
            }
        }
    }

    class TrieNode {
        public TrieNode[] nodes;
        public bool isWord;
        public string word;

        public TrieNode() {
            nodes = new TrieNode[26];
            isWord = false;
        }
    }
}

