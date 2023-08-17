class Solution:
    def isScramble(self, s1: str, s2: str) -> bool:
        return self.match(s1, s2)

    def match(self, s1, s2):
        # print(s1 + '---VS----' + s2)
        if len(s1) != len(s2): return False
        n = len(s1)
        if n == 0: return True
        if n == 1: return s1 == s2
        if n == 2: return s1 == s2 or s1[::-1] == s2

        dict1 = {}
        for c in s1:
            if c in dict1:
                dict1[c] += 1
            else:
                dict1[c] = 1
        dict2 = {}
        for c in s2:
            if c in dict2:
                dict2[c] += 1
            else:
                dict2[c] = 1
        for k, v in dict1.items():
            if ((not k in dict2) or dict2[k] != v):
                return False
            

        for i in range(1, n):
            if (self.match(s1[0:i], s2[0:i]) and self.match(s1[i:], s2[i:]) or 
                self.match(s1[0:i], s2[n-i:]) and self.match(s1[i:], s2[0:n-i])):
                return True
        return False

# for i in range(1,3):
    # print(i)
    # print('abb'[0:i] + ' | ' + 'abb'[i:])
    # print('abb'[0:i] + ' | ' + 'abb'[4-i-1:])
    # print('bba'[0:i] + ' | ' + 'bba'[4-i-1:])

instance = Solution()
print(instance.isScramble(s1 = "great", s2 = "rgeat"))
print(instance.isScramble(s1 = "abcde", s2 = "caebd"))
print(instance.isScramble(s1 = "a", s2 = "a"))
print(instance.isScramble(s1 = "abb", s2 = "bba"))