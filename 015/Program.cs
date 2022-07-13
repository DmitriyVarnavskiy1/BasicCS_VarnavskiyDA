// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.

System.Console.WriteLine("Введите число");
String s = Console.ReadLine();
int Number = Convert.ToInt32(s);
System.Console.WriteLine();
System.Console.WriteLine($"Дано число: {Number}");

if (Number / 100 > 0) System.Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 100 % 10}");
else System.Console.WriteLine($"У числа {Number} нет третьей цифры");

System.Console.WriteLine();