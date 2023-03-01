// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//Решение.

Console.Clear();

Console.WriteLine("Задайте значение m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте значение n: ");
int n = int.Parse(Console.ReadLine()!);

if (m < 0 || n < 0)
{
  Console.ForegroundColor = ConsoleColor.Red;
  Console.Write("Вы ввели отрицательные числа: ");
  Console.ForegroundColor = ConsoleColor.White;
}
else
{
  int result = FunctionAkkerman(m, n);
  Console.ForegroundColor = ConsoleColor.Green;
  Console.Write($"Результат вычисления функции Аккермана (m,n) = {result} ");
  Console.ForegroundColor = ConsoleColor.White;
}

int FunctionAkkerman(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if ((m != 0) && (n == 0))
  {
    return FunctionAkkerman(m - 1, 1);
  }
  else
  {
    return (FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1)));
  }
}
