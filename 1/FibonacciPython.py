# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
"""
def fibo(n):
    if n <= 1:
        return n
    elif n == 2:
        return 1
    elif n == 3:
        return 2
    else:
        return(fibo(n-1) + fibo(n-2) + fibo(n-3))
        
for i in range(int(input())):
    print(fibo(i))