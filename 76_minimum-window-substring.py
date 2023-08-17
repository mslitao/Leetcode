class Solution:
    def minWindow(self, s: str, t: str) -> str:
        m = len(s)
        n = len(t)
        res = ''
        if m == 0 and n == 0: return res
        if m == 0: return res
        if n == 0: return res
        if n > m: return res

        sMap = {}
        tMap = {}
        for c in t:
            if c in tMap:
                tMap[c] += 1
            else:
                tMap[c] = 1
        begin = end = 0
        nextEnd = True
        minLength = float('inf')
        while end < m:
            length = end - begin +1
            if nextEnd:
                if s[end] in sMap:
                    sMap[s[end]] +=1
                else:
                    sMap[s[end]] = 1
            if length < n or (not self.checkMatch(sMap, tMap)):
                nextEnd = True
                end += 1
            else:
                if length < minLength:
                    minLength = length
                    res = s[begin: end + 1]
                
                sMap[s[begin]] -= 1
                if sMap[s[begin]] == 0:
                    sMap.pop(s[begin])
                # print(sMap)
                begin +=1
                nextEnd = False
        return res
    
    def checkMatch(self, sMap, tMap):
        for k, v in tMap.items():
            if k not in sMap or sMap[k] < v:
                return False
        
        return True


instance = Solution()
print(instance.minWindow(s = "ADOBECODEBANC", t = "ABC"))