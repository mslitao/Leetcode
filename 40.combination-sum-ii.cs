using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution40
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            candidates = candidates.OrderBy(n => n).ToArray();
            IList<IList<int>> results = new List<IList<int>>();
            List<int> tmp = new List<int>();
            CombinationSum(candidates, results, tmp, target, 0);

            return results;
        }

        public void CombinationSum(int[] candidates, IList<IList<int>> list, List<int> tmp, int remain, int start)
        {
            if (remain < 0)
            {
                return;
            }
            else if (remain == 0)
            {
                list.Add(new List<int>(tmp));
            }
            else
            {
                for (int i = start; i < candidates.Length; ++i)
                {
                    if (i > start && candidates[i] == candidates[i - 1]) continue; // skip duplicates -Key 
                    tmp.Add(candidates[i]);
                    CombinationSum(candidates, list, tmp, remain - candidates[i], i+1);
                    tmp.RemoveAt(tmp.Count - 1);
                }
            }

        }
}