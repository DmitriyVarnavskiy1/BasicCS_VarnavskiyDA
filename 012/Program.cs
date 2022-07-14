// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
System.Console.WriteLine("Введите число от 10 до 99");
string? s = Console.ReadLine();
int a = Convert.ToInt32(s);
int Max = 0;

int MaxDigit()
{
    int DigitOne = a / 10;
    int DigitTwo = a % 10;
    if (DigitOne > DigitTwo) Max = DigitOne;
    else Max = DigitTwo;

    return Max;
}

MaxDigit();
System.Console.WriteLine();
System.Console.WriteLine($"В числе {a} наибольшая цифра {Max}");
System.Console.WriteLine();