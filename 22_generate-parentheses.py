from typing import List


class Solution:
    def generateParenthesis(self, n: int) -> List[str]:
        records = []
        records.append(['', 0, 0, 0])
        
        cnt = 0
        for i in range(n*2):
            while records[0][1] == cnt:
                tmp = records.pop(0)
            
                if tmp[2]+1 <= n:
                    newParen = [tmp[0]+'(', tmp[1] + 1, tmp[2]+ 1, tmp[3]]
                    records.append(newParen)
                
                if tmp[3]+1 > tmp[2] or tmp[3]+1 > n: 
                    continue
                newParen = [tmp[0]+')', tmp[1] + 1, tmp[2], tmp[3]+1]
                records.append(newParen)
            cnt+=1
        
        results = []
        for record in records:
            if record[2] == n and record[3] == n:
                results.append(record[0])
        return results
        
instance = Solution()
print(instance.generateParenthesis(5))

