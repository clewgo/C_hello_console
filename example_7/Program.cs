using static System.Console;
Clear();

// Задача 47

Write("Строки: ");
int m = int.Parse(ReadLine());
Write("Столбцы: ");
int n = int.Parse(ReadLine());
double[,] arr = new double[m, n];

fillArr(arr);
printArr(arr);

void fillArr(double[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
 {
  for (int j = 0; j < arr.GetLength(1); j++)
   {
    arr[i, j] = new Random().Next(1, 100);
   }
 }
}

void printArr(double[,] arr)
{
 for (int i = 0; i < arr.GetLength(0); i++)
  {
   for (int j = 0; j < arr.GetLength(1); j++)
    {
     Write($"{arr[i, j]} ");
    }
   Write("\n");
  }
}

WriteLine("---------------------");

// Задача 50

Write("Какое число нужно найти в массиве: ");

int d = int.Parse(ReadLine());
int checkCount = 0;
printArrD(arr,d);

void printArrD(double[,] arr,int d)
{
 for (int i = 0; i < arr.GetLength(0); i++)
  {
   for (int j = 0; j < arr.GetLength(1); j++)
    {
     if (arr[i, j] == d) WriteLine($"Число {d}, найденное в строке {i + 1} и в столбце {j + 1}");
     else checkCount++;
    }
  }
 if (checkCount == arr.Length) WriteLine("Такого числа в массиве нет");
}

WriteLine("---------------------");

// Задача 52

double sum = 0;
double temp = 0;

for (int i = 0; i < arr.GetLength(1); i++)
 {
  sum = 0;
  for (int j = 0; j < arr.GetLength(0); j++)
   {
    sum += arr[j, i];
   }
  temp = sum / arr.GetLength(0);
  WriteLine($"Среднее арифметическое столбца {i + 1} = {Math.Round(temp, 2)}");
 }