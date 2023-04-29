// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число:");

int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 5)
{
    Console.WriteLine("Нет");
}
else if (num == 6 || num == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("ERROR");
}