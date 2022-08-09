//Даны две квадратных таблицы чисел. Требуется построить третью,
//каждый элемент которой равен сумме элементов, стоящих на том же месте
//в 1-й и 2-й таблицах.

int N=4;
int M=4;
int[,] a=new int[N,M];
int[,] b=new int[N,M];
int[,] c=new int[N,M];
//Random random=new Random();
//PrintArray(a);
FillArray(a);
System.Console.WriteLine("1 таблица");
System.Console.WriteLine();
PrintArray(a);
System.Console.WriteLine();
System.Console.WriteLine("2 таблица");
System.Console.WriteLine();
FillArray(b);
PrintArray(b);
System.Console.WriteLine();
System.Console.WriteLine("3 таблица");
System.Console.WriteLine();
SumArray(c);
PrintArray(c);


void SumArray(int[,]c)
{
for (int i = 0; i < c.GetLength(0); i++)
{
    for (int j = 0; j < c.GetLength(1); j++)
    {
        c[i,j]=a[i,j]+b[i,j];
    }
}
}
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