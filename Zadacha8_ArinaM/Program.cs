﻿int N;
Console.WriteLine($"введите число: "); 
N = Convert.ToInt32(Console.ReadLine());
for (int x = 1; x < N; x++)       
if (x%2==0)        
Console.WriteLine(x);