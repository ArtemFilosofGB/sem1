﻿// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
//using Internal;
int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thrdDigit = num % 10;
    return firstDigit * 10 + thrdDigit;
}

int number = new Random().Next(100, 1000);//999+1
Console.WriteLine(number);
// int firstDigit = number / 100;
// int thrdDigit = number % 10;
// int result = firstDigit * 10 + thrdDigit;
int result = DeleteSecondDigit(number);
Console.WriteLine(result);