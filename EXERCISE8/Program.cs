//Напишите программу, которая на вход принимает число(N), а на выходе показывает все 
// чётные числа от 1 до N

Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

while(N>1)
{
    
   if( N % 2 == 0)
{
    Console.WriteLine($"Чётное число {N}");
}
    N--;
   
}
