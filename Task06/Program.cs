﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

//using Internal;

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Да");//Console.WriteLine("Введено четное число");
}
else
{
   Console.WriteLine("Нет");// Console.WriteLine("Введено нечётное число");
}
