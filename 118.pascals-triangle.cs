using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution118 {
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
}