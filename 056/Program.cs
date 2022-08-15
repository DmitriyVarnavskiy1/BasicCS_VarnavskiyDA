// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

System.Console.WriteLine("Задайте размер матрицы, где первая цифра число строк, а вторая число столбцов");
string s=Console.ReadLine();
int N=int.Parse(s.Split(' ')[0]);
int M=int.Parse(s.Split(' ')[1]);
System.Console.WriteLine("А теперь заполните матрицу числами через пробел");
int[,] a=new int[N,M];
for(int i=0;i<N;i++)
{

    s=Console.ReadLine();
    string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
       for(int j=0;j<ss.Length;j++)
        a[i,j]=int.Parse(ss[j]);
}

Print(a);
int min=0;
int imin=0;
for(int i=0;i<a.GetLength(0);i++)
{
    int sum=0;
    for(int j=0;j<a.GetLength(1);j++)
        sum=sum+a[i,j];
    if (sum<min)
    {
        min=sum;
        imin=i;
    }


}
System.Console.Write("Строка с наименьшей суммой эллементов:");
System.Console.Write(imin+1);

//Вывод массива на экран
void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j],4} ");
            System.Console.WriteLine();
    }
}