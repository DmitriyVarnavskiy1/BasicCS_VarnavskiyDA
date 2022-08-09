// В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j])

int N=5;
int M=4;
int[,] a=new int[N,M];
//Random random=new Random();

FillArray(a);
PrintArray(a);
System.Console.WriteLine();
Processing(a);

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
//обработка массива
void Processing(int[,]a)
{
    for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        if(a[i,j]%2==0)
            a[i,j]=-a[i,j];
        System.Console.Write($"{a[i,j]} ");
    }
    System.Console.WriteLine();
}
}