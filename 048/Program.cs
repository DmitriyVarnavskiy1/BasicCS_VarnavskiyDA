﻿// Показать двумерный массив размером m×n заполненный целыми случайными числами

int N=5;
int M=4;
int[,] a=new int[N,M];
//Random random=new Random();
PrintArray(a);
FillArray(a);
System.Console.WriteLine();
PrintArray(a);

//Инициализация случайными числами
void FillArray(int[,]a)
{
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i,j]=new Random().Next(1,11);
    }
}
}

//Вывод массива на экран
void PrintArray(int[,]a)
{
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        System.Console.Write($"{a[i,j]} ");
    }
    System.Console.WriteLine();
}
}