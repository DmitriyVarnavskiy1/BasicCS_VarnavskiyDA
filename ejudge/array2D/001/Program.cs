// Дана таблица чисел, состоящая из N строк по М чисел. Найти наименьшее

string s=Console.ReadLine();
int N=int.Parse(s.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
int M=int.Parse(s.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
int[,] a=new int[N,M];


for (int i=0; i<N;i++)
{
    s=Console.ReadLine();
    string[] ss=s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for(int j=0;j<ss.Length;j++)
            {
                a[i,j] = int.Parse(ss[j]);
            }
}

int mini = 0;
int minj = 0;
int min=a[0,0];

//решение
for(int i=0;i<a.GetLength(0); i++) 
  {
     for(int j=0; j<a.GetLength(1); j++)
        { 
          if(a[i,j]<a[mini,minj])
          {
          mini=i;
          minj=j;
          }
        }
    
}
System.Console.WriteLine(a[mini,minj]);
