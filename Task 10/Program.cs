// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");

string? number = Console.ReadLine();

char secondDigit = number![1];

Console.WriteLine("Вторая цифра числа: " + secondDigit);
