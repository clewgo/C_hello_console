using static System.Console;
Clear();

// Задача 54

double[,] arr = new double[3, 4];

for (int i = 0; i < arr.GetLength(0); i++)
 {
  for (int j = 0; j < arr.GetLength(1); j++)
   {
    arr[i, j] = new Random().Next(1, 10);
   }
 }

for (int i = 0; i < arr.GetLength(0); i++)
 {
  for (int j = 0; j < arr.GetLength(1); j++)
   {
    Write($"{arr[i, j]} ");
   }
  Write("\n");
 }

WriteLine("|");
WriteLine("V");


WriteLine("---------------------");

