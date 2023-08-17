class Solution:
    def isValid(self, s: str) -> bool:
        records = []
        if len(s) == 0:
            return True
        
        dict = {')':'(', ']':'[', '}':'{'}
        for i in range(len(s)):
            if s[i] not in dict:
                records.append(s[i])
            elif len(records)> 0 and dict[s[i]]== records[len(records)-1]:
                records.pop()
            else:
                records.append(s[i])
        
        if len(records) ==0:
            return True

        return False

instance = Solution()
print(instance.isValid("()"))


