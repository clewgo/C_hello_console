using static System.Console;
Clear();

// Задача 25

WriteLine("Введите 1-е число:");
int a = Convert.ToInt32(ReadLine());

WriteLine("Введите 2-е число:");
int b = Convert.ToInt32(ReadLine());

double st = Math.Pow(a, b);
WriteLine($"{a} в {b}-й степени = {st}");

WriteLine("---------------------");

// Задача 27

WriteLine("Введите число:");
int x = Convert.ToInt32(ReadLine());
if (x == 0) Write($"{x}");

int sum = 0;
while (x != 0)
{
 if (x / 10 <= 0) Write($"{x % 10}");
 else Write($"{x % 10} + ");

 sum += x % 10;
 x /= 10;
}
Write($" = {sum}");

WriteLine();
WriteLine("---------------------");

// Задача 29

int len = new Random().Next(1, 8);
int[] arr = new int[len];

if (len > 1) Write($"Рандомный массив из {len} элементов: [ ");
else Write($"Рандомный массив из {len} элемента: [ ");

for (int i = 0; i < len; i++)
{
 arr[i] = new Random().Next(1, 100);
 if (i != len-1) Write($"{arr[i]}, ");
 else Write($"{arr[i]} ]");
}