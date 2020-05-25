using System;
using System.Collections.Generic;
using System.Linq;

public class SolutionMock0525
{
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(var c in s)
        {
            if(c == '(' || c == '{' || c=='[')
            {
                stack.Push(c);
            }
            else if(!stack.Any())
            {
                return false;
            }
            else if(c == ')' && stack.Peek() == '(' ||
                    c == '}' && stack.Peek() == '{' ||
                    c == ']' && stack.Peek() == '[')
            {
                stack.Pop();
            }
            else
            {
                return false;
            }
        }

        if(stack.Any()) return false;

        return true;
    }


    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();

        foreach(var str in strs)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            var sortedStr = new string(charArray);

            if(!map.ContainsKey(sortedStr))
            {
                map.Add(sortedStr, new List<string>());
            }

            map[sortedStr].Add(str);
        }

        return map.Select(n=>n.Value).ToList();
    }


    public class MinStack {

        Stack<int> stackVal = new Stack<int>();
        Stack<int> stackMin = new Stack<int>();

        /** initialize your data structure here. */
        public MinStack() {
            
        }
        
        public void Push(int x) {
            this.stackVal.Push(x);
            if(!this.stackMin.Any())
            {
                this.stackMin.Push(x);
            }
            else
            {
                this.stackMin.Push(Math.Min(this.stackMin.Peek(), x));
            }
        }
        
        public void Pop() {
            if(this.stackMin.Any())
            {
                this.stackMin.Pop();
                this.stackVal.Pop();
            }
        }
        
        public int Top() {
            return this.stackVal.Peek();
        }
        
        public int GetMin() {
            return this.stackMin.Peek();
        }
    }
}