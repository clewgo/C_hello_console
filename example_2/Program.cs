using static System.Console;
Clear();

// Задача 10 и 13

WriteLine("Введите трёхзначное число:" );
String x = ReadLine();

if (x.Length >= 3) WriteLine($"Вторая цифра числа: {x[1]}");
else WriteLine("Не трехзначное число!");

if (x.Length >= 3) WriteLine($"Третья цифра числа: {x[2]}");
else WriteLine("Третьей цифры нет!");

WriteLine("---------------------");

// Задача 15

 WriteLine("Введите число от 1 до 7, обозначающее день недели:");
 int n = Convert.ToInt32(ReadLine());

if (n == 7 || n == 6) WriteLine("Сегодня выходной");
else if (n > 7 || n < 1 ) WriteLine("Вы указали не верное число");
else WriteLine("Сегодня рабочий день");