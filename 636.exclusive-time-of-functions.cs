using System;
using System.Collections.Generic;
using System.Linq;


public class Solution636
{
    public int[] ExclusiveTime(int n, IList<string> logs) {
        // Dictonary
        // Stack
        int[] results = new int[n];
        Stack<int> stackId = new Stack<int>();
        Stack<int> stackStart = new Stack<int>();
        Stack<int> stackTime = new Stack<int>();

        foreach(var log in logs)
        {
            var tokens = log.Split(':');
            int id = int.Parse(tokens[0]);
            string stage = tokens[1];
            int time = int.Parse(tokens[2]);
            
            Console.WriteLine(string.Format("{0}-{1}-{2}", id, stage, time));
            if(stage == "start")
            {
                if(stackTime.Any())
                {
                    stackTime.Push(stackTime.Pop() + time - stackStart.Peek());
                }

                stackId.Push(id);
                stackStart.Push(time);
                stackTime.Push(0);
            }
            else
            {
                var tagetid = stackId.Pop(); 
                results[tagetid] = results[tagetid] + stackTime.Pop() + time - stackStart.Pop() + 1;

                if(stackStart.Any())
                {
                    stackStart.Pop();
                    stackStart.Push(time + 1);
                }
            }
        }

        return results;
    }
}