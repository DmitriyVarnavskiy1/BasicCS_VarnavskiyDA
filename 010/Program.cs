// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
Console.WriteLine("Введите число");
string? s = Console.ReadLine();
int a = Convert.ToInt32(s);

int result= (a % 10);
 {
    System.Console.WriteLine($"{result}");
 }
