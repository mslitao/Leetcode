using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Leetcode
{
        /**
    * Definition for a binary tree node.*/
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class BoardItem
    {
        public int X;
        public int Y;

        public char Data;

        public List<BoardItem> Neighbors;

        public BoardItem(int x, int y, char c)
        {
            this.X = x;
            this.Y = y;
            this.Data = c;

            this.Neighbors = new List<BoardItem>();
        }

        public void AddNeighbor(BoardItem item)
        {
            this.Neighbors.Add(item);
        }
    }   
    public class ListNode {
             public int val;
             public ListNode next;
             public ListNode(int x) { val = x; }
        }

    // Definition for a Node.
    public class Node {
        public int val;
        public Node next;
        public Node random;
        
        public Node(int _val) {
            val = _val;
            next = null;
            random = null;
        }
    }

    public class MinStack {
        List<int> values;
        List<int> mins;
        /** initialize your data structure here. */
        public MinStack() {
            this.values = new List<int>();
            this.mins = new List<int>();
        }
        
        public void Push(int x) {
            this.values.Add(x);

            if(this.mins.Count == 0)
                this.mins.Add(x);
            else
                this.mins.Add(Math.Min(x, this.GetMin()));
        }
        
        public void Pop() {
            this.values.RemoveAt(this.values.Count - 1);
            this.mins.RemoveAt(this.mins.Count - 1);
        }
        
        public int Top() {
            if(this.values.Count == 0)
                return int.MinValue;
            return this.values.Last();
        }
        
        public int GetMin() {
            if(this.mins.Count == 0)
                return int.MinValue;

            return this.mins.Last();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution s = new Solution();
            /*foreach(var res in s.TwoSum(new int[]{2, 7, 11, 15}, 9))
            {
                Console.WriteLine(res);
            }*/

            //Console.WriteLine(s.MissingNumber(new int[]{9,6,4,2,3,5,7,0,1}));

            //Console.WriteLine(s.HIndex(new int[]{3,0,6,1,5}));

            //Console.WriteLine(s.NumSquares(1));

            //Console.WriteLine(s.GetHint("1807", "7810"));

            //Console.WriteLine(s.BackspaceCompare("ab#c","abc#"));

            /*var results = s.SolveNQueens(4);
            foreach(var res in results)
            {
                foreach(var line in res)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("-----------------------------");
            }*/

            /*var results = s.GenerateParenthesis(3);
            foreach(var res in results)
            {
                Console.WriteLine(res);
            }*/
            
            /*var results = s.CountBits(5);
            foreach(var res in results)
            {
                Console.WriteLine(res);
            }*/

            /*var results = s.Subsets(new int[]{1,2, 3});
            foreach(var res in results)
            {
                Console.WriteLine(string.Join("|", res));
            }*/

            /*var results = s.LetterCasePermutation("ssa33d");
            foreach(var res in results)
            {
                Console.WriteLine(res);
            }*/

            /*Console.WriteLine(s.LengthOfLongestSubstring("abcabcbb"));
            Console.WriteLine(s.LengthOfLongestSubstring("bbbb"));
            Console.WriteLine(s.LengthOfLongestSubstring("pwwkew"));
            Console.WriteLine(s.LengthOfLongestSubstring(" "));
            */
            /*int[][] a = new int[][] 
                        {
                            new int[] { 1, 2, 3, 4 },
                            new int[] { 5, 6, 7, 8},
                            new int[] { 9,10,11,12  }
                        };

            int[][] b = new int[][] 
                        {
                            new int[] { 1, 2, 3 },
                            new int[] { 4, 5, 6},
                            new int[] { 7, 8, 9 },
                            new int[] { 10, 11, 12 },
                        };

            Console.WriteLine(string.Join('-', s.SpiralOrder(b)));*/

            /*
            char[][] a = new char[][]{
                new char[]{'A','B','C','E'},
                new char[]{'S','F','C','S'},
                new char[]{'A','D','E','E'}
            };
            Console.WriteLine(s.Exist(a, "ABCCED"));
            Console.WriteLine(s.Exist(a, "SEE"));
            Console.WriteLine(s.Exist(a, "ABCB"));*/

            /*
            int[][] a = new int[][] 
                        {
                            new int[] { 1, 3, 1 },
                            new int[] { 1, 5, 1},
                            new int[] { 4, 2, 1 }
                        };

            Console.WriteLine(s.MinPathSum(a));*/
            /*
            ListNode head = new ListNode(1);
            ListNode n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            ListNode n3 = new ListNode(3);
            ListNode n4 = new ListNode(3);
            
            Console.WriteLine(s.MinDistance("dinitrophenylhydrazine", "benzalphenylhydrazone")); */

            //Console.WriteLine(s.NumDecodings("0"));

            //Console.WriteLine(s.CoinChange(new int[]{1, 2}, 11));

            //Console.WriteLine(s.FindTargetSumWays(new int[]{1, 1,1,1,1}, 3));

            /*var a = new int[][] 
                {
                    new int[] { 2, 6},
                    new int[] { 1, 3 },
                    new int[] { 15, 18 },
                    new int[] { 10, 12 }
                };

            var results = s.Merge(a);
            foreach(var res in results)
            {
                Console.WriteLine(res[0].ToString() + "-" + res[1].ToString());
            }*/

            //Console.WriteLine(s.MinCostClimbingStairs(new int[]{1, 100, 1, 1, 1, 100, 1, 1, 100, 1}));

            /*var results = s.ReadBinaryWatch(1);
            foreach(var res in results)
            {
                Console.WriteLine(res);
            }*/

            //Console.WriteLine(s.LongestSubstring("aaabb", 3));
            //Console.WriteLine(s.LongestSubstring("ababbc", 2));

            //Console.WriteLine(s.IncreasingTriplet(new int[]{1,2,3,1,2,1}));
            /*Console.WriteLine(s.CountAndSay(1));
            Console.WriteLine(s.CountAndSay(2));
            Console.WriteLine(s.CountAndSay(3));
            Console.WriteLine(s.CountAndSay(4));
            Console.WriteLine(s.CountAndSay(5));*/


            /*Console.WriteLine(s.Search(new int[]{4,5,6,7,0,1,2}, 0));
            Console.WriteLine(s.Search(new int[]{4,5,6,7,0,1,2}, 2));
            Console.WriteLine(s.Search(new int[]{4,5,6,7,0,1,2}, 6));
            Console.WriteLine(s.Search(new int[]{4,5,6,7,0,1,2}, 3));*/
            /*
            Console.WriteLine(s.FindDuplicate(new int[]{1, 3, 4, 2, 2, 2}));

            Console.WriteLine(s.FindDuplicate(new int[]{3,1,3,4,2}));

            Console.WriteLine(s.FindDuplicate(new int[]{8,7,1,10,17,15,18,11,16,9,19,12,5,14,3,4,2,13,18,18})); */

            /*
            Console.WriteLine(s.FreqAlphabets("10#11#12"));
            Console.WriteLine(s.FreqAlphabets("1326#"));
            Console.WriteLine(s.FreqAlphabets("25#"));
            Console.WriteLine(s.FreqAlphabets("12345678910#11#12#13#14#15#16#17#18#19#20#21#22#23#24#25#26#"));*/

            //Console.WriteLine(s.LadderLength("hit", "cog", new List<string>{"hot","dot","dog","lot","log","cog"}));
            //Console.WriteLine(s.LadderLength("hit", "cog", new List<string>{"hot","dot","dog","lot","log"}));

            //Console.WriteLine(string.Join("\t", s.DailyTemperatures(new int[]{73, 74, 75, 71, 69, 72, 76, 73})));

            //Console.WriteLine(s.MaxProfitWithCoolDown(new int[]{1,2,3,0,2}));

            //Console.WriteLine(s.FindKthLargest(new int[]{3,2,3,1,2,4,5,5,6}, 4));

            //Console.WriteLine(s.FindKthLargest(new int[]{3,2,1,5,6,4}, 2));

            //Console.WriteLine(s.DecodeString2("3[a]2[bc]"));
            //Console.WriteLine(s.DecodeString2("3[a2[c]]"));

            //Console.WriteLine(s.MaxFreq("aabcabcab", 2, 2, 3));
            //Console.WriteLine(s.MaxProduct(new int[]{2,3,-2,4}));

            ///Console.WriteLine(s.MinRemoveToMakeValid("lee(t(c)o)de)"));

            /*
            var results = s.FullJustify(new string[]{"Science","is","what","we","understand","well","enough","to","explain","to","a","computer.","Art","is","everything","else","we","do"},20);
            foreach(var result in results)
            {
                Console.WriteLine("|" + result + "|");
            }*/

            //Console.WriteLine(s.IsInterleave("aabcc", "dbbca","aadbbcbcac"));
            //Console.WriteLine(s.Trap(new int[]{0,1,0,2,1,0,1,3,2,1,2,1}));
            /*
            Console.WriteLine(s.FindUnsortedSubarray2(new int[] {2, 1}));
            Console.WriteLine("---------------");

            Console.WriteLine(s.FindUnsortedSubarray2(new int[]{2,6,4,8,10,9,15}));
            Console.WriteLine("---------------");
            Console.WriteLine(s.FindUnsortedSubarray2(new int[]{1, 2, 3, 4}));

            Console.WriteLine(s.ReverseWords("the sky is blue"));*/

            //Console.WriteLine(s.IntegerBreak(10));

            //Console.WriteLine(s.MinSubArrayLen(7, new int[]{2,3,1,2,4,3}));

            //int[] arr = new int[]{12, 11, 13, 5, 6, 7}; 
            //Console.WriteLine(string.Join("-", s.SortArray(arr)));

            //Console.WriteLine(s.Jump(new int[]{2,3,0,1,4}));
            /*Console.WriteLine(s.ReverseStringInParenthesis("(abcd)"));
            Console.WriteLine(s.ReverseStringInParenthesis("(oi(love)ew)"));
            Console.WriteLine(s.ReverseStringInParenthesis("(abcd)") == "dcba");
            Console.WriteLine(s.ReverseStringInParenthesis("(oi(love)ew)") == "weloveio");
            Console.WriteLine(s.ReverseStringInParenthesis("(oi(love)ew") == "error");
            Console.WriteLine(s.ReverseStringInParenthesis("(oi(love)ew") == "error");
            Console.WriteLine(s.ReverseStringInParenthesis("ab)") == "error");
            Console.WriteLine(s.ReverseStringInParenthesis("") == "");*/

           // Console.WriteLine(s.CheckValidString("(((())))"));

            //Console.WriteLine(string.Join("-", s.MajorityElement2(new int[]{1,2,2,3,2,1,1,3})));
            Console.WriteLine((new Solution128()).LongestConsecutive(new int[]{100, 4, 200, 1, 3, 2}));

            Console.WriteLine((new Solution3()).LengthOfLongestSubstring_SlidWindow("abcabcbb"));
            
        }
    }

    public class Solution {

        // 647 in git
        public int CountSubstrings(string s) {
            if(string.IsNullOrEmpty(s)) return 0;
            int len = s.Length;
            bool[,] dp = new bool[len, len];
            int result = 0;
            
            for(int i =len-1; i >=0 ; --i)
                for(int j =i; j < len; ++j)
                {
                    if(s[i] == s[j] && (j <= i +1 || dp[i+1, j-1]))
                    {
                        dp[i, j] = true;
                        result++;
                    }
                }
            
            return result;
        }
        
        // 932 in git
        public int[] BeautifulArray(int N) {
            List<int> results = new List<int>();
            results.Add(1);
            while(results.Count < N)
            {
                List<int> tmp = new List<int>();
                foreach(var res in results)
                {
                    tmp.Add(2*res-1);
                }
                foreach(var res in results)
                {
                    tmp.Add(2*res);
                }
            }

            return results.Where(n => n<= N).ToArray();
        }
        // 1349 contest in git
         public int MaxStudents(char[][] seats) {
            var m = seats.Length;
            int n = seats[0].Length;

            int[,] map  = new int[m, n];
            for(int i =0; i < m; ++i)
                for(int j =0; j < n; ++j)
                {
                    if(seats[i][j] == '#')
                        map[i, j] = -1;
                    else
                    {   int cnt = 0;
                        if(j -1 >=0 && seats[i][j-1] == '.') cnt ++;
                        if(j +1 < n && seats[i][j+1] == '.') cnt ++;
                        if(j -1 >=0 && i - 1 >=0 && seats[i-1][j-1] == '.') cnt ++;
                        if(j +1 < n && i - 1 >=0 && seats[i-1][j+1] == '.') cnt ++;

                        map[i, j] = cnt;
                    }
                }
            while(true)
            {
                int ki =0;
                int kj =0;
                int maxSeen = 0;
                for(int i =0; i < m; ++i)
                    for(int j =0; j < n; ++j)
                    {
                        if(map[i, j] > maxSeen)
                        {
                            ki = i;
                            kj = j;
                            maxSeen = map[i, j];
                        }
                    }
                if(maxSeen ==0)
                    break;
                
                map[ki, kj] = -1;
                if(kj -1 >=0 && map[ki,kj-1] >0) map[ki,kj-1] = map[ki,kj-1] -1;
                if(kj +1 < n  && map[ki,kj+1] >0) map[ki,kj+1] = map[ki,kj+1] -1;
                if(kj -1 >=0 && ki +1 <m  && map[ki +1 ,kj-1] >0) map[ki+1,kj-1] = map[ki+1,kj-1] -1;
                if(kj +1 < n && ki +1 <m  && map[ki +1 ,kj+1] >0) map[ki+1,kj+1] = map[ki+1,kj+1] -1;
            }

            int result = 0;
            for(int i =0; i < m; ++i)
                for(int j =0; j < n; ++j)
                {
                    if(map[i, j] == 0)
                    {
                        result ++;
                    }
                }
            return result;
        }
        
        // #848
        public string ShiftingLetters(string S, int[] shifts) {
            if(string.IsNullOrEmpty(S) || shifts == null || S.Length != shifts.Length)
                return S;

            for(int i = shifts.Length -1; i>=0; --i)
            {
                if(i == shifts.Length -1) 
                {
                    shifts[i] = shifts[i] % 26;
                }
                else
                {
                    shifts[i] = (shifts[i] +shifts[i+1]) % 26;
                }
            }

            char[] charArray = new char[S.Length];
            for(int i =0; i < S.Length; ++i)
            {
                charArray[i] = (char)(S[i] + shifts[i]);
            }

            return new string(charArray);
        }

        public string MinRemoveToMakeValidUsingCounter(string s) {
            if(string.IsNullOrEmpty(s)) return s;
            var charArray = s.ToCharArray();
            charArray = MinRemoveToMakeValid(charArray, '(', ')');
            Array.Reverse(charArray);
            charArray = MinRemoveToMakeValid(charArray, ')', '(');
            Array.Reverse(charArray);

            return new string(charArray);
        }
        public char[] MinRemoveToMakeValid(char[] charArray, char open, char close)
        {
            var result = new List<char>();
            int cnt =0;
            for(int i = 0; i < charArray.Length; ++ i)
            {
                char c = charArray[i];
                if(c == open) cnt ++;
                else if (c == close)
                {
                    // skip this close if no enough open in the left
                    if(cnt ==0) continue;
                    cnt --;
                }
                result.Add(c);
            }

            return result.ToArray();
        }

        public char[] MinRemoveToMakeValid2(char[] charArray, char[] order)
        {
            var list = new List<char>();
            int open = 0;
            foreach(var ch in charArray)
            {
                if(ch == order[0]) 
                    open++;
                else if(ch == order[1])
                {
                    if(open == 0)
                        continue;
                    open--;
                }
                list.Add(ch);
            }
            return list.ToArray();
        }
        //#1249
        public string MinRemoveToMakeValid(string s) {
            if(string.IsNullOrEmpty(s)) return s;

            Stack<int> stack = new Stack<int>();
            HashSet<int> toRemovePos = new HashSet<int>();
            for(int i =0; i < s.Length; ++i)
            {
                if(s[i] == '(')
                {
                    stack.Push(i);
                }
                else if(s[i] == ')')
                {
                    if(stack.Count ==  0) {
                        toRemovePos.Add(i);
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
            foreach(var n in stack)
            {
                toRemovePos.Add(n);
            }

            var result = string.Empty;
            for(int i =0; i < s.Length; ++i)
            {
                if(!toRemovePos.Contains(i))
                    result += s[i];
            }
            return result;
        }

        //#301. Remove Invalid Parentheses
        public IList<string> RemoveInvalidParentheses(string s) {
            IList<string> results = new List<string>();
            if(string.IsNullOrEmpty(s)) return results;

            Stack<int> stack = new Stack<int>();
            HashSet<int> toRemovePos = new HashSet<int>();
            for(int i =0; i < s.Length; ++i)
            {
                if(s[i] == '(')
                {
                    stack.Push(i);
                }
                else if(s[i] == ')')
                {
                    if(stack.Count ==  0) {
                        toRemovePos.Add(i);
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
            foreach(var n in stack)
            {
                toRemovePos.Add(n);
            }

            var result = string.Empty;
            for(int i =0; i < s.Length; ++i)
            {
                if(!toRemovePos.Contains(i))
                    result += s[i];
            }
            results.Add(result);

            return results;
        }

        public IList<string> BFSRemoveInvalidParentheses(string s) 
        {
            IList<string> results = new List<string>();
            HashSet<string> visited = new HashSet<string>();
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(s);
            bool found = false;
            while(queue.Count >0)
            {
                var current = queue.Dequeue();
                if(IsValidParenthesesByCounter(current))
                {
                    results.Add(current);
                    found = true;
                    continue;
                }

                // If found, only need to finish the above logic, check other items in the queue which is under the same level.
                if(found)
                    continue;

                for(int i =0; i < current.Length; ++i)
                {
                    if (current[i] != '(' && current[i] != ')') continue;
                    var newStr = current.Substring(0, i) + current.Substring(i+1);
                    if(!visited.Contains(newStr))
                    {
                        visited.Add(newStr);
                        queue.Enqueue(newStr);
                    }
                }
            }

            return results;
        }
        public bool IsValidParenthesesByCounter(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }
            
            int cnt = 0;
            for (int i = 0; i < s.Length; ++i) {
                if (s[i] == '(') ++cnt;
                else if (s[i] == ')' && --cnt < 0) return false;
            }
            return cnt == 0;
        }

        //#20 valid Parentheses
        public bool IsValidParentheses(string s) {
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();
            foreach (var c in s)
            {
                if (stack.Count > 0 &&
                    (stack.Peek() == '(' && c == ')' ||
                    stack.Peek() == '{' && c == '}' ||
                    stack.Peek() == '[' && c == ']'))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }

        public bool CheckValidStringCounter(string s) 
        {
            int left = 0;
            for(int i =0; i < s.Length; ++i)
            {
                var c = s[i];
                if(c == '(' || c== '*') left ++;
                else left --;
                if(left <0) return false;
            }

            if(left ==0) return true;
            
            int right = 0;
            for(int i = s.Length -1; i>=0; --i)
            {
                 var c = s[i];
                if(c == ')' || c== '*') right ++;
                else right --;
                if(right <0) return false;
            }

            return true;
        }
        public bool CheckValidString(string s) {
            Stack<char> stack = new Stack<char>();
            // after the first iteration: all simple () can be removed
            for(int i =0; i < s.Length; ++i)
            {
                var c= s[i];
                if(c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if(stack.Count ==0)
                        return false;

                    List<char> chars = new List<char>();
                    while(stack.Count >0 )
                    {
                        if(stack.Peek() == '(')
                        {
                            stack.Pop();
                            foreach(var tmp in chars)
                            {
                                stack.Push(tmp);
                            }
                            break;
                        }
                        else if(stack.Peek() == ')')
                        {
                            if(chars.Count >0)
                            {
                                chars.RemoveAt(0);
                                foreach(var tmp in chars)
                                {
                                    stack.Push(tmp);
                                }
                                break;
                            }
                            else
                            {
                                return false;
                                //stack.Push(c);
                            }
                        }
                        else
                        {
                            chars.Add(stack.Pop());
                        }
                    }

                    if(stack.Count == 0 && chars.Count >0)
                    {
                        chars.RemoveAt(0);
                        foreach(var tmp in chars)
                        {
                            stack.Push(tmp);
                        }
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }
            Console.WriteLine(string.Join('-', stack));
            var newStack = new Stack<char>();
            
            while(stack.Count >0 )
            {
                if(stack.Peek() == '(')
                {
                    stack.Pop();

                    if(newStack.Count == 0 || newStack.Pop() != '*')
                        return false;
                }
                else
                {
                    newStack.Push(stack.Pop());
                }
            }

            return true;
        }



        public decimal GetMedian(int[] array)
        {
            int[] tempArray = array;
            int count = tempArray.Length;

            Array.Sort(tempArray);

            decimal medianValue = 0;

            if (count % 2 == 0)
            {
                // count is even, need to get the middle two elements, add them together, then divide by 2
                int middleElement1 = tempArray[(count / 2) - 1];
                int middleElement2 = tempArray[(count / 2)];
                medianValue = (middleElement1 + middleElement2) / 2;
            }
            else
            {
                // count is odd, simply get the middle element.
                medianValue = tempArray[(count / 2)];
            }

            return medianValue;
        }

        public string ReverseStringInParenthesis(string input, string invalid= "error")
        {
            if(string.IsNullOrEmpty(input))
            {
                return input;
            }
            
            // Stack need to persisit the index of character
            Stack<char> stack = new Stack<char>();
            // O(n)
            for(int i =0; i < input.Length; ++i)
            {
                if(input[i] == '(')
                {
                    stack.Push('(');
                }
                else if(input[i] == ')')
                {
                    List<char> subStr = new List<char>();
                    while(stack.Count >0)
                    {
                        if(stack.Peek()== '(')
                        {
                            stack.Pop();
                            //subStr.Reverse();
                            foreach(var c in subStr)
                            {
                                stack.Push(c);
                            }
                            break;
                        }
                        else
                        {
                            subStr.Add(stack.Pop());
                        }
                    }
                    // has a opening on the left
                    if(stack.Count ==0)
                    {
                        return invalid;
                    }
                }
                else if(input[i] >= 'a' && input[i] <= 'z')
                {
                    stack.Push(input[i]);
                }
                else
                {
                    return invalid;
                }
            }
            
            var result = stack.ToList<char>();
            result.Reverse();
            var output = string.Join("", result);
            if(output.Contains('(')) return invalid;
            else return output;
        }
    
        public static string ReverseString( string s )
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse( charArray );
            return new string( charArray );
        }

        public static string ReverseSubString( string str , int left, int right)
        {
            if(string.IsNullOrEmpty(str) || left >= right || left <0 || right >= str.Length)
            {
                return str;
            }

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray, left, right - left +1);
            return new string( charArray );
        }

        //O(n)
        public static string ReverseSubString2(string str, int left, int right)
        {
            StringBuilder output = new StringBuilder(str);
            if(string.IsNullOrEmpty(str) || left >= right || left <0 || right >= str.Length)
            {
                return str;
            }
            
            while(left < right)
            {
                output[left] = str[right];
                output[right] = str[left];
                left ++;
                right --;
            }
            
            return output.ToString();
        }

        public int NetworkDelayTime(int[][] times, int N, int K) {
            int[,] network = new int[N, N];
            
            for(int i = 0; i < N; ++i)
            {
                for(int j =0; j< N; ++j)
                {
                    network[i, j] = 0;
                }
            }
            for(int i =0; i < times.Length; ++i)
            {
                network[times[i][0] - 1, times[i][1] - 1] = times[i][2];
            }

            HashSet<int> visited = new HashSet<int>();
            HashSet<int> route = new HashSet<int>();
            
            var delay = DFSVisitNetwork(network, N, K-1, visited, route);

            if(visited.Count < N || delay > 100000) return -1;
            else return delay;
        }

        public int DFSVisitNetwork(int[,] network, int N, int i, HashSet<int> visited, HashSet<int> route)
        {
            if(route.Contains(i))
                return int.MaxValue;
            
            visited.Add(i);
            route.Add(i);
            int max = 0;
            for(int j =0; j <N; ++j)
            {
                if(network[i,j]>0)
                {
                    max = Math.Max(max, network[i,j] + DFSVisitNetwork(network, N, j, visited, route));
                }
            }
            route.Remove(i);
            return max;
        }

        public static void FindPurchaseItems(float current, List<string> items, float receipt, Dictionary<string, float> menuItems, List<List<string>> results)
        {
            if(current == receipt)
            {
                List<string> result = new List<string>(items);
                
                results.Add(result);
                return;
            }
            else if(current > receipt)
            {
                return;
            }
            else
            {
                foreach(var item in menuItems)
                {
                    var cnt = items.Count;
                    items.Add(item.Key);
                    FindPurchaseItems(current + item.Value, items, receipt, menuItems, results);
                    items.RemoveAt(cnt);
                }
            }
        }
        
        public static List<string> DPFindPurchaseItems(float receipt, Dictionary<string, float> menuItems)
        {
            // Step 1: Initilize the dp array
            int target = (int)(100F * receipt); 
            int[] dpCnt = new int[target + 1];
            dpCnt[0] = 0;
            
            List<List<string>> dpItems = new List<List<string>>();
            dpItems.Add(new List<string>());
            
            //Step 2: update the DP array
            for(int i = 1; i <= target; ++i)
            {
                int minItems = int.MaxValue;
                
                int purchaseCnt = 0;
                string purchaseItem = string.Empty;
                int priorPos = 0;
                foreach(var item in menuItems)
                {
                    int cnt = 1;
                    while(i >= (int)(item.Value * 100.0F) *cnt)
                    {
                        int pos = i - (int)(item.Value * 100.0F) *cnt;
                        if(dpCnt[pos] >=0)
                        {
                            if(cnt + dpCnt[pos] < minItems)
                            {
                                minItems = cnt + dpCnt[pos];

                                purchaseCnt = cnt;
                                purchaseItem = item.Key;
                                priorPos = pos;
                            }
                        }
                        cnt++;
                    }
                }
                
                if(minItems == int.MaxValue)
                {
                    dpCnt[i] = -1;
                    dpItems.Add(new List<string>());
                }
                else
                {
                    dpCnt[i] = minItems;
                    
                    var newItems = new List<string>();
                    foreach(var temp in dpItems[priorPos])
                    {
                        newItems.Add(temp);
                    }
                    for(int k =0; k < purchaseCnt; ++k)
                    {
                        newItems.Add(purchaseItem);
                    }
                    dpItems.Add(newItems);
                }
            }
            //Console.WriteLine(string.Join("|", dpCnt));
            
            // R
            //Console.WriteLine(dpCnt[target]);
            return dpItems[target];
        }
        public string LongestWord(string[] words) {
            Dictionary<int, HashSet<string>> wordsByLen = new Dictionary<int, HashSet<string>>();

            foreach(var wrd in words)
            {
                if(!wordsByLen.ContainsKey(wrd.Length))
                {
                    wordsByLen.Add(wrd.Length, new HashSet<string>());
                }

                var hs = wordsByLen[wrd.Length];
                hs.Add(wrd);
                wordsByLen[wrd.Length] = hs;
            }

            
            string res = string.Empty;
            if(!wordsByLen.ContainsKey(1)) return string.Empty;
            HashSet<string> validResults = wordsByLen[1];
            int len = 2;
            while(true)
            {
                if(wordsByLen.ContainsKey(len))
                {
                    HashSet<string> nextResults = new HashSet<string>();
                    
                    foreach(var wrd in wordsByLen[len])
                    {
                        if(validResults.Contains(wrd.Substring(0, wrd.Length -1)))
                        {
                            nextResults.Add(wrd);
                        }
                    }
                    
                    if(nextResults.Count == 0)
                        break;
                    else
                        validResults = nextResults;
                }
                else
                {
                    break;
                }
                len ++;
            }
            return validResults.OrderBy(q => q).ToList().FirstOrDefault();
        }

        // Return the longest words in the words list 
        // If multi longest words occur, reurn the first one.
        public static string FindLongestEnglishWord(List<string> words, List<string> symbols)
        {
            if(words == null || words.Count == 0) return string.Empty;
            var clenedWords = CleanWords(words, symbols);
            
            int maxSize = 0;
            string longestWord = string.Empty;
            foreach(var word in clenedWords)
            {
                if(word.Length > maxSize)
                {
                    longestWord = word;
                    maxSize = word.Length;
                }
            }
            
            return longestWord;
        }
        
        // 0(n*m)
        // symbols is positive or whitelist. 
        public static List<string> CleanWords(List<string> words, List<string> symbols)
        {
            if(symbols == null || symbols.Count == 0)
                return words;
            
            if(words == null || words.Count ==0) 
                return words;
                
            List<string> cleanedWords = new List<string>();
            foreach(var word in words)
            {
                // For each word, check it can built from the symbol    
                if(String.IsNullOrEmpty(word)) continue;
                
                if(VerifyWordInSymbols(word, symbols))
                {
                    cleanedWords.Add(word);
                }       
            }
            
            return cleanedWords;
        }
        
        public static bool VerifyWordInSymbols(string word, List<string> symbols)
        {
            if(String.IsNullOrEmpty(word)) return true;
            
            //Console.WriteLine(word);   
            foreach(var symbol in symbols)
            {
                if(word == symbol) return true;
                
                if(word.Contains(symbol))
                {
                    var pos = word.IndexOf(symbol);
                    
                    /*Console.WriteLine(word);
                    Console.WriteLine(word.Substring(0, pos));
                    Console.WriteLine(word.Substring(pos + symbol.Length));*/
                    
                    if(VerifyWordInSymbols(word.Substring(0, pos), symbols) && VerifyWordInSymbols(word.Substring(pos + symbol.Length), symbols))
                        return true;
                }
            }
            
            
            return false;
        }
        

        public static void Test(List<int> nums)
        {
            Console.WriteLine("Input:");
            if(nums == null) 
                Console.WriteLine("");
            else
                Console.WriteLine(string.Join(",", nums));
            
            var results = Compute3ItemSumZero(nums);
            
            Console.WriteLine("Output:");
            foreach(var res in results)
            {
                Console.WriteLine(String.Format("{0}|{1}|{2}", res.Item1, res.Item2, res.Item3));
            }
        }
        
        public static HashSet<Tuple<int, int, int>> Compute3ItemSumZero(List<int> nums)
        {
            HashSet<Tuple<int, int,int>> results = new HashSet<Tuple<int, int, int>>();
            
            if(nums == null || nums.Count < 3)
            {
                return results;
            }
            
            
            // O(nlog(n))
            nums.Sort();
            
            // O(n * n)
            for(int i =0; i < nums.Count; ++i)
            {
                int target = -1 * nums[i];
                
                int leftIdx = i +1;
                int rightIdx = nums.Count -1;
                
                while(leftIdx < rightIdx)
                {
                    int sum = nums[leftIdx] + nums[rightIdx];
                    if(sum == target)
                    {
                        results.Add(Tuple.Create(nums[i], nums[leftIdx], nums[rightIdx]));
                        leftIdx ++;
                        rightIdx --;
                    }
                    else if(sum < target)
                    {
                        leftIdx ++;
                    }
                    else
                    {
                        rightIdx --;
                    }
                }
            }
            
            return results;
        }

        public int ShortestBridge(int[][] A) {
            int m = A.Length;
            int n = A[0].Length;

            int x=-1, y=-1;
            for(int i = 0; i < m; ++i)
            {
                for(int j =0; j < n; ++j)
                {
                    if(A[i][j] == 1)
                    {
                        x = i;
                        y = j;
                        break;
                    }
                }

                if(x >=0) break;
            }
            
            HashSet<Tuple<int, int>>  islandEdge = new HashSet<Tuple<int, int>>();
            DFSIsland(A, x, y,m,n, islandEdge);
            return BFSIsland(A, m, n, islandEdge);
        }

        public int BFSIsland(int[][] A, int m, int n, HashSet<Tuple<int, int>> points)
        {
            int result = 0;
            
            HashSet<string> pointsVisited = new HashSet<string>();
            foreach(var p in points)
            {
                pointsVisited.Add(string.Format("{0}-{1}", p.Item1, p.Item2));
            }

            while(true)
            {
                HashSet<Tuple<int, int>> nextPoints = new HashSet<Tuple<int, int>>();

                if(points.Count ==0) return -1;
                Console.WriteLine(result);
                Console.WriteLine(string.Join("|", points.Select(x => x.Item2.ToString() + "," + x.Item2.ToString())));
                foreach(var point in points)
                {
                    
                    int x = point.Item1;
                    int y = point.Item2;
                    var res1 = CheckIsBridge(A, x -1, y, m, n, pointsVisited);
                    var res2 = CheckIsBridge(A, x +1, y, m, n, pointsVisited);
                    var res3 = CheckIsBridge(A, x , y-1, m, n, pointsVisited);
                    var res4 = CheckIsBridge(A, x , y+1, m, n, pointsVisited);
                    if(res1 == false || res2 == false || res3 == false || res4 == false)
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine(x);
                        Console.WriteLine(y);
                        return result;
                    }

                    if(res1 == true) nextPoints.Add(Tuple.Create(x-1, y));
                    if(res2 == true) nextPoints.Add(Tuple.Create(x+1, y));
                    if(res3 == true) nextPoints.Add(Tuple.Create(x, y-1));
                    if(res4 == true) nextPoints.Add(Tuple.Create(x, y+1));
                }

                points = nextPoints;
                result ++;
            }
        }

        public bool? CheckIsBridge(int[][] A, int x, int y, int m, int n,HashSet<string> blackList)
        {
            if(x <0 || x>=m || y<0 || y>=n || blackList.Contains(string.Format("{0}-{1}",x,y)))
                return null;
            
            // reach to 2nd island
            if(A[x][y] == 1)
                return false;

            return true;
        }

        public bool DFSIsland(int[][] A, int x, int y, int m, int n, HashSet<Tuple<int, int>> edge)
        {
            if(x <0 || x>=m || y<0 || y>=n)
                return false;
            if(A[x][y] == 0)
                return true;

            if(edge.Contains(Tuple.Create(x, y)))
                return false;

            if(DFSIsland(A, x-1, y, m, n, edge) || DFSIsland(A, x+1, y, m, n, edge) || 
               DFSIsland(A, x, y-1, m, n, edge) || DFSIsland(A, x, y+1, m, n, edge))
            {
                edge.Add(Tuple.Create(x, y));
                return true;
            }

            return false;
        }


        public int JumpGreedy(int[] nums) {
            int res = 0, n = nums.Length, i = 0, cur = 0;
            while (cur < n - 1) {
                ++res;
                int pre = cur;
                for (; i <= pre; ++i) {
                    cur = Math.Max(cur, i + nums[i]);
                }
                if (pre == cur) return -1; // May not need this
            }
            return res;
        }

        public int Jump(int[] nums) {
            if(nums == null || nums.Length == 0) return 0;
            int n = nums.Length;
            int[] dp = new int[n];
            dp[n-1] = 0;

            for(int i = n-2; i >= 0; --i)
            {
                int min = int.MaxValue;
                for(int r = 1; r <= nums[i] && i + r <=n-1; r ++)
                {
                    min = Math.Min(min, dp[i + r]);

                    if(min == 0) break;
                }
                
                dp[i] = min == int.MaxValue? min: min +1;
            }

            //Console.WriteLine(string.Join("-", dp));
            return dp[0] < int.MaxValue ? dp[0]: -1;
        }

        // Jump game
        public bool CanJump(int[] nums) {
            int size = nums.Length;
            if(size == 0) return true;
            int reach = 0;
            for(int i = 0; i < size; ++i)
            {
                // if the current reach cannot arrive this position, need to break and stop
                if(reach < i || reach >= size -1) break;

                // Update the max reach : either is the previous max reach or update using the power of this position
                reach = Math.Max(reach, i + nums[i]);
            }

            return reach >= size-1;
        }

        public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
            int left = Math.Max(A,E), right = Math.Max(Math.Min(C,G), left);
            int bottom = Math.Max(B,F), top = Math.Max(Math.Min(D,H), bottom);
            return (C - A) * (D - B) - (right - left) * (top - bottom) + (G - E) * (H - F);
        }

        public int[][] Transpose(int[][] A) {
            // col in A becomes row in transpose
            int[][] transpose = new int[A[0].Length][];
            
            for(int i = 0; i<A[0].Length; i++)
            {
                // row in A becomes col in transpose
                transpose[i] = new int[A.Length];
                for(int j = 0; j<A.Length; j++)
                {
                    transpose[i][j] = A[j][i];
                }
            }
            
            return transpose;
        }

        public int[] FindDiagonalOrder(int[][] matrix) {
            // 1 is up, 0 is down
            bool direction = true;
            int m = matrix.Length;
            if(m ==0) return new int[0];
            int n = matrix[0].Length;
            if(n ==0) return new int[0];
            int[] results = new int[m*n];

            int i = 0;
            int j = 0;
            int k = 0;
            while(true)
            {
                while(i >= 0 && i < m && j >=0 && j < n)
                {
                    results[k++] = matrix[i][j];
                    if(direction)
                    {
                        i--;j++;
                    }
                    else
                    {
                        i++;j--;
                    }
                }
                
                if(k == m*n)
                    break;
                
                if(direction)
                {
                    i++;j--;
                    
                    if(j + 1< n)
                    {
                        j++;
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    i--; j ++;
                    if(i + 1 < m)
                    {
                        i++;
                    }
                    else
                    {
                        j++;
                    }
                }
                //Console.Write(i);
                //Console.WriteLine(j);
                direction = !direction;
                if(i == m-1 && j == n-1)
                {
                    results[k++] = matrix[i][j];
                    break;
                }
            }

            return results;
        }

        public int NumDistinct(string s, string t) {
            if(s == null && t == null) return 1;
            if(s == null) return 0;
            if(t == null) return 1;

            int m = s.Length;
            int n = t.Length;

            int[,] dp = new int[m+1, n+1];

            dp[0, 0] = 1;
            for(int i =1; i < n; ++i)
            {
                dp[0, i] = 0;
            }
            for(int i =1; i < m; ++i)
            {
                dp[i, 0] = 1;
            }

            for(int i = 1; i <= m; ++i)
                for(int j = 1; j <= n; ++j)
                {
                    dp[i, j] = dp[i-1, j] ;

                    if(s[i-1] == t[j-1])
                    {
                        dp[i,j]  += dp[ i-1, j-1];
                    }

                }
            
            return dp[m,n];
        }

        public int NumMatchingSubseq(string S, string[] words) 
        {
        // a list of strings for each letter in the alphabet
            List<string>[] arr = new List<string>[26];
            
            // for each letter in the alphabet, we'll have a list of strings from words array that start with that letter
            // For example: 'a': {'a', 'acd', 'ace'}
            foreach(string word in words)
            {
            // note: a lower case char - 'a' will give you an int in the range [0, 25]
                if(arr[word[0] - 'a'] == null)
                    arr[word[0] - 'a'] = new List<string>();
                arr[word[0] - 'a'].Add(word);
            }
            
            for(int i = 0; i < S.Length; i++)
            {
                // current character
                char curr = S[i];
                
                // pull the list of words with this character from the array
                List<string> waiting = arr[curr - 'a'];
                if(waiting == null || waiting.Count == 0) continue;
                
                // clear the current character's list
                arr[curr - 'a'] = null;
                
                // construct a new list, removing the current character from each
                // word since we're no longer waiting for this character
                List<string> newList = new List<string>();
                foreach(string word in waiting)
                    if(word.Length > 1)
                    newList.Add(word.Substring(1));  
                
                // loop thru the new list and assign each of the words 
                // to the appropriate bucket
                foreach(string n in newList)
                {
                    char first = n[0];
                    if(arr[first - 'a'] == null)
                        arr[first - 'a'] = new List<string>();
                    arr[first - 'a'].Add(n);
                }   
            }
            
            // the result is the number of full words from the words array that we processed
            int remaining = 0;
            for(int i = 0; i < 26; i++)
                if(arr[i] != null)
                    remaining += arr[i].Count;
            
            return words.Length - remaining;
        }

        public IList<int> SortArray(int[] nums) {
            MergeSort(nums, 0, nums.Length - 1);

            return nums.ToList();
        }

        public void Merge(int[] nums, int l1, int r1, int l2, int r2)
        {
            
            int[] nums1 = new int[r1 - l1 + 1];
            int[] nums2 = new int[r2 - l2 + 1];

            //Console.WriteLine(nums1.Length);
            //Console.WriteLine(nums2.Length);
            
            int i1 = 0;
            for(int i =l1; i <= r1; ++i)
            {
                nums1[i1++] = nums[i];
            }
            int i2 = 0;
            for(int i =l2; i <= r2; ++i)
            {
                nums2[i2++] = nums[i];
            }
            
            i1--;
            i2--;
            int k = r2;
            while(i1 >=0 && i2>=0)
            {
                if(nums1[i1] >= nums2[i2])
                {
                    nums[k--] = nums1[i1--];
                }
                else
                {
                    nums[k--] = nums2[i2--];
                }
            }

            while(i1 >=0)
            {
                nums[k--] = nums1[i1--];
            }

            while(i2 >=0)
            {
                nums[k--] = nums2[i2--];
            }
        }
        public void MergeSort(int[] nums, int left, int right)
        {
            if(left < right)
            {
                int middle = left + (right - left) /2;
                //Console.ReadKey();


                //Console.WriteLine(string.Format("{0}-{1}-{2}", left, middle, right));
                MergeSort(nums, left, middle);
                MergeSort(nums, middle + 1, right);

                Merge(nums, left, middle, middle + 1, right);
            }
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n) {
            int i = m-1;
            int j = n -1;
            int k = m + n -1;
            while(i>=0 && j>=0)
            {
                if(nums1[i] <= nums2[j])
                {
                    nums1[k -- ] = nums2[j--];
                }
                else
                {
                    nums1[k -- ] = nums1[i--];
                }
            }
            while(j>=0)
            {
                nums1[k -- ] = nums2[j--];
            }
        }

        public int MaxSubArray(int[] nums) {
            int maxSum = int.MinValue;
            int sum =0;
            for (int i = 0; i < nums.Length; ++i)
            {
                sum = Math.Max(nums[i], sum+nums[i]);
                maxSum = Math.Max(maxSum, sum);
            }
            return maxSum;
        }

        public int MinSubArrayLen(int s, int[] nums) {
            if(nums == null || nums.Length == 0 ) return 0;
            int left =0; 
            int right = 0;
            int sum = nums[0];
            int minLength = int.MaxValue;
            while(right < nums.Length)
            {
                while(sum < s)
                {
                    right ++;
                    if(right == nums.Length)
                    {
                        break;
                    }
                    sum += nums[right];
                }
                
                while(sum >= s && left <= right)
                {
                    
                    minLength = Math.Min(minLength, right - left + 1);

                    /*Console.WriteLine(minLength);
                    Console.WriteLine(sum);
                    Console.WriteLine(left.ToString() + "->" + right.ToString());*/
                    
                    sum -= nums[left];
                    left++;
                }
            }

            if(minLength == int.MaxValue) return 0;
            return minLength;
        }

        public bool PredictTheWinner(int[] nums) {
            return PlayTheNumPicks(nums, 0, 0, 0, nums.Length-1, 0);
        }

        //the condiction to let current user win is to let your competitor lose.
        public bool PlayTheNumPicks(int[] nums, int cur0, int cur1, int left, int right, int player) {
            
            if(right == left) 
            {
                if (player == 0)
                {
                    return cur0 + nums[left] >= cur1;
                }
                else
                {
                    return cur0 < cur1 + nums[left];
                }
            }
            else if(left>right)
            {
               return cur0 >= cur1; 
            }

            if (player == 0) 
            {
                //Let your competitors lose the game.
                return !PlayTheNumPicks(nums, cur0 + nums[left], cur1, left + 1, right, 1) 
                       || !PlayTheNumPicks(nums, cur0 + nums[right], cur1, left, right-1, 1);
            } 
            else 
            {
                return !PlayTheNumPicks(nums, cur0, cur1 + nums[left], left + 1, right, 0) 
                       || !PlayTheNumPicks(nums, cur0, cur1 + nums[right], left, right - 1, 0);
            }
        }

        public bool StoneGame(int[] piles) {
            return PlayStoneGame(piles, 0,0,0, piles.Length-1, 0);
        }

        public bool PlayStoneGame(int[] piles, int cur0, int cur1, int left, int right, int player) {
            if (left > right) 
                return cur0 > cur1;

            if (player == 0) 
            {
                return PlayStoneGame(piles, cur0 + piles[left], cur1, left + 1, right, 1) 
                       || PlayStoneGame(piles, cur0 + piles[right], cur1, left + 1, right, 1);
            } 
            else 
            {
                return PlayStoneGame(piles, cur0, cur1 + piles[left], left, right - 1, 0) 
                       || PlayStoneGame(piles, cur0, cur1 + piles[right], left, right - 1, 0);
            }
        }
        
        public int UniquePathsWithObstacles(int[][] obstacleGrid) {
            int m = obstacleGrid.Length;
            if(m ==0) return 0;
            int n = obstacleGrid[0].Length;
            if(n ==0) return 0;
            long[,] pathArray = new long[m, n];
            pathArray[0,0] = obstacleGrid[0][0] == 1? 0: 1;
            for(int i =1; i < m; i ++) 
            {
                if(obstacleGrid[i][0] == 1)
                    pathArray[i, 0] = 0;
                else
                    pathArray[i, 0] = pathArray[i-1, 0];
            }
            for(int i =1; i < n; i ++)
            {
                 if(obstacleGrid[0][i] == 1)
                    pathArray[0, i] = 0;
                else
                    pathArray[0, i] = pathArray[0, i-1];
            }

            for(int i = 1; i < m ; ++i)
            {
                for(int j = 1; j < n ; ++j)
                {
                    if(obstacleGrid[i][j] == 1) continue;
                    
                    pathArray[i, j] = pathArray[i-1, j] + pathArray[i, j-1];
                }
            }

            return (int)pathArray[m-1, n-1];
        }

        public int IntegerBreak(int n) {
            int[] dp = new int[n + 1];

            dp[0] = 1;
            dp[1] = 1;
            for(int i = 2; i <= n; ++i)
            {
                int max = int.MinValue;
                
                for(int j = i-1; j>=1; --j)
                {
                    max = Math.Max(max, (i - j)*dp[j]);
                    max = Math.Max(max, (i - j)*j);
                }
                dp[i] = max;
            }

            Console.WriteLine(string.Join("-", dp));
            return dp[n];
        }

        public class NumArray {
            List<int> dp = new List<int>();
            public NumArray(int[] nums) {
                dp.Add(0);
                for(int i = 0; i < nums.Length; ++i)
                {
                    dp.Add(dp[i] + nums[i]);
                }
            }
            
            public int SumRange(int i, int j) {
                return dp[j+1] - dp[i];
            }
        }


        public int FindMaxForm(string[] strs, int m, int n) {
            if(strs == null || strs.Length ==0 || m< 0 || n < 0) return 0;

            //dp
            int[,] dp = new int[m+1, n+1];

            foreach(var str in strs)
            {
                var cnt0 = str.Count(x => x=='0');
                var cnt1 = str.Count(x => x=='1');
                for(int i =m; i >= cnt0; --i)
                    for(int j = n; j >= cnt1; --j)
                    {
                        var cnt = 0;
                        if(i >= cnt0 && j>= cnt1)
                        {
                            cnt = 1 + dp[i - cnt0, j - cnt1];
                        }
                        dp[i, j] = Math.Max(dp[i, j], cnt);
                    }
            }
            
            return dp[m,n];
        }

        public string FractionToDecimal(int numerator, int denominator) {
            int sign = Math.Sign(numerator) * Math.Sign(denominator);
            if(sign == 0) return "0";


            StringBuilder sb = new StringBuilder();
            ulong num = (ulong) Math.Abs((long)numerator);
            ulong den = (ulong) Math.Abs((long)denominator);
            sb.Append(num/den);

            if(num % den != 0)
            {
                num = num % den;
                sb.Append(".");

                Dictionary<ulong, int> modMap = new Dictionary<ulong, int>();
                while(true)
                {
                    ulong mod = num % den;
                    if(mod==0)
                        break;
                    
                    if(modMap.ContainsKey(mod))
                    {
                        sb.Insert(modMap[mod], "(");
                        sb.Append(")");
                        break;
                    }
                    else
                    {
                        modMap.Add(mod, sb.Length);
                    }

                    
                    num *= 10;
                    sb.Append(num / den);
                    num = num % den;
                }
            }
            return ((sign < 0) ? "-" : string.Empty) + sb.ToString();
        }
        public int CompareVersion(string version1, string version2) {
            var v1 = version1.Split('.');
            var v2 = version2.Split('.');

            for(int i =0; i < v1.Length || i< v2.Length;++i)
            {
                int i1 = i>=v1.Length?0: int.Parse(v1[i]);
                int i2 = i>=v2.Length?0: int.Parse(v2[i]);

                if(i1> i2) return 1;
                else if(i1 < i2) return -1;
            }
            return 0;
        }
        public string ReverseWord(string s) {
            if(string.IsNullOrEmpty(s)) return s;
            char[] charArray = s.ToCharArray();
            Array.Reverse( charArray );
            return new string( charArray );
        }
        public string ReverseWords(string s) {
            var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<string> results = new List<string>();
            foreach(var word in words)
            {
                results.Add(word);
            }
            results.Reverse();
            return string.Join(' ',results).Trim();
        }

        public IList<IList<int>> Generate(int numRows) {

            IList<IList<int>> results = new List<IList<int>>();
            if(numRows < 1 ) return results;

            results.Add(new List<int>() {1});
            for(int i = 1; i < numRows; ++ i)
            {
                IList<int> numbers = new List<int>();
                for(int j =0; j <= i; ++j)
                {
                    if(j == 0 || j == i)
                    {
                        numbers.Add(1);
                    }
                    else
                    {
                        numbers.Add(results[i-1][j] + results[i-1][j -1 ] );
                    }
                }
                results.Add(numbers);
            }

            return results;
        }
        public bool IsAnagram(string s, string t) {
            if(String.IsNullOrEmpty(s) && String.IsNullOrEmpty(t) ) return true;
            if(String.IsNullOrEmpty(s) || String.IsNullOrEmpty(t)) return false;
            if(s.Length != t.Length) return false;
            int[] sMap = new int[26];
            int[] tMap = new int[26];
            
            for(int i = 0; i < s.Length; ++i)
            {
                sMap[s[i] - 'a']  =  sMap[s[i] - 'a']  + 1;
                tMap[t[i] - 'a']  =  tMap[t[i] - 'a']  + 1;
            }

            for(int i =0; i < 26; ++i)
            {
                if(sMap[i] != tMap[i])
                    return false;
            }
            return true;
        }

        public int FindUnsortedSubarray2(int[] nums) {
            var min = int.MaxValue;
            var max = int.MinValue;

            for(var i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    min = Math.Min(min, nums[i + 1]);
                }
            }

            for (var i = nums.Length - 1; i >= 1; i--)
            {
                if (nums[i - 1] > nums[i])
                {
                    max = Math.Max(max, nums[i - 1]);
                }
            }

            Console.WriteLine(min);
            Console.WriteLine(max);
            var head = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                if (min < nums[i])
                {
                    head = i;
                    break;
                }
            }

            var tail = 0;
            for(var i = nums.Length - 1; i >= 0; i--)
            {
                if (max > nums[i])
                {
                    tail = i;
                    break;
                }
            }

            Console.WriteLine(tail);
            Console.WriteLine(head);

            return tail > head ? tail - head + 1: 0;
        }
        public int FindUnsortedSubarray(int[] nums) {
            int leftOrdered = 0;
            
            while(leftOrdered < nums.Length)
            {
                if(leftOrdered >0 && nums[leftOrdered] < nums[leftOrdered - 1])
                    break;
                leftOrdered ++;
            }

            int rightOrdered = nums.Length - 1;
            while(rightOrdered >= 0)
            {
                if(rightOrdered < nums.Length - 1 && nums[rightOrdered] > nums[rightOrdered + 1])
                    break;
                rightOrdered --;
            }
            

            int min = int.MaxValue;
            int max = int.MinValue;
            for(int i = leftOrdered; i <= rightOrdered; ++i)
            {
                if(nums[i] < min) min = nums[i];
                if(nums[i] > max) max = nums[i];
            }
            
            if(leftOrdered > rightOrdered) return 0;
            Console.WriteLine(leftOrdered);
            Console.WriteLine(rightOrdered);
            int l, r;

            if( min == int.MaxValue)
            {
                return nums.Length;
            }
            for (l = 0; l < nums.Length; l++) {
                if (min < nums[l])
                    break;
            }
            for (r = nums.Length - 1; r >= 0; r--) {
                if (max > nums[r])
                    break;
            }
            Console.WriteLine(l);
            Console.WriteLine(r);
            return r - l < 0 ? 0 : r - l + 1;
        }

        public void Solve(char[][] board) {
            int rows = board.Length;
            if(rows == 0) return;
            int columns = board[0].Length;
            if(columns ==0) return;

            for(int i =0; i< rows; ++i)
            {
                DFSSolveBoard(board, i, 0, rows, columns, '*');
                
                DFSSolveBoard(board, i, columns - 1, rows, columns, '*');
            }

            for(int j =0; j< columns; ++j)
            {
                DFSSolveBoard(board, 0, j, rows, columns, '*');
                DFSSolveBoard(board, rows-1, j, rows, columns, '*');
            }

            for(int i =1; i < rows -1 ; ++ i)
            {
                for(int j = 1; j < columns -1; ++j)
                {
                    DFSSolveBoard(board, i, j, rows, columns, 'X');
                }
            }

            for(int i =0; i < rows ; ++ i)
            {
                for(int j = 0; j < columns; ++j)
                {
                    if(board[i][j] == '*')
                        board[i][j] = 'O';
                }
            }
        }

        public void DFSSolveBoard(char[][] board, int i, int j, int rows, int columns, char target)
        {
            if(i <0 || i>= rows || j <0 || j >= columns)
            {
                return;
            }

            if(board[i][j] == 'O')
            {
                board[i][j] = target;
                DFSSolveBoard(board, i - 1, j, rows, columns, target);
                DFSSolveBoard(board, i + 1, j, rows, columns, target);
                DFSSolveBoard(board, i, j - 1, rows, columns, target);
                DFSSolveBoard(board, i, j + 1, rows, columns, target);
            }
            
            return;
        }

        public TreeNode InvertTree(TreeNode root) {
            //BFS visit and 
            BFSInvertTree(root);
            return root;
        }

        public void BFSInvertTree(TreeNode node)
        {
            if(node == null)
                return;
            
            var temp = node.left;
            node.left = node.right;
            node.right = temp;

            BFSInvertTree(node.left);
            BFSInvertTree(node.right);
        }
        public void ReorderList(ListNode head) {
             if(head == null || head.next == null) return;
            //left side has (n + 1)/2
            //right side has n/2
            // reverse the second part first.
            int length = 0;
            var node = head;
            while(node != null)
            {
                node = node.next;
                length ++;
            }
            
            int right = length /2;
            int left = length - right;
            
            var rightNode = head;
            
            length =0;
            while(rightNode != null)
            {
                length ++;
                rightNode = rightNode.next;
                
                if(length == left)
                { 
                    break;
                }
            }
            //Console.WriteLine(rightNode.val);
            ListNode rightHead = ReverseListNode(rightNode);
            ListNode leftHead = head;
            
            ListNode resultHead = new ListNode(0);
            ListNode resultNode = resultHead;
            //Console.WriteLine(left);
            //Console.WriteLine(right);
    
            /*ListNode tmp = rightHead;
            while(tmp != null)
            {
                Console.Write(tmp.val);
                tmp = tmp.next;
            }
            Console.WriteLine("---------------------");
    
            tmp = leftHead;
            while(tmp != null)
            {
                Console.Write(tmp.val);
                tmp = tmp.next;
            }
            //Console.WriteLine("---------------------");*/
    
            while(left >0 && right >0)
            {
                //Console.WriteLine("---------------------");
                left --;
                right --;
                
                var tmpL = leftHead.next;
                var tmpR = rightHead.next;
                resultNode.next = leftHead;
                resultNode = resultNode.next;
                
                //Console.WriteLine(leftHead.val);
                resultNode.next = rightHead;
                resultNode = resultNode.next;
                //Console.WriteLine(rightHead.val);
                
                leftHead = tmpL;
                rightHead = tmpR;
            }
            //Console.WriteLine(left);
            //Console.WriteLine(right);
            if(left==1)
            {
                resultNode.next = leftHead;
                resultNode = resultNode.next;
            }
            resultNode.next = null;

            head = resultHead.next;
        }

        public ListNode ReverseListNode(ListNode head)
        {
            if(head == null || head.next == null)
                return head;
            ListNode newHead = null;
            ListNode node = head;
            while(node != null)
            {
                var temp = node.next;
                node.next = newHead;
                newHead = node;
                node = temp;
            }

            return newHead;
        }
        public int MajorityElementV2(int[] nums) {

            int cnt = 0;
            int candidate = 0;
            for(int i =0; i< nums.Length; ++ i)
            {
                var num = nums[i];

                if(cnt ==0)
                {
                    candidate = num;
                    cnt ++;
                }
                else if(candidate == num)
                {
                    cnt ++;
                }
                else
                {
                    cnt --;
                }
            }

            return candidate;
        }
        //#229
        public IList<int> MajorityElement2(int[] nums) {
            int a = 0;
            int b = 0;
            int cntA = 0;
            int cntB = 0;
            foreach(var num in nums)
            {
                if(cntA > 0 && num == a)
                {
                    cntA++;
                }
                else if(cntB > 0 && num == b)
                {
                    cntB++;
                }
                else if(cntA ==0) 
                {
                    a = num;
                    cntA ++;
                }
                else if(cntB ==0)
                {
                    b = num;
                    cntB++;
                }
                else
                {
                    cntA--;
                    cntB--;
                }
            }

            cntA =0;
            cntB =0;
            foreach(var num in nums)
            {
                if(num == a)
                {
                    cntA ++;
                }
                else if(num == b)
                {
                    cntB ++;
                }
            }

            IList<int> results = new List<int>();
            if(cntA>nums.Length/3) results.Add(a);
            if(cntB>nums.Length/3) results.Add(b);

            return results;
        }
        public int MajorityElement(int[] nums) {
            Dictionary<int, int> numCnts = new Dictionary<int, int>();
            for(int i =0; i< nums.Length; ++ i)
            {
                var num = nums[i];
                if(!numCnts.ContainsKey(num) && i > nums.Length/2) continue;
                if(numCnts.ContainsKey(num))
                {
                    numCnts[num] = numCnts[num] +1;
                    if(numCnts[num] > nums.Length/2 + 1)
                    {
                        return num;
                    }
                }
                else
                {
                    numCnts.Add(num, 1);
                }
            }

            return numCnts.OrderByDescending(n=>n.Value).First().Key;
        }
        public int MySqrt(int x) {
            int i = 1, j = x;
            while(i < j){
                int mid = i + (j - i)/2;
                if(x / mid < mid)
                    j = mid;
                else
                    i = mid + 1;
            }

            return x / i < i ? i - 1 : i;
        }

        public ListNode GetIntersectionNode(ListNode head1, ListNode head2)
        {
            int length1 = 0;
            int length2 = 0;

            var cur1 = head1;
            var cur2 = head2;
            while (cur1 != null)
            {
                length1++;
                cur1 = cur1.next;
            }
            while (cur2 != null)
            {
                length2++;
                cur2 = cur2.next;
            }

            var diff = Math.Abs(length1 - length2);
            cur1 = head1;
            cur2 = head2;

            if (length1 > length2)
            {
                while (diff != 0)
                {
                    diff--;
                    cur1 = cur1.next;
                }
            }
            else if (length2 > length1)
            {
                while (diff != 0)
                {
                    diff--;
                    cur2 = cur2.next;
                }
            }

            while (cur1 != null && cur2 != null)
            {
                if (cur1 == cur2)
                {
                    return cur1;
                }

                cur1 = cur1.next;
                cur2 = cur2.next;
            }

            return null;
        }
        public int LargestRectangleArea(int[] heights) {
            int maxArea = 0;
            if(heights == null || heights.Length ==0) return maxArea;

            for(int i =0; i < heights.Length; ++i)
            {
                if(i + 1< heights.Length && heights[i]<= heights[i +1])
                {
                    continue;
                }
                //last one or the height will start decrease from next one.
                int j = i -1;
                int min = heights[i];
                while(j>=0)
                {
                    min = Math.Min(min, heights[j]);
                    int area = (i - j + 1) * min;
                    if(area>maxArea) maxArea = area;
                    j--;
                }
            }

            return maxArea;
        }
        public bool CanFinish(int numCourses, int[][] prerequisites) {
            Dictionary<int, List<int>> courseMap = new Dictionary<int, List<int>>();
            for(int i =0; i< numCourses; ++i)
            {
                courseMap.Add(i, new List<int>());
            }
            for(int i = 0; i< prerequisites.Length; ++i)
            {
                var c1 = prerequisites[i][0];
                var c2 = prerequisites[i][1];
                var depends = courseMap[c1];
                depends.Add(c2);
                courseMap[c1] = depends;
            }
            
            HashSet<int> courseList = new HashSet<int>();
            foreach(var course in courseMap)
            {
                if(!DFSVisitCourses(courseMap, new HashSet<int>(), course.Key, courseList))
                {
                    return false;
                }
            }

            return true;
        }

        public bool DFSVisitCourses(Dictionary<int, List<int>> courseMap, HashSet<int> targets, int current, HashSet<int> processed)
        {
            if(targets.Contains(current))
            {
                return false;
            }
            if(processed.Contains(current))
            {
                return true;
            }

            
            var depends = courseMap[current];
            if(depends.Count > 0) 
            {
                targets.Add(current);
                foreach(var d in depends)
                {
                    if(!DFSVisitCourses(courseMap, targets, d, processed))
                        return false;
                }
                targets.Remove(current);
            }

            processed.Add(current);
            return true;
        }

        public int[] FindOrder(int numCourses, int[][] prerequisites) {
            //DFS or BFS, treat this as multi trees.
            Dictionary<int, List<int>> courseMap = new Dictionary<int, List<int>>();
            for(int i =0; i< numCourses; ++i)
            {
                courseMap.Add(i, new List<int>());
            }
            for(int i = 0; i< prerequisites.Length; ++i)
            {
                var c1 = prerequisites[i][0];
                var c2 = prerequisites[i][1];
                var depends = courseMap[c1];
                depends.Add(c2);
                courseMap[c1] = depends;
            }
            
            HashSet<int> courseList = new HashSet<int>();
            foreach(var course in courseMap)
            {
                if(!DFSVisitCourses(courseMap, new HashSet<int>(), course.Key, courseList))
                {
                    return Array.Empty<int>();
                }
            }

            return courseList.ToArray();
        }

        public int Trap(int[] height) {
            int result = 0;
            Stack<int> stack = new Stack<int>();
            for(int i = 0; i < height.Length; ++i)
            {
                var current = height[i];
                while(stack.Any() && current > height[stack.Peek()])
                {
                    int top = stack.Pop();
                    if(!stack.Any())
                        break;
                    
                    int distance = i - stack.Peek() - 1;
                    int bound = Math.Min(current, height[stack.Peek()]) - height[top];

                    result += distance * bound;
                }
                stack.Push(i);
            }

            return result;
        }
        public bool HasCycle(ListNode head) {
            var slow = head;
            var fast = head.next;
            while(slow != fast)
            {
                if(fast == null || fast.next == null)
                    return false;
                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
        }
        public ListNode DetectCycle(ListNode head) {
            if(head == null) return null;
            var slow = head;
            var fast = head.next;
            while(fast != null && fast.next !=null)
            {
                
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast) break;
            }

            if(fast == null || fast.next == null)
                return null;

            slow = head;
            while(slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return fast;
        }

        public ListNode MergeKLists(ListNode[] lists) {
            int len = lists.Length;
            if(len == 0) return null;
            if(len == 1) return lists[0];
            ListNode head = new ListNode(-1);
            var node = head;
            while(true)
            {
                int minValue = int.MaxValue;
                int minIndex = -1;
                for(int i =0; i < len; ++i)
                {
                    if(lists[i] != null && lists[i].val < minValue)
                    {
                        minValue = lists[i].val;
                        minIndex = i;

                    }
                }

                if(minIndex == -1)
                {
                    break;
                }
                else
                {
                    node.next = lists[minIndex];
                    lists[minIndex] = lists[minIndex].next;
                    node = node.next;
                }
            }

            return head.next;
        }

        
        public int[] MaxSlidingWindow(int[] nums, int k) {
            
            //use a num map to memorize the num with the latest index.
            SortedDictionary<int, int> numMap = new SortedDictionary<int, int>();
            List<int> results = new List<int>();
            if(nums == null || nums.Length == 0) return results.ToArray();

            for(int i = 0; i < nums.Length; ++i)
            {
                int num = nums[i];
                if(i < k) // for the first sliding window, add to the map
                {
                    if(numMap.ContainsKey(num)) numMap[num] = i;
                    else numMap.Add(num, i);
                }
                else
                {
                    //results.Add(numMap.OrderByDescending(n =>n.Key).First().Key);
                    results.Add(numMap.Last().Key);

                    var numToRemove = nums[i - k];
                    var indexToRemove = numMap[numToRemove];
                    if(indexToRemove == i-k) numMap.Remove(numToRemove);

                    if(numMap.ContainsKey(num)) numMap[num] = i;
                    else numMap.Add(num, i);
                }
            }

            results.Add(numMap.OrderByDescending(n =>n.Key).First().Key);

            return results.ToArray();
        }

        public static IList<IList<int>> FourSum(int[] nums, int target){
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 3; i++){
                if (i > 0 && nums[i] == nums[i - 1]) 
                    continue;
                for (int j = i + 1; j < nums.Length - 2; j++){
                    if (j > i + 1 && nums[j] == nums[j - 1]) 
                        continue;
                    int sum = target - nums[i] - nums[j];
                    int left = j + 1;
                    int right = nums.Length - 1;
                    while (left < right){
                        if (nums[left] + nums[right] == sum){
                            List<int> lst = new List<int>();
                            lst.Add(nums[i]); lst.Add(nums[j]);
                            lst.Add(nums[left]); lst.Add(nums[right]);
                            result.Add(lst);
                            left++; right--;
                            while (left < nums.Length && nums[left] == nums[left - 1]) left++;
                            while (right > j + 1 && nums[right] == nums[right + 1]) right--;
                        }
                        else if (nums[left] + nums[right] < sum) left++;
                        else if (nums[left] + nums[right] > sum) right--;
                    }
                }
            }
            return result;
        }

        public int FourSumCount(int[] A, int[] B, int[] C, int[] D) {
            Dictionary<int, int> sumMap = new Dictionary<int, int>();
            for(int i = 0; i < A.Length; ++i)
                for(int j =0; j < B.Length; ++j)
                {
                    var sum = A[i] + B[j];
                    if(!sumMap.ContainsKey(sum))
                    {
                        sumMap.Add(sum, 1);
                    }
                    else
                    {
                        sumMap[sum] = sumMap[sum] + 1;
                    }
                }

            int result = 0;
            for(int i = 0; i < C.Length; ++i)
                for(int j =0; j < D.Length; ++j)
                {
                    var sum = -1*(C[i] + D[j]);
                    if(sumMap.ContainsKey(sum))
                    {
                        result = result + sumMap[sum];
                    }
                }
            
            return result;
        }
        public bool IsInterleave(string s1, string s2, string s3) {
            if(string.IsNullOrWhiteSpace(s1)) return s2 == s3;
            if(string.IsNullOrWhiteSpace(s2)) return s1 == s3;
            if(string.IsNullOrWhiteSpace(s3)) return false;

            int m = s1.Length;
            int n = s2.Length;
            if(s3.Length != m + n) return false;

            bool[,] dp = new bool[m+1, n+1];
            dp[0,0] = true;
            for(int i =1; i <= n; ++i)
            {
                dp[0,i] = dp[0, i-1] && s2[i-1] == s3[i-1];
            }
            for(int i =1; i <= m; ++i)
            {
                dp[i,0] = dp[i-1, 0] && s1[i-1] == s3[i-1];
            }

            for(int i = 1; i <= m; ++i)
                for(int j = 1; j <= n; ++j)
                {
                    dp[i,j] = dp[i, j-1] && s3[i + j -1] == s2[j-1] ||
                              dp[i-1, j] && s3[i + j -1] == s1[i-1];
                }
            return dp[m,n];
        }
        public IList<string> RestoreIpAddresses(string s) {
            IList<string> results = new List<string>();
            BacktrackingRestoreIpAddresses(s, 0, new List<int>(), results);
            return results;
        }

        public void BacktrackingRestoreIpAddresses(string s, int n, List<int> temp, IList<string> results)
        {
            if(n == 4) 
            {
                if(string.IsNullOrEmpty(s))
                {
                    results.Add(string.Join('.', temp));
                }
                return;
            }

            for(int k = 1; k < 4 && k <= s.Length; ++k)
            {
                var num = int.Parse(s.Substring(0, k));
                if(num >=0  && num <=255 && num.ToString().Length == k)
                {
                    temp.Add(num);
                    BacktrackingRestoreIpAddresses(s.Substring(k), n + 1, temp, results);
                    temp.RemoveAt(n);
                }
            }
        }

        public ListNode DeleteDuplicatesAllDulication(ListNode head) {
            ListNode dummy = new ListNode(int.MinValue);
            dummy.next = head;
            
            ListNode pre = dummy;
            while(pre.next != null)
            {
                ListNode cur = pre.next;

                //If the current has duplicaion, goto the last one
                while(cur.next != null && cur.next.val == cur.val)
                {
                    cur = cur.next;
                }

                //if the one is unique or same, then take it and continue
                if(cur == pre.next)
                {
                    pre = pre.next;
                }
                else // if this one has duplication, we need to reset the next 
                {
                    pre.next = cur.next;
                }
            }
            return dummy.next;
        }

        public int SearchBinarySearch(int[] nums, int target) {
            int left = 0;
            int right = nums.Length;
            while(left < right)
            {
                int middle = left + (right - left)/2;
                if(nums[middle] == target) return middle;
                if(nums[middle]< target) left = middle + 1;
                else right = middle;
            }
            
            return -1;
        }
        public IList<string> FullJustify(string[] words, int maxWidth) {
            IList<string> results = new List<string>();
            List<string> items = new List<string>();
            StringBuilder sb = new StringBuilder();
            int i =0;
            while(i< words.Length)
            {
                var size = words[i].Length;
                items.Add(words[i]);

                while(i + 1 < words.Length && size + 1 + words[i+1].Length <= maxWidth)
                {
                    i++;
                    size = size + 1+ words[i].Length;
                    items.Add(words[i]);
                }
                i++;
                
                if(i == words.Length)
                {
                    sb.Append(string.Join(' ', items));
                    for(int j =size; j < maxWidth; ++j)
                    {
                        sb.Append(' ');
                    }
                    results.Add(sb.ToString());
                    break;
                }

                var str = "";
                int left = 0;
                if(items.Count == 1)
                {
                     for(int j =0; j< maxWidth - size; ++j) str +=' ';
                }
                else
                {
                    int cnt = (maxWidth - size + items.Count - 1) / (items.Count - 1);
                    left = (maxWidth - size + items.Count - 1) % (items.Count - 1);
                    
                    for(int j =0; j<cnt; ++j) str +=' ';
                }

                for(int j =0; j < items.Count; ++j)
                {
                    if(j < items.Count -1)
                    {
                        sb.Append(items[j]);
                        sb.Append(str);

                        if(j < left)
                        {
                            sb.Append(' ');
                        }
                    }
                    else
                    {
                        sb.Append(items[j]);
                    }
                }
                results.Add(sb.ToString());
                sb = sb.Clear();
                items.Clear();
            }

            return results;
        }
        public string SimplifyPath(string path) {
            Stack<string> stack = new Stack<string>();

            var items = path.Split('/', StringSplitOptions.RemoveEmptyEntries).Where(n => n!= ".");

            foreach(var p in items)
            {
                if(p == "..")
                {
                    if(stack.Any())
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(p);
                }
            }

            return string.Join('/', stack.Reverse()).TrimEnd('/');
        }
        public int RemoveDuplicates(int[] nums) {
            if(nums == null || nums.Length == 0) return 0;
            int start = 0;
            int prev = nums[0];
            int cnt = 1;
            for(int i = 1; i < nums.Length; ++i)
            {
                if(nums[i] != prev)
                {
                    start ++;
                    nums[start] = nums[i];
                    prev = nums[start];
                    cnt = 1;
                }
                else if(cnt == 1)
                {
                    start ++;
                    nums[start] = nums[i];
                    cnt ++;
                }
            }
            
            return start +1;
        }
        public int TitleToNumber(string s) {
            int num = 0;
            for(int i = 0; i < s.Length; ++i)
            {
                num = num* 26 + s[i] - 'A' + 1;
            }

            return num;
        }
        public string LargestNumber(int[] nums) {
            if(nums == null || nums.Length == 0) return "0";
            var numList = nums.ToList();
            numList.Sort(new CustomDataComparer());

            var result = string.Join("", numList).TrimStart('0');
            return string.IsNullOrEmpty(result)? "0": result;
        }
        internal class CustomDataComparer: IComparer<int>
        {
            public int Compare(int x, int y)
                        {
                            var dx = x.ToString()+y.ToString();
                            var dy = y.ToString() + x.ToString();
                            return dx.CompareTo(dy);
                        }
        }

        public int CanCompleteCircuit(int[] gas, int[] cost) {
            int total = 0;
            int start = 0;
            int tank = 0;
            for(int i = 0; i < gas.Length; ++i)
            {
                tank = tank + gas[i] - cost[i];
                if(tank < 0)
                {
                    start = i + 1;
                    total = total + tank;
                    tank = 0;
                }
            }

            if(total + tank < 0) return -1;
            else return start;
        }

        public string MinRemoveToMakeValidStack(string s) {
            if(string.IsNullOrEmpty(s)) return string.Empty;

            Stack<char> charStack = new Stack<char>();
            Stack<int> posStack = new Stack<int>();

            HashSet<int> indexList = new HashSet<int>();
            for(int i =0; i < s.Length; ++i)
            {
                char c = s[i];
                if(char.IsLetter(c)) continue;
                if(c == '(')
                {
                    charStack.Push(c);
                    posStack.Push(i);
                }
                else if(!posStack.Any())
                {
                    indexList.Add(i);
                }
                else
                {
                    var lastChar = charStack.Peek();
                    var lastPos = posStack.Peek();
                    charStack.Pop();
                    posStack.Pop();
                    if(lastChar == ')')
                    {
                        indexList.Add(i);
                        indexList.Add(lastPos);
                    }
                }
            }

            while(posStack.Any())
            {
                indexList.Add(posStack.Pop());
            }
            string str = string.Empty;
            for(int i = 0; i < s.Length; ++i)
            {
                if(!indexList.Contains(i))
                {
                    str += s[i];
                }
            }

            return str;
        }

        public string FindValidString(string s, ref int idx)
        {
            string str = string.Empty;
            if(idx > s.Length) return str;

            if(char.IsLetter(s[idx]))
            {
                while(idx < s.Length && char.IsLetter(s[idx]))
                {
                    str += s[idx];
                    idx ++;
                }

                return str +FindValidString(s, ref idx);
            }
            else if(s[idx] == '(')
            {
                return "";
            }
            else //)
            {
                return "";
            }
        }
        public int MaxProduct2(int[] nums) {
            if(nums == null || nums.Length == 0) return 0;

            int max = nums[0];
            int min = nums[0];
            int maxP = nums[0];

            for(int i = 1; i < nums.Length; ++i)
            {
                var temp = max;
                max = Math.Max(nums[i], Math.Max(max* nums[i], min * nums[i]));
                min = Math.Min(nums[i], Math.Min(temp * nums[i], min * nums[i]));
                maxP = Math.Max(maxP, Math.Max(max, min));
            }

            return maxP;
        }

        public int MaxProduct(int[] nums) {
            if(nums == null || nums.Length == 0) return 0;

            int[] dp1 = new int[nums.Length]; // max in positive
            int[] dp2 = new int[nums.Length]; // max in negative
            
            dp1[0] = nums[0];
            dp2[0] = nums[0];
            int maxP = nums[0];

            for(int i = 1; i < nums.Length; ++i)
            {
                dp1[i] = Math.Max(nums[i], 
                                          Math.Max(dp1[i-1] * nums[i], dp2[i-1] * nums[i]));

                dp2[i] = Math.Min(nums[i], 
                                          Math.Min(dp1[i-1] * nums[i], dp2[i-1] * nums[i]));

                maxP = Math.Max(maxP, Math.Max(dp1[i], dp2[i]));
            }

            Console.WriteLine(string.Join(',', dp1));
            Console.WriteLine(string.Join(',', dp2));
            return maxP;
        }
        //Check if string s is subsequence of t
        public bool IsSubsequence(string s, string t) {
            if(t == null && s == null) return true;
            if(t == null) return false;
            if(s == null) return true;

            var lenT = t.Length;
            var lenS = s.Length;
            if(lenT < lenS)
            {
                return false;
            }

            int idxT =0;
            int idxS = 0;
            while(idxS < lenS && idxT < lenT)
            {
                if(s[idxS] == t[idxT])
                {
                    idxS++;
                }
                idxT ++;
            }

            return idxS == lenS;
        }
        
        public int MaxFreq(string s, int maxLetters, int minSize, int maxSize) {
            int[] charMap = new int[26];

            Array.Fill(charMap, 0);
            int freq = 0;
            int start = 0;
            int current = 0;
            Dictionary<string, int> freqDict = new Dictionary<string, int>();
            
            while(current <= s.Length)
            {
                var size = charMap.Sum();
                var letters = (from n in charMap where n> 0 select n).Count();

                if(letters <= maxLetters && size >= minSize && size <= maxSize)
                {
                    var str = s.Substring(start, current-start);
                    if(!freqDict.ContainsKey(str))
                    {
                        freqDict.Add(str, 0);
                    }
                    freqDict[str] = freqDict[str]  + 1;
                    freq = freqDict[str]> freq? freqDict[str]: freq;
                    Console.WriteLine(s.Substring(start, current-start));
                }
                else 
                {
                    while(letters> maxLetters || size > minSize)
                    {
                        charMap[s[start] - 'a'] = charMap[s[start] - 'a'] - 1;
                        start ++;

                        size = charMap.Sum();
                        letters = (from n in charMap where n> 0 select n).Count();
                    

                        if(letters <= maxLetters && size >= minSize && size <= maxSize)
                        {
                            var str = s.Substring(start, current-start);
                            if(!freqDict.ContainsKey(str))
                            {
                                freqDict.Add(str, 0);
                            }
                            freqDict[str] = freqDict[str]  + 1;
                            freq = freqDict[str]> freq? freqDict[str]: freq;
                            Console.WriteLine(s.Substring(start, current-start));
                        }
                    }
                }
                if(current < s.Length)
                    charMap[s[current] - 'a'] =  charMap[s[current] - 'a'] + 1;
                
                current ++;
            }
            return freq;
        }

        public string DecodeString2(string s) {
            int start = 0;

            return RecurseDecodeString(s, ref start);
        }

        public string RecurseDecodeString(string s, ref int index)
        {
            string result = string.Empty;

            while(index < s.Length && s[index] != ']')
            {
                if(char.IsLetter(s[index]))
                {
                    result += s[index];
                    index ++;
                }
                else {
                    int num = 0;
                    while(index < s.Length && char.IsNumber(s[index]))
                    {
                        num = num * 10 + s[index] - '0';
                        index ++;
                    }
                    Console.WriteLine(num);
                    ++ index; //[
                    string str = RecurseDecodeString(s, ref index);
                    ++ index; //]
                    while(num > 0)
                    {
                        result += str;
                        num --;
                    }
                }
            }

            return result;
        }

        public int FindKthLargest(int[] nums, int k) {
            QuickSort(nums, 0, nums.Length -1);

            //Console.WriteLine(string.Join('-', nums));
            return nums[nums.Length - k];
        }

        public void QuickSort(int[] nums, int start, int end)
        {
            int left = start;
            int right = end;
            if(left < right)
            {
                int middle = QuickSortPartion(nums, start, end);

                if(middle > 0)
                {
                    QuickSort(nums, start, middle);
                }

                if(middle < end -1)
                {
                    QuickSort(nums, middle + 1, end);
                }
            }
        }

        public int QuickSortPartion(int[] nums, int start, int end)
        {
            int pivot = nums[start];
            int left = start; 
            int right = end;
            while(true)
            {
                while(nums[left] < pivot)
                {
                    left ++;
                }
                while(nums[right] >= pivot && right >start)
                {
                    right --;
                }

                if (left < right)
                {
                    swap(nums, left, right);
                }
                else
                {
                    return right;
                }
            }
        }

        //Heap

        public int[] ProductExceptSelf(int[] nums) {
            int len = nums.Length;
            if(len <=1) return nums;
            int[] results = new int[len]; 

            int temp = 1;
            for(int i = 0; i < len; ++i)
            {
                results[i] = temp;
                temp = temp * nums[i];
            }
            temp = 1;
            for(int i = len - 1; i >= 0; --i)
            {
                results[i] = results[i] * temp;
                temp = temp * nums[i];
            }

            return results;
        }

        public int MaximalSquare(char[][] matrix) {
            int rows = matrix.Length;
            if(rows == 0) return 0;
            int columns = matrix[0].Length;
            if(columns ==0) return 0;

            int[,] dp = new int[rows, columns];
            int[,] dpRow = new int[rows, columns];
            int[,] dpCol = new int[rows, columns];
            int maxSquare = 0;
            for(int i = 0; i < rows; ++i)
            {
                for(int j =0; j <columns; ++j)
                {
                    dp[i,j] = matrix[i][j]== '1'? 1: 0;
                    if(dp[i, j] > maxSquare) maxSquare = 1;
                    dpRow[i,j] = matrix[i][j]== '1'? (j== 0? 1: dpRow[i, j-1] +1): 0; //Row direction
                    dpCol[i,j] = matrix[i][j]== '1'? (i== 0? 1: dpCol[i-1, j] +1): 0; //Column direction
                }
            }

            
            for(int i = 1; i < rows; ++i)
            {
                for(int j =1; j <columns; ++j)
                {
                    if(matrix[i][j] == '1')
                    {
                        dp[i,j] = Math.Min(dp[i-1,j-1], Math.Min(dpRow[i, j-1], dpCol[i-1, j])) + 1;

                        if(dp[i, j] > maxSquare) maxSquare = dp[i, j];
                    }
                }
            }

            return maxSquare * maxSquare;
        }

        public bool SearchMatrix(int[,] matrix, int target) {
            int rows = matrix.GetLength(0);
            if(rows == 0) return false;
            int columns = matrix.GetLength(1);
            if(columns ==0) return false;

            return BinarySearchMatrix(matrix, target, 0, columns -1 , rows, columns);
        }
        public bool BinarySearchMatrix(int[,] matrix, int target, int i, int j, int rows, int columns)
        {
            if(i <0 || i >= rows || j < 0 || j >= columns)
            {
                return false;
            }

            if(matrix[i,j] == target)
            {
                return true;
            }
            else if(matrix[i,j] > target)
            {
                return BinarySearchMatrix(matrix, target, i, j - 1, rows, columns);
            }
            else
            {
                return BinarySearchMatrix(matrix, target, i + 1, j, rows, columns);
            }
        }

        public bool SearchMatrix(int[][] matrix, int target) {
            int rows = matrix.Length;
            if(rows == 0) return false;
            int columns = matrix[0].Length;
            if(columns ==0) return false;

            return BinarySearchMatrix(matrix, target, 0, columns -1 , rows, columns);
        }

        public bool BinarySearchMatrix(int[][] matrix, int target, int i, int j, int rows, int columns)
        {
            if(i <0 || i >= rows || j < 0 || j >= columns)
            {
                return false;
            }

            if(matrix[i][j] == target)
            {
                return true;
            }
            else if(matrix[i][j] > target)
            {
                return BinarySearchMatrix(matrix, target, i, j - 1, rows, columns);
            }
            else
            {
                return BinarySearchMatrix(matrix, target, i + 1, j, rows, columns);
            }
        }

        public string DecodeString(string s) {
            if(string.IsNullOrEmpty(s)) return s;

            Stack<int> numbers = new Stack<int>();
            Stack<string> strings = new Stack<string>();
            string result = string.Empty;

            int index =0;
            while(index < s.Length)
            {
                if(char.IsNumber(s[index]))
                {
                    int num = s[index] - '0';
                    while(index + 1 < s.Length && char.IsNumber(s[index +1]))
                    {
                        index ++;
                        num = num * 10 + s[index] - '0';
                    }
                    numbers.Push(num);
                }
                else if('[' == s[index])
                {
                    strings.Push(result);
                    result = string.Empty;
                }
                else if(']' == s[index])
                {
                    int n = numbers.Pop();
                    String temp = strings.Pop();
                    for(int i=0; i<n; i++){
                        temp += result;
                    }
                    result = temp;
                }
                else{
                    result += s[index];
                }
                index ++;
            }

            return result;
        }

        
        public double New21Game(int N, int K, int W) {
            int maxPoints = K - 1 + W;
            double[] dp = new double[maxPoints + 1];

            for (int lastPoints = K; lastPoints <= maxPoints; lastPoints++)
            {
                dp[lastPoints] = (lastPoints <= N ? 1 : 0);
            }

            double sum = 0;
            for (int nextDraw = 1; nextDraw <= W; nextDraw++)
            {
                sum += (dp[K - 1 + nextDraw] / W);
            }

            for (int points = K - 1; points >= 0; points--)
            {
                dp[points] += sum;
                sum -= (dp[points + W] / W);
                if (points != 0)
                {
                    sum += (dp[points] / W);
                }
            }

            return dp[0];
        }

        public int MaxProfitMultiTimes(int[] prices) {
            int n = prices.Length;
            if(n < 2) return 0;

            int[] buys = new int[n];
            int[] sells = new int[n];
            buys[0] = 0 - prices[0];
            sells[0] = 0;

            for(int i =1; i< n; ++i)
            {
                int price = prices[i];
                buys[i] = Math.Max(buys[i-1], sells[i-1] - price);
                sells[i] = Math.Max(sells[i-1], buys[i-1] + price);
            }

            return Math.Max(buys[n-1], sells[n-1]);
        }

        public int MaxProfitWithCoolDown(int[] prices) {
            int n = prices.Length;
            if(n < 2) return 0;
            int[] buys = new int[n ];
            int[] sells = new int[n];
            int[] nas = new int[n];
            buys[0] = 0 - prices[0];
            sells[0] = int.MinValue; //
            nas[0] = 0; // at begining, it's 0

            for(int i =1; i <n; ++i)
            {
                var price = prices[i];
                // Buy stock yesterday or today (but yesterday should be cooling down).
                buys[i]  = Math.Max(nas[i-1] - price, buys[i-1]);

                // Sell stock yesterday or today 
                sells[i] = Math.Max(buys[i-1] + price, sells[i-1]);
                
                // yesterday is nas, yesterday is sell, yesterday is buy
                nas[i] = Math.Max(nas[i-1], Math.Max( sells[i-1], buys[i-1]));
            }

            return Math.Max(nas[n -1 ], Math.Max( sells[n - 1], buys[n - 1]));
        }

        public int KthSmallest(int[][] matrix, int k) {
            int n = matrix.Length;
            int[] columnMap = new int[n];
            Array.Fill(columnMap, 0);
            List<int> nums = new List<int>();
            for(int i =0; i < k; ++i)
            {
                int minVal = int.MaxValue;
                int minRow = -1;
                for(int j =0; j < n; ++j)
                {
                    if(columnMap[j] < n && matrix[j][columnMap[j]] < minVal)
                    {
                        minVal = matrix[j][columnMap[j]];
                        minRow = j;
                    }
                }
                columnMap[minRow] =  columnMap[minRow] + 1;
                nums.Add(minVal);
            }

            return nums.Last();
        }

        public int LeastInterval(char[] tasks, int n) {
            int[] map = new int[26];
            foreach (char c in tasks)
                map[c - 'A']++;
            Array.Sort(map);
            int time = 0;
            while (map[25] > 0) {
                int i = 0;
                while (i <= n) {
                    if (map[25] == 0)
                        break;
                    if (i < 26 && map[25 - i] > 0)
                        map[25 - i]--;
                    time++;
                    i++;
                }
                Array.Sort(map);
            }
            return time;
        }
        public int[] DailyTemperatures(int[] T) {
            List<List<int>> temperatureDates = new List<List<int>>();
            for(int i = 30; i <=100; ++i)
            {
                temperatureDates.Add(new List<int>());
            }

            int[] results = new int[T.Length];
            Array.Fill(results, 0);
            for(int i =0; i < T.Length; ++i)
            {
                var temp = T[i];
                for(int t = 30; t< temp; ++t)
                {
                    var dates = temperatureDates[t-30];
                    var newDates = new List<int>();
                    var diff = temp - t;
                    foreach(var dt in dates)
                    {
                        results[dt] = i - dt;
                    }
                    temperatureDates[t-30] = new List<int>();
                }

                var tempDates = temperatureDates[temp-30];
                tempDates.Add(i);
                 temperatureDates[temp-30] = tempDates;
            }

            return results;
        }

        public int MaxDepth(TreeNode root) {
            return DFSMaxDepth(root);
        }

        public int DFSMaxDepth(TreeNode node)
        {
            if(node == null) return 0;
            else return Math.Max(DFSMaxDepth(node.left), DFSMaxDepth(node.right)) + 1; 
        }

        public Node CopyRandomList(Node head) {
            Node copiedHead = new Node(-1);
            Node node = head;
            Node copiedNode = copiedHead;
            Dictionary<Node, Node> randomMapping = new Dictionary<Node, Node>();
            while(node != null)
            {
                var newNode = new Node(node.val);
                newNode.next = null;
                copiedNode.next = newNode;

                randomMapping.Add(node, newNode);

                copiedNode = copiedNode.next;
                node = node.next;
            }

            copiedNode = copiedHead.next;
            node = head;
            while(node != null)
            {
                if(node.random == null)
                {
                    copiedNode.random = null;
                }
                else
                {
                    copiedNode.random = randomMapping[node.random];
                }
                
                copiedNode = copiedNode.next;
                node = node.next;
            }

            return copiedHead.next;
        }
        public IList<IList<int>> PathSum(TreeNode root, int sum) {
            IList<IList<int>> results = new List<IList<int>>();
            IList<int> values = new List<int>();
            DFSPathSum(root, sum, 0, values, results);

            return results;
        }

        public void DFSPathSum(TreeNode node, int target,  int sum, IList<int> values, IList<IList<int>> results)
        {
            if(node == null)
            {
                return;
            }

            if(node.left == null && node.right == null)
            {
                if(sum + node.val == target)
                {
                    var res = values.Select(n=>n).ToList();
                    res.Add(node.val);
                    results.Add(res);
                }
                return;
            }

            var newValues = new List<int>(values);
            newValues.Add(node.val);
            DFSPathSum(node.left, target, sum + node.val, values, results);
            DFSPathSum(node.right, target, sum + node.val, values, results);
        }

        public bool HasPathSum(TreeNode root, int sum) {
            if(root == null) return false;
            return DFSHasPathSum(root, sum, 0);
        }

        public bool DFSHasPathSum(TreeNode node, int sum, int current)
        {
            if(node == null)
            {
                return false;
            }

            if(node.left == null && node.right == null)
            {
                return sum == current + node.val;
            }
            return DFSHasPathSum(node.left, sum, current + node.val) || DFSHasPathSum(node.right, sum, current + node.val);
        }
        public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
            int maxLength = wordList.Count;
            int targetLength = 0;
            HashSet<string> currents = new HashSet<string>();
            currents.Add(beginWord);
            
            while(targetLength < maxLength)
            {
                HashSet<string> nexts = new HashSet<string>();
                targetLength ++;
                if(targetLength > beginWord.Length * 2)
                    return 0;
                foreach(var current in currents)
                {
                    foreach(var word in wordList)
                    {
                        if(IsLadderWords(current, word))
                        {
                            if(word == endWord)
                                return targetLength + 1;
                            else
                                nexts.Add(word);
                        }
                    }
                }
                currents = nexts;
            }
            return 0;
        }

        public bool IsLadderWords(string word1, string word2)
        {
            int cnt = 0;
            for(int i =0; i < word1.Length; ++i)
            {
                if(word1[i] != word2[i])
                {
                    if(cnt > 0 )
                        return false;
                    else 
                        cnt ++;
                }
            }

            return cnt == 1;
        }
        public int[] SumZero(int n) {
            int[] results = new int[n];
            for (int i = 0; i < n / 2; i++) {   
                results[i] = n - i;
                results[n - i - 1] = - (n - i);
            }
            return results;
        }

        public string FreqAlphabets(string s) {
            
            if(string.IsNullOrEmpty(s)) return s;
            List<char> results = new List<char>();
            int i = s.Length -1;
            while(i>=0)
            {
                var num = 0;
                if(s[i] == '#')
                {
                    num = 10*(s[i-2] - '0') + (s[i-1] - '0');
                    i = i - 3;
                }
                else
                {
                    num = s[i] - '0';
                    i --;
                }
                results.Add(Convert.ToChar('a'+num - 1));
            }

            results.Reverse();
            return string.Join("", results);
        }

        public IList<IList<int>> LevelOrder(TreeNode root) {
            IList<IList<int>> results = new List<IList<int>>();
            if(root == null) return results;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while(queue.Any())
            {
                var size = queue.Count();
                IList<int> currents = new List<int>();
                for(int i =0; i < size; ++i)
                {
                    var node = queue.Dequeue();
                    currents.Add(node.val);
                    if(node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    
                    if(node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                results.Add(currents);
            }
            return results;
        }
        public int NumIslands(char[][] grid) {
            //Count island 
            // Given a 2d grid map of '1's (land) and '0's (water),
            // count the number of islands. 
            // An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.
            // You may assume all four edges of the grid are all surrounded by water.
            int rows = grid.Length;
            if(rows == 0) return 0;
            int columns = grid[0].Length;
            if(columns == 0) return 0;

            int[,] islandWithIds = new int[rows, columns];

            
            int islandCnt = 0;
            for(int i = 0; i < rows; ++i)
            {
                for(int j =0; j <columns; ++j)
                {
                    if(grid[i][j] != '1')
                    {
                        continue;
                    }

                    grid[i][j] = '2';
                    Queue<int[]> queue = new Queue<int[]>();
                    queue.Enqueue(new int[2]{i, j});
                    while(queue.Count > 0)
                    {
                        int[] current = queue.Dequeue();
                        // Going down
                        if (current[0] < rows - 1 && grid[current[0] + 1][current[1]] == '1')
                        {
                            grid[current[0] + 1][current[1]] = '2';
                            queue.Enqueue(new int[2] { current[0] + 1, current[1] });
                        }
                        // Going up
                        if (current[0] > 0 && grid[current[0] - 1][current[1]] == '1')
                        {
                            grid[current[0] - 1][current[1]] = '2';
                            queue.Enqueue(new int[2] { current[0] - 1, current[1] });
                        }
                        if (current[1] < columns - 1 && grid[current[0]][current[1] + 1] == '1')
                        {
                            grid[current[0]][current[1] + 1] = '2';
                            queue.Enqueue(new int[2] { current[0], current[1] + 1 });
                        }
                        if (current[1] > 0 && grid[current[0]][current[1] - 1] == '1')
                        {
                            grid[current[0]][current[1] - 1] = '2';
                            queue.Enqueue(new int[2] { current[0], current[1] - 1 });
                        }
                    }
                    islandCnt ++;
                }
            }

            return islandCnt;
        }

        public int FindDuplicate(int[] nums) {
            int n = nums.Length;
            for (int i = 0; i < n; i++) {
                while (nums[i] != i + 1) {
                    if (nums[nums[i] - 1] != nums[i]) swap(nums, nums[i] - 1, i);
                    else return nums[i];
                }
            }
            return -1;
        }
        public int FindDuplicate2(int[] nums) {
            Array.Sort(nums); 
            for(int i =0; i< nums.Length; ++i)
            {
                if(i > 0 && nums[i] == nums[i-1])
                    return nums[i];
            }

            return -1;
        }

        public IList<int> TopKFrequent(int[] nums, int k) {
            Dictionary<int, int> numFreq = new Dictionary<int, int>();
            for(int i =0; i < nums.Length; ++i)
            {
                if(!numFreq.ContainsKey(nums[i]))
                {
                    numFreq.Add(nums[i], 0);
                }
                numFreq[nums[i]] = numFreq[nums[i]] + 1;
            }

            var sortedNumFreq = numFreq.OrderByDescending(n=>n.Value).ToList();

            List<int> results = new List<int>();

            for(int i =0; i < k && i < sortedNumFreq.Count(); ++i)
            {
                results.Add(sortedNumFreq[i].Key);
            }

            return results;
        }

        public string DayOfTheWeek(int day, int month, int year) {
            DateTime dt = new DateTime(year,month, day);
            return dt.DayOfWeek.ToString();
        }

        public void SetZeroes(int[][] matrix) {
            int rows = matrix.Length;
            if(rows == 0) return;
            int columns = matrix[0].Length;

            
            for(int i =0; i < rows; ++i)
            {
                for(int j =0; j <columns; ++j)
                {
                    if(matrix[i][j] == 0)
                    {
                        for(int k =0; k < rows; ++k)
                        {
                            if(matrix[k][j] != 0)
                                matrix[k][j] = -1000000;
                        }
                        for(int k =0; k < columns; ++k)
                        {
                            if(matrix[i][k] != 0)
                                matrix[i][k] = -1000000;
                        }
                    }
                }
            }
            
            for(int i =0; i < rows; ++i)
            {
                for(int j =0; j <columns; ++j)
                {
                    if(matrix[i][j] == -1000000 )
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
            
        }

        public int Search(int[] nums, int target) {
            // Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
            // Solution 1: Sort and find target O(nlog(n)) + O(n)
            // Requirement is log(n)
            return BinarySearch(nums, 0, nums.Length -1, target);
        }
        
        public int BinarySearch(int[] nums, int start, int end, int target)
        {
            if(start > end)
                return -1;

            int middle = start + (end - start)/2;

            if(nums[middle] == target)
                return middle;

            bool hasReverse = nums[start] > nums[end];
            if(nums[middle] < target)
            {
                var res = BinarySearch(nums, middle + 1, end, target);
                if(hasReverse && res == -1)
                {
                    return BinarySearch(nums, start, middle - 1, target);
                }
                else
                    return res;
            }
            else
            {
                var res = BinarySearch(nums, start, middle - 1, target);
                if(hasReverse && res == -1)
                {
                    return BinarySearch(nums, middle + 1, end, target);
                }
                else
                    return res;
            }
        }

         public bool CheckSubarraySum(int[] nums, int k) {
            int len = nums.Length;
            int[,] dp  = new int[len + 1, len + 1];

            for(int i =0; i <= len; ++ i)
            {
                dp[0, i] = 0;  dp[i, 0] = 0; 
                if(i > 0)
                {
                    dp[1, i] = dp[1, i-1] +nums [i -1];
                    dp[i, i] = nums[i -1];
                }
            }

            for(int i = 1; i <= len; i++)
            {
                for(int j = i +1; j <= len; j++)
                {
                    dp[i, j] = nums[j - 1] + dp[i, j-1];

                    if(k ==0 && dp[i, j] == 0)
                        return true;
                    else if(k != 0 && dp[i, j] % k == 0 )
                        return true;
                }
            } 

            return false;
        }

        public int NthUglyNumber(int n) {
            int i2 =0;
            int i3 = 0;
            int i5 = 0;

            List<int> results = new List<int>();
            results.Add(1);

            while(results.Count < n)
            {
                int n2 = results[i2] *2;
                int n3 = results[i3] *3;
                int n5 = results[i5] *5;

                int s = Math.Min(n2, Math.Min(n3, n5));
                if(s == n2) i2 ++;
                if(s == n3) i3 ++;
                if(s == n5) i5 ++;
                results.Add(s);
            }

            return results.Last();
        }

        public double MyPow(double x, int n) {
            if(n == 0) return 1;

            double half = MyPow(x, n/2);
            if(n % 2 == 0) return half * half;
            if(n > 0) return half*half*x;
            else return half*half/x;
        }

        public string CountAndSay(int n) {
            string str = "1";
            for(int i =1; i <n; ++i)
            {
                StringBuilder sb = new StringBuilder();
                char c = str[0];
                int cnt = 1;
                for(int k =1; k < str.Length ; ++ k)
                {
                    if(str[k] != c && c != ' ')
                    {
                        sb.Append(cnt.ToString());
                        sb.Append(c);
                        c = str[k];
                        cnt = 1;
                    }
                    else if(str[k] == c)
                    {
                        cnt ++;
                    }
                }
                if(cnt > 0)
                {
                    sb.Append(cnt.ToString());
                    sb.Append(c);
                }
                str = sb.ToString();
            }

            return str;
        }

        public void SortColors(int[] nums) {
            int i =0;
            int start = 0;
            int end = nums.Length -1;
            while(i <= end)
            {
                if(nums[i] == 0)
                {
                    nums[i] = nums[start];
                    nums[start] =0;
                    start ++;
                    i ++;
                }
                else if(nums[i] == 2)
                {
                    nums[i] = nums[end];
                    nums[end] = 2;
                    end --;
                }
                else
                {
                    i ++;
                }
            }
        }

        public bool IsMatch(string s, string p) {
            int m = s.Length;
            int n = p.Length;
            int i =0;
            int j =0;
            int iStar = -1;
            int jStar = -1;
            while(i < m)
            {
                if(j<n && (s[i] == p[j] || p[j] == '?'))
                {
                    ++i; ++j;
                }
                else if (j < n && p[j] == '*')
                {
                    iStar = i;
                    jStar = j;
                    j++;
                }
                else if(iStar >=0)
                {
                    i = ++iStar;
                    j = jStar +1;
                }
                else 
                {
                    return false;
                }
            }
            
            while(j < n && p[j] == '*')
            {
                ++j;
            }

            return j == n;
        }

        public int CountPrimes(int n) {
            if(n < 2) return 0;
            bool[] nonPrime = new bool[n];
            for(int i = 2; i <= Math.Sqrt(n); i++)
                if(!nonPrime[i-1])
                    for(int j = i * i; j <= n; j += i)
                        nonPrime[j-1] = true;
            int result = 0;
            for(int k = 2; k < n; k++)
                result += nonPrime[k-1] ? 0 : 1;
            return result;
        }

        public bool IncreasingTriplet(int[] nums) {
            int min1 = int.MaxValue; 
            int min2 = int.MaxValue;
            int min3 = int.MaxValue;
            for(int i =0; i < nums.Length; ++i)
            {
                if(nums[i] < min1) 
                    min1 = nums[i];
                else if (nums[i] > min1 && nums[i] < min2)
                    min2 = nums[i];
                else if (nums[i] > min2 && nums[i] < min3)
                    min3 = nums[i];
            }

            return min1 != int.MaxValue && min2 != int.MaxValue && min3 != int.MaxValue
                    && min1 < min2 && min2 < min3;
        }

        public int LongestSubstring(string s, int k) {
            int[] charAndCount = new int[256];
            foreach (char c in s) {
                charAndCount[c]++;
            }

            for (int i = 0; i < s.Length; i++) {
                if (charAndCount[s[i]] > 0 && charAndCount[s[i]] < k) {
                    // this char is wrong, either left or right has longestSubstring
                    int left = LongestSubstring(s.Substring(0, i), k);
                    int right = LongestSubstring(s.Substring(i + 1), k);
                    return Math.Max(left, right);
                }
            }

            return s.Length;
        }
        public int LongestSubstringV1(string s, int k) {
            int[] charCount = new int[26];
        
            for(int i =0; i < s.Length; ++i)
            {
                charCount[s[i] - 'a'] = charCount[s[i] - 'a'] + 1;
            }

            int start = -1;
            int end = -1;
            Dictionary<char, int> charsInRange = new Dictionary<char, int>();
            int maxLength = 0;
            
            
            for(int i =0; i < s.Length; ++i)
            {
                if(charCount[s[i] - 'a'] >=  k ) //invalid char
                {
                    if(start == -1)
                    {
                        start = i;
                    }
                    end = i;

                    if(!charsInRange.ContainsKey(s[i]))
                    {
                        charsInRange.Add(s[i], 0);
                    }
                    charsInRange[s[i]] = charsInRange[s[i]] + 1;
                }

                if(charCount[s[i] - 'a'] < k || i == s.Length - 1) //invalid char
                {
                    bool isValidSubstring = charsInRange.Count > 0;
                    foreach(var item in charsInRange)
                    {
                        if(item.Value < k)
                        {
                            isValidSubstring = false;
                            break;
                        }
                    }

                    if(isValidSubstring &&  end - start + 1 > maxLength)
                    {
                        maxLength = end - start + 1;
                    }

                    start = -1;
                    end = -1;
                    charsInRange = new Dictionary<char, int>();
                }
            }

            return maxLength;
        }
        public bool WordBreak(string s, IList<string> wordDict) {
            // This should be a DP problem
            int len = s.Length;
            int size = wordDict.Count;
            if(len == 0) return true;
            if(size ==0) return false;
            bool[] dp = new bool[len + 1];
            dp[0] = true;

            for(int i = 1; i <= len; ++i)
            {
                foreach( var word in wordDict)
                {
                    var lastC = word.Last();
                    var wordLen = word.Length;
                    if(lastC == s[i -1] 
                       && wordLen <= i 
                       && s.Substring(i - wordLen, wordLen) == word 
                       && dp[i - wordLen])
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[len];
        }

        public bool DivisorGame(int N) {
            int x = 1;
            bool alice = true;
            while(N > 0)
            {
                while(x < N && N % x ==0)
                {
                    x ++;
                }

                N = N -x;
                alice = !alice;
            }

            return alice;
        }

        public IList<string> ReadBinaryWatch(int num) {
            HashSet<string> results = new HashSet<string>();
            if(num < 0 || num > 10) return results.ToList();
            if(num == 0)
            {
                results.Add("0:00");
                return results.ToList();
            }

            int[] digits = new int[] {-1, -2, -4, -8, 1, 2, 4, 8, 16, 32};
            List<int> selected = new List<int>();
            
            BackTrackReadBinaryWatch(0, 10, num, selected, digits, results);

            return results.ToList();
        }

        public void BackTrackReadBinaryWatch(int current, int size, int num, List<int> selected,  int[] digits, HashSet<string> results)
        {
            if(selected.Count == num)
            {
                var hour = 0;
                var mins = 0;
                foreach(var s in selected)
                {
                    if(s < 0)
                    {
                        hour -= s;
                    }
                    else
                    {
                        mins += s;
                    }
                }
                if(hour <= 11 && mins <= 59)
                    results.Add(string.Format("{0}:{1}",
                                          hour.ToString(), 
                                          mins< 10 ? "0" + mins.ToString() : mins.ToString()));
                
                return;
            }

            for(int i =  current; i < size;  i++)
            {
                selected.Add(digits[i]);
                BackTrackReadBinaryWatch(i + 1, size, num, selected, digits, results);
                selected.Remove(digits[i]);
            }
        }

        public int MinCostClimbingStairs(int[] cost) {
            if(cost == null || cost.Length ==0) return 0;
            int n = cost.Length;

            int[] dp = new int[n + 1];
            dp[0] = cost[0]; // Start from stair 0
            dp[1] = cost[1]; // Start from stair 1

            if(n <= 2)
                return cost[0];

            for(int i = 2; i < n; ++i)
            {
                //Min cost from last 2 or last 1 stairs
                dp[i] = Math.Min(dp[i - 1] + cost[i], dp[i -2] + cost[i]);
            }
            
            return Math.Min(dp[n-1], dp[n -2]); // When check the last stair, we can check last one or two stairs
        }

        public int ClimbStairs(int n) {
            if(n <=1) return n;

            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;

            for(int i = 2; i <= n; ++i)
            {
                dp[i] = dp[i - 1] + dp[i -2]; 
            }
            
            return dp[n];
        }

        public int[][] Merge(int[][] intervals) {
            if(intervals == null) return null;
            int rows = intervals.Length;
            if(rows == 0) return intervals;
            int columns = intervals[0].Length;
            if(columns == 0) return intervals;

            Array.Sort(intervals, (i1, i2) => i1[0].CompareTo(i2[0]));
            
            var start = intervals[0][0];
            var end = intervals[0][1];
            List<int[]> results = new List<int[]>();

            for(int i =1; i < rows; ++i)
            {
                if(intervals[i][0] > end)
                {
                    results.Add(new int[]{start, end});

                    start = intervals[i][0];
                    end = intervals[i][1];
                }
                else
                {
                    end = Math.Max(end, intervals[i][1]);
                }
            }
            results.Add(new int[]{start, end});

            return results.ToArray();
        }
        

        public int FindTargetSumWays(int[] nums, int S) {
            int len = nums.Length;
            if(len ==0) return 0;
            if(S>1000) return 0;

            int[] dp = new int[2001];
            dp[1000 + nums[0]]  += 1;
            dp[1000 - nums[0]]  += 1;
            for(int i =1; i < len; ++i)
            {
                var num = nums[i];
                int[] next = new int[2001];
                for(int sum =-1000; sum <=1000; ++sum)
                {
                    if(dp[sum + 1000] > 0)
                    {
                        var sum1 = sum + num;
                        var sum2 = sum - num;
                        
                        next[sum1 + 1000] += dp[sum + 1000];
                        next[sum2 + 1000] += dp[sum + 1000]; 
                    }
                }  
                dp = next;              
            }
            return dp[S+1000];
        }

        public int MincostTickets(int[] days, int[] costs) {
            int[] memo = new int[366];
            Array.Fill(memo, int.MaxValue);
            HashSet<int> daysets = new HashSet<int>();
            foreach(var d in days)
            {
                daysets.Add(d);
            }
            return DPMincostTickets(1, memo, costs, daysets );
        }
        public int DPMincostTickets(int i, int[] memo, int[] costs, HashSet<int> dayset) {
            if (i > 365)
            return 0;
            if (memo[i] != int.MaxValue)
                return memo[i];

            int ans;
            if (dayset.Contains(i))
            {
                ans = Math.Min(DPMincostTickets(i+1, memo, costs, dayset) + costs[0],
                               Math.Min(DPMincostTickets(i+7, memo, costs, dayset) + costs[1],
                                        DPMincostTickets(i+30, memo, costs, dayset) + costs[2]));
            } 
            else 
            {
                ans = DPMincostTickets(i+1, memo, costs, dayset);
            }

            memo[i] = ans;
            return ans;
        }

        public int Rob(int[] nums) {
            var len = nums.Length;
            if(len ==0)
                return 0;
            int[] dp1 = new int[len + 1]; // Yes, rob this one.
            int[] dp2 = new int[len + 1]; // No, skip this one.

            dp1[0] = 0;
            dp2[0] = 0;
            for(int i =1; i <= len; i ++)
            {
                dp1[i] = nums[i - 1] + dp2[i - 1];

                dp2[i] = Math.Max(dp2[i-1], dp1[i-1]);
            }

            return Math.Max(dp2[len], dp1[len]);
        }

        public int MinFallingPathSum(int[][] A) {
            if(A == null ) return 0;
            int rows = A.Length;
            if(rows ==0) return 0;
            int columns = A[0].Length;
            if(columns == 0) return 0;

            int[,] dp = new int[rows, columns];
            for(int i =0; i < columns; ++i)
            {
                dp[0, i] =  A[0][i -1];
            }
            
            for(int i = 1; i < rows; ++i)
            {
                for(int j =0; j < columns; ++j)
                {
                    if(j ==0)
                    {
                        dp[i, j] = Math.Min(dp[i-1, j], dp[i-1, j+1]) + A[i][j];
                    }
                    else if (j == columns -1)
                    {
                        dp[i, j] = Math.Min(dp[i-1, j], dp[i-1, j-1]) + A[i][j];
                    }
                    else
                    {
                        dp[i, j] = Math.Min(dp[i-1, j], Math.Min(dp[i-1, j-1], dp[i-1, j + 1])) + A[i][j];
                    }
                }
            }

            int min = int.MaxValue;
            for(int i =0; i < columns; ++i)
            {
                if(dp[rows-1, i] < min)
                    min = dp[rows-1, i];
            }
            return min;
        }
        public int CoinChange(int[] coins, int amount) {
            int[] dp = new int[amount +1];
            Array.Fill(dp, int.MaxValue);
            dp[0] = 0;

            for(int i = 0; i < coins.Length; ++i)
            {
                var coin = coins[i];
                for(int j = 1; j <= amount; ++j)
                {
                    if (j-coins[i] >= 0 && dp[j-coin] != Int32.MaxValue)
                        dp[j] = Math.Min(dp[j-coin]+1, dp[j]);
                }
            }

            return dp[amount] == int.MaxValue ? -1 : dp[amount];
        }

        //K egg, N Floors
        public int SuperEggDropV2(int K, int N) {
            if(N==1 || N ==0) return N;
            if(K ==1) return N;

            // using m moves and e eggs, how many floors can we check?
            int[,] opt= new int[N+1, K+1];
            for(int n =1; n <= N; n++)
            {
                opt[n, 0] = 0;
            }

            for(int k =1; k <=K; ++k)
            {
                opt[0, k] = 0;
            }

            for (int m = 1; m <= N; ++m) {
                for (int e = 1; e <= K; ++e) {
                    opt[m,e] = opt[m-1, e-1] + opt[m-1, e] + 1;
                    // have we checked all the floors?
                    if (opt[m, e] >= N) {
                        return m;
                    }
                }
            }
            return -1; // we'll never get here
        }

        //K egg, N Floors
        public int SuperEggDrop(int K, int N) {
            if(N==1 || N ==0) return N;
            if(K ==1) return N;

            int min = int.MaxValue;
            for(int n =1; n <= N; ++n)
            {
                var cnt = Math.Max(SuperEggDrop(K-1, n-1),
                                SuperEggDrop(K, N-n));

                if(cnt < min)
                    min = cnt;
            }

            return min;
        }

        //K egg, N Floor
        public int DPSuperEggDrop(int K, int N) {
            int[,] dp= new int[K+1, N+1];

            for(int n =1; n <= N; n++)
            {
                dp[0, n] = 0;
                dp[1, n] = n;
            }

            for(int k =1; k <=K; ++k)
            {
                dp[k, 0] = 0;
                dp[k, 1] = 1;
            }

            for(int k =2; k <= K; ++k)
            {
                for(int n=2; n<= N; ++n)
                {
                    dp[k, n] = int.MaxValue;
                    for (int x = 1; x <= n; x++) 
                    { 
                        int res = 1 + Math.Max(dp[k-1,x-1], 
                                    dp[k,n-x]); 
                        if (res < dp[k,n]) 
                            dp[k,n] = res; 
                    } 
                }
            }

            return dp[K,N];
        }

        

        public int SubarraySum(int[] nums, int k) {
            int count = 0;
            for (int start = 0; start < nums.Length; start++) {
                int sum=0;
                for (int end = start; end < nums.Length; end++) {
                    sum+=nums[end];
                    if (sum == k)
                        count++;
                }
            }
            return count;
        }

        public bool CanPartition(int[] nums) {
            HashSet<int> subDiffs = new HashSet<int>();
            subDiffs.Add(0);

            foreach(int num in nums)
            {
                var newDiffs = new HashSet<int>();
                foreach(var diff in subDiffs)
                {
                    newDiffs.Add(diff+ num);
                    newDiffs.Add(diff- num);
                }

                subDiffs = newDiffs;
            }

            return subDiffs.Contains(0);
        }

        public int NumDecodings(string s) {
            int len = s.Length;
            
            if(len <1) return 0;
            if(s[0] == '0') return 0;

            int[] decodingArrary = new int[len + 1];
            decodingArrary[0] = 1;
            decodingArrary[1] = 1;
            int lastNum = 0;
            for(int i =2; i <= len; ++i)
            {
                var uniNum = s[i - 1] - '0';
                var biNum = lastNum * 10 + uniNum; 
                
                if(uniNum > 0)
                {
                    decodingArrary[i] =  decodingArrary[i - 1];
                }
                else if (biNum >=10 && biNum <=26)
                {
                    decodingArrary[i] += decodingArrary[i -2];
                }

                lastNum =uniNum;
            }
            return decodingArrary[len];
        }

        public int DistanceBetweenBusStops(int[] distance, int start, int destination) {
            int dis = 0;
            int sum = 0;
            if(distance.Length<=0) return 0;
            
            for(int i =0; i < distance.Length; ++i)
            {
                if(i>=start && i< destination ||
                    i<start && i>=destination)
                    dis = dis + distance[i];
                sum+=distance[i];
            }
            return Math.Min(dis, sum-dis);
        }
        public IList<IList<int>> SubsetsWithDup(int[] nums) {
            Array.Sort(nums);
            IList<IList<int>> results = new List<IList<int>>();
            var current = new List<int>();
            BacktrackSubsetsWithDup(current, 0, nums.Length, nums, results);

            return results;
        }

        public void BacktrackSubsetsWithDup(List<int> current, int step, int n, int[] nums, IList<IList<int>> results)
        {
            results.Add(new List<int>(current));
            for(int i =step; i < n; ++i)
            {
                current.Add(nums[i]);
                BacktrackSubsetsWithDup(current, i+1, n, nums, results );
                current.Remove(nums[i]);

                while (i + 1 < n && nums[i] == nums[i + 1]) ++i;
            }
        }


        public int UniquePaths(int m, int n) {
            if(m <=0 || n <=0) return 0;
            int[,] pathArray = new int[m, n];
            for(int i =0; i < m; i ++) pathArray[i, 0] =1;
            for(int i =0; i < n; i ++) pathArray[0, i] =1;

            for(int i = 1; i < m ; ++i)
            {
                for(int j = 1; j < n ; ++j)
                {
                    pathArray[i, j] = pathArray[i-1, j] + pathArray[i, j-1];
                }
            }

            return pathArray[m-1, n-1];
        }


        public int MinDistance(string word1, string word2) {
            int pos1 = word1.Length;
            int pos2 = word2.Length;

            return DPMinDistance(word1, word2, pos1, pos2);
        }
        
        public int DPMinDistance(string word1, string word2, int len1, int len2)
        {
            if(len1 ==0) return len2;
            if(len2 == 0) return len1;

            int[,] distanceArray = new int[len1 + 1, len2 + 1];
            
            for(int i =0; i <= len1; i++)
            {
                distanceArray[i, 0] = i;
            }

            for(int i =0; i <= len2; i++)
            {
                distanceArray[0, i] = i;
            }

            for(int i =1; i <= len1; i++)
            {
                for(int j=1; j<= len2; j++)
                {
                    if(word1[i -1 ] == word2[j - 1])
                    {
                        distanceArray[i,j] = distanceArray[i-1,j-1];
                    }
                    else
                    {
                        distanceArray[i,j] = Math.Min(distanceArray[i-1,j-1],Math.Min(distanceArray[i-1, j],distanceArray[i, j-1])) +1;
                    }
                }
            }

            return distanceArray[len1,len2];
        }

        public int RecursiveEditDist(String str1 , String str2 , int m ,int n) 
        { 
            // If first string is empty, the only option is to 
            // insert all characters of second string into first 
            if (m == 0) return n; 
            
            // If second string is empty, the only option is to 
            // remove all characters of first string 
            if (n == 0) return m; 
            
            // If last characters of two strings are same, nothing 
            // much to do. Ignore last characters and get count for 
            // remaining strings. 
            if (str1[m - 1] == str2[n - 1]) 
                return RecursiveEditDist(str1, str2, m - 1, n - 1); 
            
            // If last characters are not same, consider all three 
            // operations on last character of first string, recursively 
            // compute minimum cost for all three operations and take 
            // minimum of three values. 
            return 1 + Math.Min ( RecursiveEditDist(str1, str2, m, n - 1), // Insert 
                            Math.Min(RecursiveEditDist(str1, str2, m - 1, n), // Remove 
                            RecursiveEditDist(str1, str2, m - 1, n - 1) // Replace  
                            )                    
                        ); 
        } 

        public int RecurMinDistance(string word1, string word2, int pos1, int pos2)
        {
            if(pos1 ==0) return pos2;
            if(pos2 == 0) return pos1;

            if(word1[pos1-1] == word2[pos2-1])
                return RecurMinDistance(word1, word2, pos1-1, pos2-1);
            
            return Math.Min(RecurMinDistance(word1, word2, pos1, pos2 - 1), // Insert
                            Math.Min(RecurMinDistance(word1, word2, pos1 - 1, pos2 - 1), //Replace
                                    RecurMinDistance(word1, word2, pos1 - 1, pos2)))  // Delete
                    + 1;
        }



        public IList<string> WordSubsets(string[] A, string[] B) {
            List<int[]> charCountInA = new List<int[]>();
            //List<int[]> charCountInB = new List<int[]>();

            int[] charMaxCountInB = new int[26];
            

            foreach(var str in A)
            {
                charCountInA.Add(Str2CharCount(str));
            }

            foreach(var str in B)
            {
                var charCount = Str2CharCount(str);
                for(int i =0; i < 26; i++)
                {
                    if(charCount[i] > charMaxCountInB[i])
                    {
                        charMaxCountInB[i] = charCount[i];
                    }
                }
            }

            

            IList<string> results = new List<string>();
            for(int i=0; i< A.Length; ++i)
            {
                int[] a = charCountInA[i];

                if(IsWordSubset(a, charMaxCountInB))
                {
                    results.Add(A[i]);
                }
            }

            return results;
        }

        public bool IsWordSubset(int[] charCountInA, int[] charCountInB)
        {
            for(int i = 0 ; i < 26; i++)
            {
                if(charCountInA[i]< charCountInB[i])
                    return false;
            }

            return true;
        }

        public int[] Str2CharCount(string str)
        {
            int[] charCount = new int[26];

            foreach(var c in str)
            {
                charCount[c-'a'] =  charCount[c-'a'] +1;
            }

            return charCount;
        }
        

        public bool IsSameTree(TreeNode p, TreeNode q) {
            return (p == null && q == null) ||
                (p != null && q != null && p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right));
        }

                /**
        * Definition for singly-linked list.
        */
        
            public ListNode DeleteDuplicates(ListNode head) {
                ListNode slow = head; 
                ListNode fast = head;
                int lastValue = fast.val;
                while(fast != null)
                {
                    if(fast.val!= lastValue)
                    {
                        lastValue = fast.val;
                        slow.next = fast;
                        slow = fast;
                    }
                    fast = fast.next;
                }
                slow.next = null;

                return head;
            }

        public IList<int> GrayCode(int n) {
            List<int> list = new List<int>();
            list.Add(0);
            int x = 0;
            for (int i = 1; i <= n; i++) {
                x = 1 << (i - 1); // Math.pow(2, i - 1)
                for (int j = x - 1; j >= 0; j--) {
                    list.Add(list[j] | x);  // append 1 in front
                }
            }
            return list;
        }

        public int MinPathSum(int[][] grid) {
            if(grid == null) return 0;
            int rows = grid.Length;
            if(rows ==0) return 0;
            int columns = grid[0].Length;

            int[,] pathMap = new int[rows, columns];

            for(int i =0; i < rows; i++)
            {
                pathMap[i, 0] = i ==0? grid[i][0]: grid[i][0]+ pathMap[i-1, 0];
            }
            for(int j =0; j < columns; j++)
            {
                pathMap[0, j] = j ==0? grid[0][j]: grid[0][j]+ pathMap[0, j-1];
            }
            
            for(int i =1; i < rows; i ++)
                for (int j =1; j < columns; j ++)
                {
                    pathMap[i,j] =Math.Min(pathMap[i-1, j], pathMap[i,j-1]) + grid[i][j];
                }

            return pathMap[rows-1,columns-1];
        }
        

        public int RecersiveMinPathSum(int[][] grid, int r, int c,  int rows, int columns)
        {
            if(r ==0 && c==0)
                return grid[0][0];
            
            if(c<0 || c> columns|| r<0 || r> rows)
                return int.MaxValue;

            /*return Math.Min(Math.Min(DPMinPathSum(grid, r-1, c, rows, columns),  DPMinPathSum(grid, r+1, c, rows, columns)),
                            Math.Min(DPMinPathSum(grid, r, c-1, rows, columns),  DPMinPathSum(grid, r, c+1, rows, columns))) 
                   + grid[r][c];*/
            return Math.Min(RecersiveMinPathSum(grid, r-1, c, rows, columns),  RecersiveMinPathSum(grid, r, c-1, rows, columns))
                   + grid[r][c];
        }
        public bool Exist(char[][] board, string word) {
            if(string.IsNullOrEmpty(word)) return false;
            int columns = board.Length;
            if(columns == 0) return false;
            int rows = columns>0?board[0].Length:0;
            if(rows == 0 ) return false;
            
            HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>();
            
            for(int i =0; i < columns; ++i)
                for(int j =0; j< rows;++j)
                {
                    if (board[i][j] == word[0] && DFSExist(board, word, 0, i, j, visited, columns, rows))
                    {
                        return true;
                    }
                }

            return false;
        }

        public bool DFSExist(char[][] board, string word, int pos, int x, int y, HashSet<Tuple<int, int>> visited, int columns, int rows)
        {
            pos ++;
            if(pos == word.Length)
                return true;
            
            visited.Add(Tuple.Create(x, y));
            if(!visited.Contains(Tuple.Create(x-1, y)) && x > 0 && board[x-1][y] == word[pos] 
                && DFSExist(board, word, pos , x-1, y , visited, columns, rows))
                return true;
            if(!visited.Contains(Tuple.Create(x+1, y)) && x + 1< columns  && board[x+1][y] == word[pos] 
                && DFSExist(board, word, pos , x+1, y , visited, columns, rows))
                return true;
            if(!visited.Contains(Tuple.Create(x, y-1)) && y - 1>=0 && board[x][y - 1] == word[pos] 
                && DFSExist(board, word, pos , x, y -1 , visited, columns, rows))
                return true;
            if(!visited.Contains(Tuple.Create(x, y + 1)) && y + 1 < rows && board[x][y +1] == word[pos] 
                && DFSExist(board, word, pos , x, y + 1 , visited, columns, rows))
                return true;

            visited.Remove(Tuple.Create(x, y));
            return false;
        }

        public bool DictExist(char[][] board, string word) {
            int columns = board.Length;
            int rows = columns>0?board[0].Length:0;
            Dictionary<char, List<BoardItem>> boardDict = new Dictionary<char, List<BoardItem>>();
            for(int i =0; i < columns; ++i)
                for(int j =0; j< rows;++j)
                {
                    char c = board[i][j];
                    if(!word.Contains(c))
                        continue;

                    var item = new BoardItem(i, j, board[i][j]);

                    if(i > 0 &&  word.Contains(board[i-1][j])) item.AddNeighbor(new BoardItem(i-1, j, board[i-1][j]));
                    if(i +1 < columns &&  word.Contains(board[i+1][j])) item.AddNeighbor(new BoardItem(i+1, j, board[i+1][j]));
                    if(j > 0 &&  word.Contains(board[i][j-1])) item.AddNeighbor(new BoardItem(i, j-1, board[i][j-1]));
                    if(j + 1 < rows &&  word.Contains(board[i][j+1]) ) item.AddNeighbor(new BoardItem(i, j+1, board[i][j+1]));

                    if(boardDict.ContainsKey(c))
                    {
                        var tmp = boardDict[c];
                        tmp.Add(item);
                        boardDict[c] = tmp;
                    }
                    else
                    {
                        boardDict.Add(c, new List<BoardItem>(){item});
                    }
                }
            
            return true;
        }

        public IList<int> SpiralOrder(int[][] matrix) {
            int height = matrix.Length;
            int width = height>0? matrix[0].Length: 0;

            int left =0;
            int right = width-1;
            int top =0;
            int bottom = height -1;
            IList<int> results = new List<int> ();
            int x =0; int y=0;
            while(right >= left && bottom >= top && width >0 && height > 0)
            {
                y = left; 
                x = top;
                while(y< left+width)
                {
                    results.Add(matrix[x][y]);
                    y++;
                }
                y = left + width -1;
                x = top + 1;
                while(x<top + height)
                {
                    results.Add(matrix[x][y]);
                    x++;
                }
                x=top+height -1;
                y=left+width -2;
                while(y>= left && x> top)
                {
                    results.Add(matrix[x][y]);
                    y--;
                }
                y=left;
                x= top+height-2;
                while(x> top && width>1)
                {
                    results.Add(matrix[x][y]);
                    x--;
                }

                left ++;
                right--;
                bottom--;
                top++;
                width = width -2;
                height = height -2;
            }

            return results;
        }

        public bool IsValidSudoku(char[][] board) {
            for(int i =0; i < 9; ++i)
            {
                int[] values = new int[10];
                for(int j =0; j< 9; ++j)
                {
                    int index = board[i][j] - '0';
                    if(index <1 || index >9) continue;
                    if(values[index] == 1)
                    {
                        return false;
                    }
                    values[index] = 1;
                }
            }

            for(int i =0; i < 9; ++i)
            {
                int[] values = new int[10];
                for(int j =0; j< 9; ++j)
                {
                    int index = board[j][i] - '0';
                    if(index <1 || index >9) continue;
                    if(values[index] == 1)
                    {
                        return false;
                    }
                    values[index] = 1;
                }
            }

            for(int x = 0; x < 9; x = x +3)
                for(int y = 0; y < 9; y = y +3)
                {
                    int[] values = new int[10];
                    for(int i =0; i < 3; ++i)
                    {
                        for(int j =0; j< 3; ++j)
                        {
                            int index = board[x+i][y+j] - '0';
                            if(index <1 || index >9) continue;
                            if(values[index] == 1)
                            {
                                return false;
                            }
                            values[index] = 1;
                        }
                    }
                }
            

            return true;
        }

        public int FirstMissingPositive(int[] nums) {
            int minVal = int.MaxValue;
            int length =0;
            foreach(int num in nums)
            {
                if(num > 0 && num < minVal)
                {
                    minVal = num;
                }
                if(num > 0)
                {
                    length ++;
                }
            }

            if(minVal != 1)
            {
                return 1;
            }

            int[] numMap = new int[length];
            foreach(int num in nums)
            {
                if(num > 0 && num - minVal < length -1)
                {
                    numMap[num-minVal] = 1;
                }
            }

            for(int i =0; i< length; i++)
            {
                if(numMap[i] != 1)
                    return i+1;
            }
            
            return length+1;
        }

        public int RemoveElement(int[] nums, int val) {
            int slow =0;
            int fast =0;
            while(fast < nums.Length)
            {
                if(nums[fast] != val)
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
                fast ++;
            }
            return slow;
        }

        public void NextPermutation(int[] nums) {
            int target = -1; 
            for(int i = nums.Length-1; i>=0; --i)
            {
                
                for(int j = i -1; j >=0; --j)
                {
                    if(nums[j] < nums[i] )
                    {
                        target = j;
                        break; 
                    }
                }

                if(target != -1)
                {
                    swap(nums, i, target);
                    break;
                }
            }

            if(target == -1)
            {
                int i =0;
                int j = nums.Length-1;
                while(i< j)
                {
                    swap(nums, i, j);
                    i++;
                    j--;
                }
            }
        }

        public void swap(int[] nums, int i , int j)
        {
            var tmp = nums[i];
            nums[i] =nums[j];
            nums[j]= tmp;
        }

        public int LongestValidParentheses(string s) {
            if(string.IsNullOrEmpty(s) || s.Length <2) return 0;
            List<int> dpArray = new List<int>();
            for(int i =0;i < s.Length; ++i)
            {
                dpArray.Add(0);
            }

            for(int i =0; i < s.Length; ++i)
            {
                if(s[i] =='(')
                    continue;
                if(i-1>=0&& s[i-1]=='(')
                {
                    dpArray[i] = 2 + (i-2>=0? dpArray[i-2]:0);
                }
                else if(i -1 >=0 && s[i-1]== ')')
                {
                    if(dpArray[i-1]-1 >=0 && s[i-dpArray[i-1]-1] =='(')
                    {
                        dpArray[i] = 2 + dpArray[i-1];
                    }
                }
            }

            return dpArray.Max();
        }
        
        // 14. in git
        public string LongestCommonPrefix(string[] strs) {
            string result = string.Empty;
            if(strs ==null || strs.Length ==0)
            {
                return result;
            }
            for(int i =0; i < strs[0].Length; ++i)
            {
                char x = strs[0][i];
                bool match = true;
                foreach(var str in strs)
                {
                    if(i>= str.Length || str[i]!= x)
                    {
                        match =false;
                        break;
                    }
                }
                if(match == true)
                {
                    result = result + x;
                }
                else
                {
                    break;
                }
            }

            return result;
        }
        

        public IList<string> LetterCasePermutation(string S) {
            int step =0;
            int n = S.Length;
            IList<string> results = new List<string>();
            string current =  "";

            BacktrackLetterCasePermutation(current, step, n, S, results);
            return results;
        }

        public void BacktrackLetterCasePermutation(string current, int step, int n, string S, IList<string> results)
        {
            if(step == n)
            {
                results.Add(current);
                return;
            }

            char nextChar = S[step];
            if(char.IsLetter(nextChar))
            {
                
                var str1 = new string(current) + char.ToLower(nextChar);
                BacktrackLetterCasePermutation(str1, step +1, n, S, results);

                var str2 = new string(current) + char.ToUpper(nextChar);
                BacktrackLetterCasePermutation(str2, step +1, n, S, results);
            }
            else
            {
                var str = new string(current) + nextChar;
                BacktrackLetterCasePermutation(str, step +1, n, S, results);
            }
        }

        public IList<IList<int>> Subsets(int[] nums) {
            IList<IList<int>> results = new List<IList<int>>();

            int step =0;
            int n = nums.Length;
            List<int> current = new List<int>();
            BacktrackSubsets(current, step, n, nums, results);

            return results;
        }

        public void BacktrackSubsets(List<int> current, int step, int n, int[] nums, IList<IList<int>> results)
        {
            results.Add(new List<int>(current));
            for(int i =step; i < n; ++i)
            {
                current.Add(nums[i]);
                BacktrackSubsets(current, i+1, n, nums, results );
                current.Remove(nums[i]);
            }
        }

        public int[] CountBits(int num) {
            List<int> bits = new List<int>();
            List<int> results = new List<int>();
 
            results.Add(0);
            bits.Add(0);
            if(num == 0)
            {
                return results.ToArray();
            }
            int i =1;
            while(i <= num)
            {
                i ++;

                var add = 1; 
                int cnt =0;
                var size = bits.Count;
                for(int j =0; j<size; ++j)
                {
                    var bit = bits[j];
                    if(bit ==0 && add ==0)
                    {
                        continue;
                    }
                    else if(bit ==0 && add ==1)
                    {
                        cnt++;
                        bits[j] =1;
                        add =0;
                    }
                    else if(bit ==1 && add ==0)
                    {
                        cnt++;
                    }
                    else
                    {
                        bits[j] =0;
                        add =1;
                    }
                }

                if(add == 1)
                {
                    bits.Add(1);
                    cnt++;
                }

                results.Add(cnt);
            }

            return results.ToArray();
        }

        public IList<string> GenerateParenthesis(int n) {
            List<char> chars = new List<char>();
           
            int open =0;
            int close =0;
            List<char> current = new List<char>();
            for(int i =0; i < n; ++i)
            {
                current.Add('-');
                current.Add('-');
            }
            HashSet<string> solutions = new  HashSet<string>();
            
            current[0] = '(';
            BacktrackGenerateParenthesis(current, open + 1, close, n,  solutions);
            return solutions.ToList();
        }

        public void BacktrackGenerateParenthesis(List<char> current, int open, int close, int n, HashSet<string> solutions)
        {
            if(open == n && close == n)
            {
                solutions.Add(string.Join("", current));
                return;
            }
            
            if(open >n || close > open)
            {
                return;
            }
            else
            {
                current[open + close] = '(';
                BacktrackGenerateParenthesis(current, open +1, close, n, solutions);

                current[open + close] = ')';
                BacktrackGenerateParenthesis(current, open, close +1, n, solutions);
                current[open + close] = ' ';
            }
        }


        public IList<IList<string>> SolveNQueens(int n) {
            int step = 0;

            List<int> current = new List<int>();
            for(int i =0; i<=n; ++i){
                current.Add(-1);
            }

            IList<IList<string>> solutions = new List<IList<string>>();

            BackTrackNQueens(current, step, n, solutions);

            return solutions;
        }

        public bool IsValidNQueen(List<int> current, int step)
        {
            if(step <= 1) return true;

            for(int i =1; i < step; i++)
            {
                if(current[i-1] == current[step -1])
                {
                    return false;
                }
                else if (current[i -1] - i == current[step -1] - step )
                {
                    return false;
                }
                else if (current[i -1] + i == current[step -1] + step )
                {
                    return false;
                }
            }

            return true;
        }

        public void BackTrackNQueens(List<int> current, int step, int n, IList<IList<string>> solutions)
        {
            if(step == n)
            {
                if(IsValidNQueen(current, step))
                {
                    List<string> result = new List<string>();
                    for(int i =0; i<n; i++)
                    {
                        StringBuilder sb = new StringBuilder();
                         for(int j =0; j<n; j++)
                         {
                             if(j ==current[i])
                             {
                                 sb.Append("Q");
                             }
                             else
                             {
                                 sb.Append(".");
                             }
                         }
                         result.Add(sb.ToString());
                    }
                    solutions.Add(result);
                }

                return;
            }
            else if(IsValidNQueen(current, step) )
            {
                for(int i =0; i < n; ++i)
                {
                    current[step]= i;
                    BackTrackNQueens(current, step +1, n, solutions);
                    current[step]= -1;
                }
            }
            else 
            {
                return;
            }
        }

        public bool BackspaceCompare(string S, string T) {
                if(string.IsNullOrEmpty(S) && string.IsNullOrEmpty(T))
                {
                    return true;
                }
                else if(S == null || T == null)
                {
                    return false;
                }

                List<char> l1 = new List<char>();
                int i1 = S.Length -1;
                int g1 = 0;
                while(i1 >=0)
                {
                    if(S[i1] == '#')
                    {
                        g1++;
                    }
                    else if(g1 ==0)
                    {
                        l1.Add(S[i1]);
                    }
                    else
                    {
                        g1--;
                    }

                    i1--;
                }

                List<char> l2 = new List<char>();
                int i2 = T.Length -1;
                int g2 = 0;
                while(i2 >=0)
                {
                    if(T[i2] == '#')
                    {
                        g2++;
                    }
                    else if(g2 ==0)
                    {
                        l2.Add(T[i2]);
                    }
                    else
                    {
                        g2--;
                    }

                    i2--;
                }

                Console.WriteLine(string.Join("", l1) );
                Console.WriteLine(string.Join("", l2) );
                return string.Join("", l1) == string.Join("",l2);
            }
        public int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> hashMap = new Dictionary<int, int>();
            for(int i =0; i< nums.Length; ++i)
            {
                var num = nums[i];
                if(hashMap.ContainsKey(target - num))
                    return new int[]{ hashMap[target-num],i};
                else if(!hashMap.ContainsKey(num))
                    hashMap.Add(num, i);

            }
            
            //Array.Sort(nums);
            
            return new int[]{-1, -1};
        }

        public IList<string> BinaryTreePaths(TreeNode root) {
            List<string> paths = new List<string>();

            RecurseVisit(root, paths, new List<int>());

            return paths;        
        }

        public void RecurseVisit(TreeNode node, List<string> paths, List<int> current)
        {
            if(node == null) return;

            if(node.left == null && node.right == null){
                current.Add(node.val);
                paths.Add(string.Join("->", current));
                current.RemoveAt(current.Count-1);
                return;
            }

            current.Add(node.val);
            RecurseVisit(node.left, paths, current);
            RecurseVisit(node.right, paths, current);

            current.RemoveAt(current.Count-1);
            return;
        }

        public IList<int> InorderTraversal(TreeNode root) {
            List<int> values = new List<int>();

            RecurseInorderTraversal(root, values);

            return values;
        }

        public void RecurseInorderTraversal(TreeNode node, List<int> values){
            if(node == null) return;

            RecurseInorderTraversal(node.left, values);
            values.Add(node.val);
            RecurseInorderTraversal(node.right, values);
        }

        public int MissingNumber(int[] nums) {
            var sum =0;
            int max =0;
            foreach(var num in nums)
            {
                sum = sum + num;
                max = Math.Max(max, num);
            }

            var res = max * (max+1)/2 -sum;
            return res==0? (max == nums.Length? 0: max+1) :res;
        }

        public void MoveZeroes(int[] nums) {
            var slowIdx = 0;
            var fastIdx =0;
            while(fastIdx < nums.Length)
            {
                if(nums[fastIdx] != 0)
                {
                    nums[slowIdx] = nums[fastIdx];
                    slowIdx ++;
                }
                fastIdx ++;
            }

            while(slowIdx < nums.Length)
            {
                nums[slowIdx] = 0;
                slowIdx ++;
            }
            
        }


        public bool WordPattern(string pattern, string str) {
            var items = str.Split(' ');
            if(items.Length != pattern.Length) return false;

            Dictionary<char, string> patternMap = new Dictionary<char, string>();
            HashSet<string> values = new HashSet<string>();
            for(int i =0; i< items.Length; ++i)
            {
                if(patternMap.ContainsKey(pattern[i]))
                {
                    if( patternMap[pattern[i]] != items[i])
                    return false;
                }
                else if(values.Contains(items[i]))
                {
                    return false;
                }
                else
                {
                    patternMap.Add(pattern[i], items[i]);
                    values.Add(items[i]);
                }
            }

            return true;
        }


            public int HIndex(int[] citations) {
                if(citations.Length < 1)
                {
                    return 0;
                }

                int[] data = new int[citations.Length];

                foreach(var citation in citations)
                {
                    if(citation >= citations.Length)
                    {
                        data[citations.Length-1] = data[citations.Length-1] + 1;
                    }
                    else
                    {
                        data[citation] = data[citation] + 1;
                    }
                }

                var hindex = 0;
                for(int i = data.Length -1 ; i>=0; --i)
                {
                    if(hindex + data[i] >i)
                    {
                        return hindex;
                    }
                    else
                    {
                        hindex = hindex + data[i];
                    }
                }

                return hindex;
            }

            
            public int NumSquares(int n) {
                var squares = GetAllSquares(n);
                
                if(squares.Count ==0)
                    return 0;

                this.minCount  = n;
                
                NumSquaresDP(n, 0, 0, squares, squares.Count -1);

                return this.minCount;
            }
            int minCount;
            public void NumSquaresDP(int n, int sum, int cnt, List<int> squares, int index)
            {
                if(sum == n )
                {
                    if(cnt < minCount)
                    {
                        this.minCount = cnt;
                        return;
                    }
                }

                if(sum> n || cnt > this.minCount)
                {
                    return;
                }

                NumSquaresDP(n, sum + squares[index], cnt+1, squares, index);

                if(index >= 1)
                    NumSquaresDP(n, sum, cnt, squares, index -1);
            }

            public List<int> GetAllSquares(int n)
            {
                List<int> squares = new List<int>();
                for(int i =1; i< n; ++i)
                {
                    if(i*i >n)
                        break;
                    else
                        squares.Add(i*i);
                }

                return squares;
            }

                public string GetHint(string secret, string guess) {
                    var bulls = 0;
                    var len = secret.Length;
                    int[] s = new int[10];
                    int[] g = new int[10];
                    for(int i = 0; i< len; ++i)
                    {
                        if(secret[i] == guess[i])
                        {
                            bulls++;
                        }
                        else
                        {
                            s[secret[i]-'0'] =s[secret[i]-'0'] +1;
                            g[guess[i]-'0'] =s[guess[i]-'0'] +1;
                        }
                    }


                    var cows =0;
                    for(int i =0; i< 10; ++i)
                    {
                        cows=cows+ Math.Min(s[i], g[i]);
                    }

                    return bulls.ToString()+"A"+cows.ToString()+"B"; 
                }

            public int LengthOfLIS(int[] nums) {
                int[] lengthList = new int[nums.Length];

                var maxLength=1;
                for(int i = 0; i< nums.Length; ++i)
                {
                    var current = 1;
                    for(int j =0; j < i; ++j)
                    {
                        if(nums[i]>nums[j] && lengthList[j] + 1 > current)
                        {
                            current = lengthList[j] + 1 ;
                        }
                    }

                    if(current> maxLength)
                        maxLength = current;
                    
                    lengthList[i] = current;
                }

                return maxLength;
            }

            
    }
}
