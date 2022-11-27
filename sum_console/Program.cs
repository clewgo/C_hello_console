// Задача 2

int a1 = 5;
int b1 = 7;

int a2 = 2;
int b2 = 10;

int a3 = -9;
int b3 = -3;

int max1 = a1;
int min1 = a1;

int max2 = a2;
int min2 = a2;

int max3 = a3;
int min3 = a3;

if (a1 > max1) max1 = a1; else min1 = a1;
if (b1 > max1) max1 = b1; else min1 = b1;

if (a2 > max2) max2 = a2; else min2 = a2;
if (b2 > max2) max2 = b2; else min2 = b2;

if (a3 > max3) max3 = a3; else min3 = a3;
if (b3 > max3) max3 = b3; else min3 = b3;

Console.WriteLine($"max1 = {max1}, min1 = {min1}, max2 = {max2}, min2 = {min2}, max3 = {max3}, min3 = {min3}");

// Задача 4

a1 = 2;
b1 = 3;
int c1 = 7;

a2 = 44;
b2 = 5;
int c2 = 78;

a3 = 22;
b3 = 3;
int c3 = 9;

max1 = a1;
max2 = a2;
max3 = a3;

if (a1 > max1) max1 = a1;
if (b1 > max1) max1 = b1;
if (c1 > max1) max1 = c1;

if (a2 > max2) max2 = a2;
if (b2 > max2) max2 = b2;
if (c2 > max2) max2 = c2;

if (a3 > max3) max3 = a3;
if (b3 > max3) max3 = b3;
if (c3 > max3) max3 = c3;

Console.WriteLine($"max1 = {max1}, max2 = {max2}, max3 = {max3}");

// Задача 6

int n = 4;
int x = n % 2;
if (x == 0) Console.WriteLine($"{n} -> Да");
else Console.WriteLine($"{n} -> Нет");

n = -3;
x = n % 2;
if (x == 0) Console.WriteLine($"{n} -> Да");
else Console.WriteLine($"{n} -> Нет");

n = 7;
x = n % 2;
if (x == 0) Console.WriteLine($"{n} -> Да");
else Console.WriteLine($"{n} -> Нет");

// Задача 8

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 2; i <= number; i++)
{
 if (i % 2 == 0) Console.WriteLine(i);
};