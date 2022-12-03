using static System.Console;
Clear();

// Задача 19

WriteLine("Введите пятизначное число:");
string x = ReadLine();

int y = 0;
for (int i = 0; i < x.Length; i++)
{
 if (x[i] == x[x.Length - i - 1]) y++;
}

if (y == x.Length) WriteLine($"{x} — палиндром");
else WriteLine($"{x} — не палиндром");

WriteLine("---------------------");

// Задача 21

WriteLine("Координата aX");
int aX = int.Parse(ReadLine());
WriteLine("Координата aY");
int aY = int.Parse(ReadLine());
WriteLine("Координата aZ");
int aZ = int.Parse(ReadLine());

WriteLine("Координата bX");
int bX = int.Parse(ReadLine());
WriteLine("Координата bY");
int bY = int.Parse(ReadLine());
WriteLine("Координата bZ");
int bZ = int.Parse(ReadLine());

double w = Math.Sqrt((bX - aX) * (bX - aX) + (bY - aY) * (bY - aY) + (bZ - aZ) * (bZ - aZ));
WriteLine($"Расстояние между этими точками равно: {Math.Round(w, 2)}");

WriteLine("---------------------");

// Задача 23

WriteLine("Введите N-число:");
int n = Convert.ToInt32(ReadLine());

for (int i = 1; i <= n; i++)
{
  if (i != n) Write(Math.Pow(i, 3) + ", ");
  else Write(Math.Pow(i, 3));
}