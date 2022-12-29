using static System.Console;
Clear();

// Задача 54 //

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

fillArr(arr);

double x = 0;
double y = 0;
double z = 0;

for (int i = 0; i < arr.GetLength(0); i++)
 {
  x = 0;
  for (int j = 0; j <= arr.GetLength(0); j++)
   {
    x += arr[i, j];
   }
  if (x < z || i == 0) 
  {
   z = x;
   y = i + 1;
  }
 }

 WriteLine($"С наименьшей суммой элементов: {y} строка");

WriteLine("---------------------");

// Задача 58

int[,] arr1 = new int[2, 2];
CreateArr(arr1);
WriteLine($"Первая матрица:");
WriteArr(arr1);

int[,] arr2 = new int[2, 2];
CreateArr(arr2);
WriteLine($"Вторая матрица:");
WriteArr(arr2);

int[,] result = new int[2, 2];

MultiplyMatrix(arr1, arr2, result);
WriteLine($"Матрица произведения:");
WriteArr(result);

void MultiplyMatrix(int[,] arr1, int[,] arr2, int[,] result)
{
 for (int i = 0; i < result.GetLength(0); i++)
 {
  for (int j = 0; j < result.GetLength(1); j++)
  {
   int sum = 0;
   for (int k = 0; k < arr1.GetLength(1); k++)
   {
    sum += arr1[i, k] * arr2[k, j];
   }
   result[i, j] = sum;
  }
 }
}

void WriteArr(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
 {
  for (int j = 0; j < array.GetLength(1); j++)
  {
   Write(array[i, j] + " ");
  }
  WriteLine();
 }
}

void CreateArr(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
 {
  for (int j = 0; j < array.GetLength(1); j++)
  {
   array[i, j] = new Random().Next(1, 10);
  }
 }
}

WriteLine("---------------------");

// Задача 60

int[,,] arrX = GetArr(new int[] { 2, 2, 2 }, 10, 99);
PrintX(arrX);

int[,,] GetArr(int[] size, int min, int max)
{
 int[,,] resultX = new int[size[0], size[1], size[2]];
 for (int i = 0; i < resultX.GetLength(0); i++)
 {
  for (int j = 0; j < resultX.GetLength(1); j++)
  {
   int k = 0;
   while (k < resultX.GetLength(2))
   {
    int element = new Random().Next(min, max + 1);
    if (FindEl(resultX, element)) continue;
    resultX[i, j, k] = element;
    k++;
   }
  }
 }
 return resultX;
}

bool FindEl(int[,,] arrX, int el)
{
 for (int i = 0; i < arrX.GetLength(0); i++)
 {
  for (int j = 0; j < arrX.GetLength(1); j++)
  {
   for (int k = 0; k < arrX.GetLength(2); k++)
   {
    if (arrX[i, j, k] == el) return true;
   }
  }
 }
 return false;
}

void PrintX(int[,,] arrX)
{
 for (int i = 0; i < arrX.GetLength(0); i++)
 {
  for (int j = 0; j < arrX.GetLength(1); j++)
  {
   for (int k = 0; k < arrX.GetLength(2); k++)
   {
    Console.Write($"{arrX[i, j, k]} ({i},{j},{k}) ");
   }
   Console.WriteLine();
  }
 }
}

WriteLine("---------------------");

// Задача 62

int[,] spiral = new int[4, 4];

int temp1 = 1;
int r = 0;
int m = 0;

while (temp1 <= spiral.GetLength(0) * spiral.GetLength(1))
{
 spiral[r, m] = temp1;
 temp1++;
 if (r <= m + 1 && r + m < spiral.GetLength(1) - 1)
  m++;
 else if (r < m && r + m >= spiral.GetLength(0) - 1)
  r++;
 else if (r >= m && r + m > spiral.GetLength(1) - 1)
  m--;
 else
  r--;
}

WriteArray(spiral);

void WriteArray(int[,] arrY)
{
 for (int i = 0; i < arrY.GetLength(0); i++)
 {
  for (int j = 0; j < arrY.GetLength(1); j++)
  {
   if (arrY[i, j] / 10 <= 0) Write($"0{arrY[i, j]} ");
   else Write($"{arrY[i, j]} ");
  }
  WriteLine();
 }
}