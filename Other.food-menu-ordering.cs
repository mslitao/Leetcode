using System;
using System.Collections.Generic;
/*
Your task is to process the following menu of food items, and determine which combination of food items could be purchased for the receipt values below.

The Menu: (I'll try to provide this in a hash or map data structure as an input)

veggie sandwich: 6.85
extra veggies: 2.20
chicken sandwich: 7.85
extra chicken: 3.20
cheese: 1.25
chips: 1.40
nachos: 3.45
soda: 2.05

The receipt values to test, also provided as an input:

4.85, 11.05, 13.75, 17.75, 18.25, 19.40, 28.25, 40.30, 75.00

- your script should process as many of these receipt values as possible in under 30 seconds
- you must use 100% of the money, we don't want any money left over
- you can order any quantity of any menu item
- none of the receipt values are "tricks", they all have combinations that add up to exactly their money amount


Part One:

Find a single combination of menu items that add up to exactly these amounts of money, and output them as your script runs. Output format is up to you, but here are a few examples:

13.75, 3 items, ['veggie sandwich', 'nachos', 'nachos']
13.75, 3 items, {'veggie sandwich': 1, 'nachos': 2}


Part Two:

Each receipt value above has many possible combinations. Next, refactor your algorithm to identify which combination contains fewer total items than other answers.

Example:
4.85 receipt has three combinations:
- best: nachos, chips (2 total items)
- extra veggies, chips, cheese (3 total times)
- chips, chips, soda (3 total items)
*/

class SolutionCombine
{

    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> results = new List<IList<int>>();
        if(candidates==null || candidates.Length ==0 ) return results;

        List<int> current = new List<int>();
        BacktrackCombinationSum(current, 0, 0, candidates, target, results);
        return results;
    }

    public void BacktrackCombinationSum(List<int> current, int sum, int idx, int[] nums, int target, IList<IList<int>> results)
    {
        if(sum == target)
        {
            var res = new List<int>(current);
            results.Add(res);
            return;
        }
        
        if(sum > target)
        {
            return;
        }

        for(int i = idx; i < nums.Length; ++i)
        {
            var num = nums[i];
            var pos = current.Count;
            current.Add(num);
            BacktrackCombinationSum(current, sum+num, i,  nums, target, results);
            current.RemoveAt(pos);
        }
    }

    //131. Palindrome Partitioning
    public IList<IList<string>> PartitionString(string s) {
        IList<IList<string>> results = new List<IList<string>>();
        if(string.IsNullOrEmpty(s)) return results;

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
        List<string> current = new List<string>();
        BPPartitionString(current, 0, s, results, dp);

        return results;
    }

    public void BPPartitionString(List<string> current, int idx, string s, IList<IList<string>> results, bool[,] dp)
    {
        if(idx >= s.Length) 
        {
            List<string> res = new List<string>(current);
            results.Add(res);
            return;
        }

        for(int i =idx; i < s.Length; ++i)
        {
            if(!dp[idx, i]) continue;
            
            int pos = current.Count;
            current.Add(s.Substring(idx, i-idx+1));
            BPPartitionString(current, i+1, s, results, dp);
            current.RemoveAt(pos);
        }
    }

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
    static void Main1(string[] args)
    {
        float [] receipts =new [] {4.85F, 11.05F, 13.75F, 17.75F, 18.25F, 19.40F, 28.25F, 40.30F, 75.00F};

        Dictionary<string, float> menu_items = new Dictionary<string, float>();
        menu_items.Add("veggie sandwich", 6.85F);
        menu_items.Add("extra veggies", 2.20F);
        menu_items.Add("chicken sandwich", 7.85F);
        menu_items.Add("extra chicken", 3.20F);
        menu_items.Add("cheese", 1.25F);
        menu_items.Add("chips", 1.40F);
        menu_items.Add("nachos", 3.45F);
        menu_items.Add("soda", 2.05F);
        
        
        /*foreach(var receipt in receipts)
        {
            float current = 0.0F;
            List<string> items = new List<string>();
            List<List<string>> results = new List<List<string>>();
            
            FindPurchaseItems(current, items, receipt, menu_items, results);
            
            int minItems = int.MaxValue;
            List<string> bestResult = null;
            
            foreach(var result in results)
            {
                if(result.Count < minItems)
                {
                    bestResult = result;
                    minItems = result.Count;
                }
                
            }
            Console.WriteLine(String.Format("{0}, {1} items, {2}",
                                                receipt,
                                                minItems,
                                                string.Join(",", bestResult)));
        }*/
        
        foreach(var receipt in receipts)
        {
            
            Console.WriteLine(String.Format("{0}, {1} items, {2}",
                                                receipt,
                                                DPFindPurchaseItems(receipt, menu_items),
                                                ""));
            
            
            
        }
        
        
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
    
    public static int DPFindPurchaseItems(float receipt, Dictionary<string, float> menuItems)
    {
        // Step 1: Initilize the dp array
        int size = (int)(100.0* receipt) ;
        int[] dpCnt = new int[size + 1];
        List<List<string>> dpItems = new List<List<string>>();
        
        dpCnt[0] = 0;
        dpItems.Add(new List<string>());
        
        //Step 2: update the DP array
        for(int i = 1; i <= size; ++i)
        {
            int minItems = int.MaxValue;
            
            foreach(var item in menuItems)
            {
                int cnt = 1;
                while((receipt - item.Value* cnt) >=0)
                {
                    var pos = (int)(100.0 *(receipt - item.Value*cnt));
                    if(dpCnt[pos] >=0)
                    {
                        minItems = Math.Min(minItems, cnt + dpCnt[pos]);
                    }
                    cnt ++;
                }
            }
            
            if(minItems == int.MaxValue)
            {
                dpCnt[i] = -1;
            }
            else
            {
                dpCnt[i] = minItems;
            }
        }
        
        // R
        return dpCnt[size];
    }
}

/*

BT:
1. BPFun(current, list<> items, price)

DP
0.0 -> target (0.01)
1. min items to purchase and meet the price
2. 0 to n

f(i) = Min(f(i - ), )
*/

/*
best answers for part 2:

 4.85: 2 items, ['chips', 'nachos']
11.05: 2 items, ['extra chicken', 'chicken sandwich']
13.75: 3 items, ['nachos', 'nachos', 'veggie sandwich']
17.75: 3 items, ['soda', 'chicken sandwich', 'chicken sandwich']
18.25: 5 items, ['cheese', 'cheese', 'soda', 'veggie sandwich', 'veggie sandwich']
19.40: 4 items, ['cheese', 'nachos', 'veggie sandwich', 'chicken sandwich']
28.25: 5 items, ['cheese', 'nachos', 'chicken sandwich', 'chicken sandwich', 'chicken sandwich']
40.30: 6 items, ['soda', 'veggie sandwich', 'chicken sandwich', 'chicken sandwich', 'chicken sandwich', 'chicken sandwich']
75.00: 12 items, ['cheese', 'soda', 'soda', 'veggie sandwich', 'chicken sandwich', 'chicken sandwich', 'chicken sandwich', 'chicken sandwich', 'chicken sandwich', 'chicken sandwich', 'chicken sandwich', 'chicken sandwich']

alternate for $75 receipt, also 12 items:
['soda','nachos','veggie sandwich','veggie sandwich','veggie sandwich','veggie sandwich','veggie sandwich','veggie sandwich','veggie sandwich','veggie sandwich','veggie sandwich','chicken sandwich']

*/



// To execute C#, please define "static void Main" on a class
// named Solution.

