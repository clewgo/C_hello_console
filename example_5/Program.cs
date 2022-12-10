using static System.Console;
Clear();

// Задача 34

Write("Массив: [ ");

int count = 0;
int[] arr = new int[5];

for (int i = 0; i < arr.Length; i++)
{
 arr[i] = new Random().Next(100, 1000);

 if (i != arr.Length-1) Write(arr[i] + ", ");
 else Write(arr[i] + " ] --> ");

 if (arr[i] % 2 == 0) count++;
}

Write("Количество чётных чисел = " + count);

WriteLine();
WriteLine("---------------------");

// Задача 36

Write("Массив: [ ");

count = 0;

for (int i = 0; i < arr.Length; i++)
{
 arr[i] = new Random().Next(-100, 100);

 if (i != arr.Length-1) Write(arr[i] + ", ");
 else Write(arr[i] + " ] --> ");

 if (i % 2 != 0) count += arr[i];
}

Write("Сумма элементов, стоящих на нечётных позициях = " + count);

WriteLine();
WriteLine("---------------------");

// Задача 38

Write("Массив: [ ");

int countMin = 0;
int countMax = 0;

for (int i = 0; i < arr.Length; i++)
{
 arr[i] = new Random().Next(1, 100);

 if (i != arr.Length-1) Write(arr[i] + ", ");
 else Write(arr[i] + " ] --> ");

 if (i == 0) countMin = countMax = arr[0];

 if (arr[i] < countMin) countMin = arr[i];
 if (arr[i] > countMax) countMax = arr[i];
}

Write($"Разница между максимальным и минимальным = {countMax - countMin}");