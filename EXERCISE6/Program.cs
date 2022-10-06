//Напишите программу, которая на вход принимает число и выдает, является ли число
//четным

Console.Clear();
Console.Write("Введите число:");
int number  = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    Console.WriteLine($"{number} чётное число ");
}
else
{
    Console.WriteLine($"{number} не является чётным числом ");
}