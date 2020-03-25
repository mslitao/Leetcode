def breakWords(header):
  words = []
  n = len(header)
  s = 0
  for i in range(n):
    word = ''
    if((header[i] == '_' or header[i] == ' ' or header[i] == '.')  and i >= s):
      word = header[s:i]
      s = i + 1
    elif(i == (n -1) and i >= s):
      word = header[s:]
    elif(header[i].isupper() and i >=s):
      word = header[s:i]
      s = i
    word = word.rstrip('1234567890.')
    if(len(word) > 0):
      words.append(word.lower())
    
  return words

print(breakWords('a_b_cDEfe__LocationCity12 last1PurchaseAmount New York'))
  