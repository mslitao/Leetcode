using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
        public bool IsWord = false;

        public string Word = string.Empty;
        public int Rank = 0;
    }

    public class Trie
    {
        private TrieNode root = new TrieNode();

        public void Insert(string word, int rank)
        {
            if(string.IsNullOrWhiteSpace(word)) return;
            
            var node = root;
            foreach(var c in word)
            {
                if(!node.Children.ContainsKey(c))
                {
                    node.Children.Add(c, new TrieNode());
                }

                node = node.Children[c];
            }

            node.IsWord = true;
            node.Rank = rank;
            node.Word = word;
        }

        public List<Tuple<string, int>> Search(string prefix)
        {
            List<Tuple<string, int>> results = new List<Tuple<string, int>>();
            if(string.IsNullOrWhiteSpace(prefix)) return results;

            // Get the leaf node of the prefix
            var node = this.root;
            foreach(var c in prefix)
            {
                if(node.Children.ContainsKey(c))
                {
                    node = node.Children[c];
                }
                else
                {
                    node = null;
                    break;
                }
            }

            // If no leaf node found, return empty list
            if(node == null) return results;

            // Use the queue to add all the children following the prefix
            Queue<TrieNode> queue = new Queue<TrieNode>();
            queue.Enqueue(node);
            while(queue.Any())
            {
                var tmp = queue.Dequeue();
                if(tmp.IsWord)
                {
                    //Console.WriteLine(tmp.Word);
                    results.Add(Tuple.Create(tmp.Word, tmp.Rank));
                }
                foreach(var next in tmp.Children)
                {
                    queue.Enqueue(next.Value);
                }
            }

            // Order the list by the rank and return the results.
            return results.OrderBy(nn =>nn.Item2).ToList();
        }
    }

    class Program
    {
        public static void AutoComplete(Trie trie, string prefix)
        {
            var results = trie.Search(prefix);
            Console.WriteLine(string.Format("{0}:", prefix));
            int i = 0;
            foreach(var res in results)
            {
                if(i++ < 5)
                    Console.WriteLine(res.Item1 + " (" + res.Item2.ToString() + ")");
            }
        }

        static void Main(string[] args)
        {
            Trie trie = new Trie();

            // For stdin, you could use
            // 
            int cntWord = 0;
            int cntPrefix = 0;
            int index = 0;
            //using (var b = new StreamReader("input.tsv"))
            using (var b = new StreamReader(Console.OpenStandardInput(), Console.InputEncoding))
            {
                string line;
                while ((line = b.ReadLine()) != null)
                {
                    if(index == 0)
                    {
                        cntWord = int.Parse(line);

                        if(cntWord<=0)
                        {
                            throw new Exception("Invalid word count");
                        }
                    }
                    else if(index == 1)
                    {
                        cntPrefix = int.Parse(line);

                        if(cntPrefix<0)
                        {
                            throw new Exception("Invalid prefix count");
                        }
                    }
                    else if(index < cntWord + 2)
                    {
                        trie.Insert(line, index -1);
                    }
                    else if (index < cntWord + 2 + cntPrefix)
                    {
                        //Console.WriteLine(line);
                        AutoComplete(trie, line);
                        Console.WriteLine();
                    }
                    else
                    {
                        throw new Exception("Wrong input files.");
                    }

                    index ++;
                }
            }
        }
    }
}
