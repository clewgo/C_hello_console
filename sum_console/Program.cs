int a = 5;
int b = 7;
int max = a;
int min = a;

if (a > max) max = a; else min = a;

if (b > max) max = b; else min = b;

Console.Write("max = ");
Console.Write(max);

Console.Write(", min = ");
Console.Write(min);