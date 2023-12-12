// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int M = ReadInt("Введите значение M: ");
int N = ReadInt("Введите значение N: ");

int temp = M;

if (M > N) 
{
  M = N; 
  N = temp;
}

void PrintSumm(int M, int N, int summ)
{
  summ = summ + N;
  if (N <= M)
  {
    Console.Write($"Сумма элементов = {summ} ");
    return;
  }
  PrintSumm(M, N - 1, summ);
}

PrintSumm(M, N, temp = 0);


