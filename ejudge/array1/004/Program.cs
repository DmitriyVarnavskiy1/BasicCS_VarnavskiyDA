/* 
Вводится число N, а затем - N чисел.
Определить, сколько среди них пар одинаковых чисел.
100>=N>=2

Пример входного файла:
5
1 3 2 2 3

Пример выходного файла:
2
*/
using System;

int n=Convert.ToInt32(Console.ReadLine());
string s=Console.ReadLine();


string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss,Convert.ToInt32);
int k=0;
    for (int i = 0; i < a.Length; i++)
    {
     for (int j=i+i; j < a.Length; j++)
     {
       if(a[i]==a[j])
       k++; 
     } 
    }
    System.Console.WriteLine(k);
    