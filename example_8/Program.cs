using static System.Console;
Clear();

// Задача 54

double[,] arr = new double[3, 4];

fillArr(arr);

void fillArr(double[,] arr)
{
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
}

WriteLine("|||||||");

sortArr(arr);
printArr(arr);

void sortArr(double[,] arr)
{
 for (int i = 0; i < arr.GetLength(0); i++)
 {
  for (int j = 0; j < arr.GetLength(1); j++)
  {
   for (int x = 0; x < arr.GetLength(1) - 1; x++)
   {
    if (arr[i, x] < arr[i, x + 1])
    {
     double temp = arr[i, x + 1];
     arr[i, x + 1] = arr[i, x];
     arr[i, x] = temp;
    }
   }
  }
 }
}

void printArr(double[,] arr)
{
 for (int i = 0; i < arr.GetLength(0); i++)
 {
  for (int j = 0; j < arr.GetLength(1); j++)
  {
   Write(arr[i, j] + " ");
  }
  WriteLine();
 }
}

WriteLine("---------------------");

// Задача 56

