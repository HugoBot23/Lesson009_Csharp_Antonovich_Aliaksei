// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//Решение.
//Первое решение задачи.

Console.Clear();

Console.WriteLine("Задайте значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте значение N: ");
int n = int.Parse(Console.ReadLine()!);

int sum = 0;

SumElements(m, n, sum);

void SumElements(int m, int n, int sum)
{
  sum = sum + n;
  if (m < 0)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"{m} не натуральное число");
    Console.ForegroundColor = ConsoleColor.White;
    return;
  }
  if (n < 0)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"{n} не натуральное число");
    Console.ForegroundColor = ConsoleColor.White;
    return;
  }
  if (m > n)
  {
    m = n;
    n = sum;
  }
  else if (n <= m)
  {

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"Сумма элементов= {sum} ");
    Console.ForegroundColor = ConsoleColor.White;
    return;
  }
  SumElements(m, n - 1, sum);
}

//Второе решение задачи.
//Второй вариант решил через тернарный оператор это показывали на лекции, и я подумал что можно попрактиковаться и применить к этой задаче.
Console.WriteLine("\n");

Console.WriteLine("Задайте значение M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте значение N: ");
int N = int.Parse(Console.ReadLine()!);

int summ = 0;

if (m < 0 || n < 0)
{
  Console.ForegroundColor = ConsoleColor.Red;
  Console.Write("Вы ввели не натуральное число: ");
  Console.ForegroundColor = ConsoleColor.White;
}
else
{
  int SumRec(int M, int N, int summ = 0)
  {

    if (M > N)
    {
      M = N;
      N = summ;
    }
    summ = summ + N;

    return N <= M ? N : SumRec(M, N - 1) + summ;
  }

  Console.ForegroundColor = ConsoleColor.Green;
  Console.Write($"Сумма элементов= {SumRec(M, N, summ)} ");
  Console.ForegroundColor = ConsoleColor.White;
}