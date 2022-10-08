//Программа на вход принимает три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Для сравнения трёх чисел введите первое число:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число:");
int c = int.Parse(Console.ReadLine()!);

if (a>b && a>c)
{
    Console.WriteLine($"максимальное значение {a}");
}
  else if (b>a && b>c)
 {
    Console.WriteLine($"максимальное значение {b}");
 }
    else if (c>a && c>b)
   {
    Console.WriteLine($"максимальное значение {c}");
   }
       else if (a==b && a==c && b==c)
      {
        Console.WriteLine($"Все числа имеют максимальное значение {a}");
      }
          else if (a==b)
          {
             Console.WriteLine($"Первое и второе число имеют максимальное значение - {a}");
          }
             else if (a==c)
               {
                Console.WriteLine($"Первое и третье число имеют максимальное значение - {a}");
               }
                else if (b==c)
                 {
                    Console.WriteLine($"Второе и третье число имеют максимальное значение - {b}");
                 }
