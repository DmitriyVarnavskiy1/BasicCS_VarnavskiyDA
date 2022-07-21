// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] array = { 2.4, 3.3, 4.0, 5.2, 6.9, 7.4, 8.1, 9.2, 10.3, 20.3 };
double max = array[0];
double min = array[0];

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max) max = array[j];
    if (array[j] < min) min = array[j];
}
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным элементом равна -{max-min} ");
