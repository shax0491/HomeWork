﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Пожалуйста введите 2 числа,");
Console.WriteLine("чтобы узнать какое большее, а какое меньшее.");
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Число " + num1 + " большее");
    Console.Write("Число " + num2 + " меньшее");
}
else if (num1 == num2)
{
    Console.WriteLine("Число " + num1 + " равно числу " + num2);
}
else
{
    Console.WriteLine("Число " + num2 + " большее");
    Console.Write("Число " + num1 + " меньшее");
}