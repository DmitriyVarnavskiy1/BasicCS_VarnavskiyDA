// See https://aka.ms/new-console-template for more information


//С клавиатуры вводится целое число. Вывести квадрат числа
double a;
double b;
string? s=Console.ReadLine();//Ввод данных
a=Convert.ToDouble(s);

b=a*a;//обработка данных

//Вывод результата
System.Console.WriteLine("{0}^2={1}",a,b); //строка форматирования
System.Console.WriteLine($"{a}^2={b}"); //строка интерполяции


/*
String? s;//объявили переменную
s=Console.ReadLine();//присвоили переменную
Console.WhriteLine(s);
*/