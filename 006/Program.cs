//Написать программу вычисления значения функции y = sin(a). (Класс Math)

/*
double x,y;
x = 3.14;
x=Math.PI;
y=Math.Sin(x);
System.Console.WriteLine($"sin({x})={y}");

double r=1.0/3+1.0/3;
System.Console.WriteLine(r);
*/

// Тип возвращаемого значения Имя_функции(аргументы функции)
double Sin(double x) //метод(функция)
{
    return Math.Sin(x);
}

double Sum(double a, double b)
{
    return a+b;
}

void Pause() //метод
{
    System.Console.WriteLine($"Press any key");
}


double y=Sin(3.14);
System.Console.WriteLine(y);
Pause();