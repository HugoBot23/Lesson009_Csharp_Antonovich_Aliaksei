// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//Решение.

Console.Clear();

Console.WriteLine("Задайте значение N: ");
int n = int.Parse(Console.ReadLine()!);

NaturalNumber(n);

void NaturalNumber(int n)
{
  if (n < 0)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"{n} не натуральное число");
    Console.ForegroundColor = ConsoleColor.White;
    return;
  }
  else if (n == 0) return;
  {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{n}, ");
    NaturalNumber(n - 1);
    Console.ForegroundColor = ConsoleColor.White;
  }
}