//С клавиатуры вводится цеrлое число. Вывести квадрат числа
int a;
int b;
string? s=Console.ReadLine();//Ввод данных
a=Convert.ToInt32(s);

b=a*a;//обработка данных

//Вывод результата
// System.Console.WriteLine("{0}^2={1}",a,b); //строка форматирования
System.Console.WriteLine($"{a}^2={b}"); //строка интерполяции


/*
String? s;//объявили переменную
s=Console.ReadLine();//присвоили переменную
Console.WhriteLine(s);
*/