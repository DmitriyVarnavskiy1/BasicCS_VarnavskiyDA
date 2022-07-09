// See https://aka.ms/new-console-template for more information



double a=3.14;
double b;
string? s=Console.ReadLine();//Ввод данных
a=Convert.ToDouble(s);

b=a*a;//обработка данных

//Вывод результата
System.Console.WriteLine("{0}^2={1}",a,b); //строка форматирования
System.Console.WriteLine($"{a}^2={b}"); //строка интерполяции


/*
String? s;
s=Console.ReadLine();
Console.WhriteLine(s);
*/