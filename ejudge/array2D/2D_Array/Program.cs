// Создать массив N*M и заполнить его случайными числами от 1 до 10.
//Вывести массив на экран

int N=5;
int M=4;
int[,] a=new int[N,M];
//Random random=new Random();
//Инициализация случайными числами
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i,j]=new Random().Next(1,11);
    }
}
//Вывод массива на экран
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        System.Console.Write($"{a[i,j]} ");
    }
    System.Console.WriteLine();
}
