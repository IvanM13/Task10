/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число: ");
string num = Convert.ToString(Console.ReadLine());

if (num.Length >= 3)
    Console.WriteLine(num[1]);

else
    Console.WriteLine("Число не трехзначное");
