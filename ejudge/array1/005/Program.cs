using System;

int n=int.Parse(Console.ReadLine());
string s=Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss, int.Parse);
int result = 0;
for(int i = 0; i< a.Length - 1; i++)
{
    if (a[i]==a[i+1])
    result++;
}
Console.Write(result);
