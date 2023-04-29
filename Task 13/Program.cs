//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите трёхзначное число: ");
string? num = Console.ReadLine();
if (num.Length != 3)
{
    Console.WriteLine("Error");
}
char secondDigit = num![2];

Console.WriteLine("Третья цифра числа: " + secondDigit);