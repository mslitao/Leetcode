class Solution:
    def convert(self, s: str, numRows: int) -> str:
        if numRows<=0 or not s: return s
        rows = []
        for i in range(numRows):
            rows.append('')
        idx = 0
        order = 1
        for i in range(len(s)):
            if idx < 0:
                idx = 1
                order = 1
            if idx == numRows:
                idx = numRows -2
                order = 0
            rows[idx] = rows[idx]+ s[i]

            if order == 1:
                idx +=1
            else: 
                idx -=1
        
        #print(rows)
        result = ''
        for i in range(numRows):
            if rows[i]:
                result = result + rows[i]
        return result

instance = Solution()
print(instance.convert('PAYPALISHIRING', 3))
print(instance.convert('PAYPALISHIRING', 4))
print(instance.convert('PAYPALISHIRING', 1))
print(instance.convert('A', 1))