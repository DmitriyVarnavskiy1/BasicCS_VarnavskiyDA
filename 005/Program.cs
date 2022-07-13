// С клавиатуры вводятся три числа. Найти максимальное из трех чисел
Console.WriteLine("Введите три числа");
int a,b,c;
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
s = Console.ReadLine();
b = Convert.ToInt32(s);
s = Console.ReadLine();
c = Convert.ToInt32(s);

int max=a;
if (b>max)max=b;
if (c>max)max=c;
System.Console.WriteLine($"Max = {max}");
