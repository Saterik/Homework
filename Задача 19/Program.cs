﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}
Console.WriteLine("Введите пятизначное число:");
string number = Console.ReadLine();
if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Введи пятизначное число");