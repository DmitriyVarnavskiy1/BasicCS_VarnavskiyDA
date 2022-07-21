//39. Найти сумму чисел одномерного массива стоящих на нечетной позиции

//инициализация массива
int N=9;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(1,10);

//вывод массива (до обработки)
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");

//решение задачи
int sum=0;
for(int i=0;i<a.Length;i++)
    if (a[i]%2 !=0)
        sum=sum+a[i];
System.Console.WriteLine();
System.Console.WriteLine($"{sum}");    