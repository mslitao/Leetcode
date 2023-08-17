class Solution:
    def strStr(self, haystack: str, needle: str) -> int:
        len_needle, len_haystack = len(needle), len(haystack)
        next_table = self.buildNext(needle)
        n_pt, h_pt = 0, 0

        while h_pt < len(haystack):  
            if len_haystack - h_pt < len_needle - n_pt: return -1
            if needle[n_pt] == haystack[h_pt]:
                n_pt += 1
                h_pt += 1
                
                if n_pt >= len_needle:
                    return h_pt - len(needle)
                continue
            
 
            if n_pt != 0:
                n_pt = next_table[n_pt - 1]
            else: 
                h_pt += 1
        return -1

    def buildNext(self, pattern):
        _next = [0] *len(pattern)
        i, j = 1, 0
        while i < len(pattern) -1:
            while pattern[i] != pattern[j] and j >0:
                j = _next[j-1]
            
            if pattern[i] == pattern[j]:
                j+=1
            
            _next[i] = j
            i+=1

        return _next