﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//Пример:4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 2 == 0)
{  
Console.WriteLine("Четное");
}
    else
    {
    Console.WriteLine ("не четное");
    
    }
