// Показать кубы чисел, заканчивающихся на четную цифру
System.Console.WriteLine();

int N = new Random().Next(1, 30);
System.Console.WriteLine($"N = {N}");

int number = 1;
System.Console.WriteLine("By While");
while (number <= N)
{
    int cube = number * number * number;
    if (cube % 2 == 0) System.Console.Write(cube + " ");
    number++;
}
System.Console.WriteLine();

