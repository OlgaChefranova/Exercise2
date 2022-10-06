//Напишите программу, которая на вход принимает число(N), а на выходе показывает все 
// чётные числа от 1 до N

Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int x = 1;
if (x<N)
{
    x % 2 == 0;
    x ++;
    Console.WriteLine($"Четное число {x}");
}