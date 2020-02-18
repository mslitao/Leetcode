using System;
using System.Collections.Generic;
using System.Linq;

public class Solution155
{
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
}