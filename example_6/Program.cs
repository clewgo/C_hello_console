using static System.Console;
Clear();

// Задача 41

int count = 5;
int num;
int sum = 0;

for (int i = 1; i <= count; i++) 
{
 Write($"Введите любое число #{i}: ");
 num = int.Parse(ReadLine());

 if (num > 0) sum++;
 if (i == count) WriteLine("Положительных чисел = " + sum);
}

WriteLine();
WriteLine("---------------------");

// Задача 43

Write("Введите значение b1: ");
double b1 = double.Parse(ReadLine());
Write("Введите значение k1: ");
double k1 = double.Parse(ReadLine());
Write("Введите значение b2: ");
double b2 = double.Parse(ReadLine());
Write("Введите значение k2: ");
double k2 = double.Parse(ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

if (k1 != k2) WriteLine($"Пересечение прямых по координатам: ({x}; {y})");
else WriteLine("Нет пересечения");