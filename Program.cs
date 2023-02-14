// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);
int max, min;
if (num1 > num2)
{
    max = num1;
    min = num2;
}
else
{
    max = num1;
    min = num2;
}
Console.WriteLine($"max + {max} > min = {min}");