// С клавиатуры вводятся два числа a и b. Найти максимальное из них.
Console.WriteLine("Введите 2 числа");
int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);

if (a > b)
{
    System.Console.WriteLine($"Max={a}");
}
else
{
    if (b > a)
    
    {
        System.Console.WriteLine($"Max={b}"); 
    }

}