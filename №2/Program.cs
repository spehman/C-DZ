﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 ->  max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB)
{
Console.WriteLine("max=" + numberA);
Console.WriteLine("min=" + numberB);
}
else {
    Console.WriteLine("max=" + numberB);
Console.WriteLine("min=" + numberA);
}
