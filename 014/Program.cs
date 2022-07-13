// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, 
// если нет, вывести остаток от деления a на b

System.Console.WriteLine("Введите числа");

string? s = Console.ReadLine(); 
int Number1 = Convert.ToInt32(s);
s = Console.ReadLine(); 
int Number2 = Convert.ToInt32(s);
int result = 0;

int MultipleNumber()
{
    result = Number1 % Number2;
    return result;
}

MultipleNumber();

System.Console.WriteLine();
if (result == 0) System.Console.WriteLine($"Число {Number1} кратно числу {Number2}");
else
{
    Console.WriteLine($"Число {Number1} не кратно числу {Number2}, остаток от деления равен {Number1 % Number2}");
}
System.Console.WriteLine();