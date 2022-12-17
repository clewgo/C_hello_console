using static System.Console;
Clear();

// Задача 64

Write("Задайте значение N: ");
int n = int.Parse(ReadLine()!);

string PrintN(int n)
{
 if (n == 1) return n.ToString();
 return (n + " " + PrintN(n - 1));
}
Write(PrintN(n));
WriteLine();

WriteLine("---------------------");

// Задача 66

Write("Задайте значение от: ");
int mm = int.Parse(ReadLine()!);

Write("Задайте значение до: ");
int nn = int.Parse(ReadLine()!);

int Summ(int start, int end)
{
 if (start == end) return start;
 if (start > end) return start + Summ(end, start - 1);
 return end + Summ(start, end - 1);
}

WriteLine($"Сумма всех элементов от {mm} до {nn} = {Summ(mm, nn)}");

WriteLine("---------------------");

// Задача 68

Write("Задайте значение M: ");
int mmm = int.Parse(ReadLine()!);

Write("Задайте значение N: ");
int nnn = int.Parse(ReadLine()!);

int Ackerman(int mmm, int nnn)
{
  if (mmm == 0) return nnn + 1;
  else if (nnn == 0) return Ackerman(mmm - 1, 1);
  else return Ackerman(mmm - 1, Ackerman(mmm, nnn - 1));
}

WriteLine($"A(M,N) = {Ackerman(mmm,nnn)}");