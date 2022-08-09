// Показать двумерный массив размером m×n заполненный вещественными случайными числами

int N=5;
int M=4;
double[,] a=new double[N,M];
//Random random=new Random();
PrintArray(a);
FillArray(a);
System.Console.WriteLine();
PrintArray(a);

//Инициализация случайными числами
void FillArray(double[,]a)
{
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i,j]=new Random().NextDouble()*10;
    }
}
}

//Вывод массива на экран
void PrintArray(double[,]a)
{
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        System.Console.Write($"{a[i,j]:F2} ");
    }
    System.Console.WriteLine();
}
}