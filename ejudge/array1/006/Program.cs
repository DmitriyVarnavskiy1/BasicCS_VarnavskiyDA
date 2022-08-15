//С клавиатуры вводится целое число. Вывести квадрат числа (блок-схема)
/*
System.Console.WriteLine("Введите целое число");
int a=Convert.ToInt32(Console.ReadLine());
int b;
b=a*a;
System.Console.WriteLine($"Квадрат {a} = {b}");
*/

//2.С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго
/*
System.Console.WriteLine("Введите 2 числа");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
    if(a*a==b)
    {
        System.Console.WriteLine($"число {b} является квадратом {a}");
    }
    else 
    {
        if(b*b==a)
        System.Console.WriteLine($"число {a} является квадратом {b}");
        else
        {
            System.Console.WriteLine("Не являются квадратами друг друга");
        }
        
    }
*/

//С клавиатуры вводятся два числа a и b. Найти максимальное из них.
/*
System.Console.WriteLine("Введите 2 числа");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int max=a;
if(b>max)
{
      max=b;
    System.Console.WriteLine($"max={b}");
}
else
{
    System.Console.WriteLine($"max={a}");
}
*/

//Выяснить является ли число чётным.
/*
System.Console.WriteLine("Введите число");
int a=Convert.ToInt32(Console.ReadLine());
    if(a%2==0)
    {
        System.Console.WriteLine($"{a} четное");
    }
    else
    {
        System.Console.WriteLine($"{a} нечетное");
    }
*/

//Вывести на экран числа от -N до N
/*
System.Console.WriteLine("Введите число");
int a=Convert.ToInt32(Console.ReadLine());
int b=-a;
for (int i = b; i <= a; i++)
{
    System.Console.Write($"{i} " );
}
*/

//9.Вывести на экран четные числа от 1 до N
/*
System.Console.WriteLine("Введите число");
int a=Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= a; i=i+2)
{
    System.Console.Write($"{i} " );
}
*/

//10.Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
/*
System.Console.WriteLine("Введите число");
int a=Convert.ToInt32(Console.ReadLine());
int b;
b=a%10;
System.Console.WriteLine(b);
*/


