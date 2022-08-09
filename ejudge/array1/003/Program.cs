/* 
Вводится сначала число N, а затем N чисел. Выведите эти N чисел в следующем порядке:
 сначала выводятся числа, стоящие на нечетных местах, а затем - 
 стоящие на четных местах. Нумерация элементов начинается с 1. Входные данные
Вводится число N (100>N>0), а затем N чисел из диапазона Integer.

Примеры
Входные данные
7
2 4 1 3 5 3 1
Результат работы
4 3 3 2 1 5 1
*/

using System;
int n=int.Parse(Console.ReadLine());
string s=Console.ReadLine();
string[]ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[]a=Array.ConvertAll<string,int>(ss,int.Parse);

for (int i = 0; i < a.Length; i=i+2)
{
 System.Console.Write($"{a[i]} ");   
}
for (int i = 1; i < a.Length; i=i+2)
{
 System.Console.Write($"{a[i]} ");   
}



/*
// Диагональки
/*
В квадратной таблице NxN подсчитать суммы чисел, стоящих на диагоналях.

Входные данные
Во входном файле содержится число N (100>=N>=1), а затем матрица NxN.
Элементы матрицы - числа из диапазона integer.

Выходные данные
В выходной файл выдать сначала сумму чисел на главной,
а затем - на побочной диагонали.


int N=3;
int M=3;

int [,] a;//описываем массив

a=new int [N,M];//создаем массив
//Инициализация случайными числами
Random random=new Random();//Создали объект типа Random

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) 
    {
        a[i,j]=random.Next(1,5);
    }
}


//Вывод массива на экран
for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]} ");
         System.Console.WriteLine();
}

int sum1=0;
int sum2=0;

for (int i = 0; i < a.GetLength(0); i++)
{
    sum1=sum1+a[i,i];
    sum2=sum2+a[i,N-i-1];   
        
   
    
}
System.Console.WriteLine(sum1);
System.Console.WriteLine(sum2);
*/




/*
1 задача
using System;
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
*/

/*
int N=3;
int M=3;

int[,] a;//описываем массив

a=new int[N,M];//создаем массив
//Инициализация случайными числами
Random random=new Random();//Создали объект типа Random

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) 
    {
        a[i,j]=random.Next(0,2);
    }
}

//Вывод массива на экран
for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]} ");
         System.Console.WriteLine();
}
// Ищем нолики
bool flag = false;
for(int i=0;i<a.GetLength(0);i++)
{    
    for(int j=0;j<a.GetLength(1);j++) 
    {
        if (a[i,j]==0)
        {
        System.Console.Write($"{i} " + $"{j} ");
        flag=true;
        break;
        }
    }
if (flag){break;} 
}
5 задача
*/