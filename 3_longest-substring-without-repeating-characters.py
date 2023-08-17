class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        length = 0
        maxLength = 0
        left = 0
        right = 0
        d = {}
        for i in range(len(s)):
            d[s[i]] = 0

        while right < len(s):
            while right< len(s):
                d[s[right]] +=1
                if d[s[right]]>1:
                    break
                length +=1
                right +=1
            #print("# 1 -left : %2d, right : %2d, length: %2d" % (left, right, length))
            if length> maxLength: maxLength = length
            while length >0:
                d[s[left]] -=1
                length -=1
                left +=1
                if d[s[left-1]] > 0:
                    d[s[left-1]]-=1
                    break
            #print("# 2 -left : %2d, right : %2d, length: %2d" % (left, right, length))
        return maxLength

instance = Solution()
print(instance.lengthOfLongestSubstring('aab'))
print(instance.lengthOfLongestSubstring('pwwkew'))
