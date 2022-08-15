// Показать натуральные числа от 1 до N, N задано
void Numbers(int i, int N)
{
    System.Console.WriteLine(i);
    if(i<N)
    {
        Numbers(i+1,N);
    }
}

Numbers(1,10);
