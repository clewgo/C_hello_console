using static System.Console; // Теперь не нужно писать 'Console.'
Clear();

/* Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "саша"){
 Console.Write("Ура, это Саша!");
} else {
 Console.Write("Привет, ");
 Console.Write(username);
} */

//-----------------------------------------------

/* int xa = 40, ya = 1, 
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;

while (count < 10000){
 int what = new Random().Next(0,3);
 if (what == 0) 
 {
  x = (x+xa)/2; 
  y = (y+ya)/2;
 }
 if (what == 1) 
 {
  x = (x+xb)/2; 
  y = (y+yb)/2;
 }
 if (what == 2) 
 {
  x = (x+xc)/2; 
  y = (y+yc)/2;
 }

 Console.SetCursorPosition(x, y);
 Console.WriteLine("+");
 count++;
} */

//-----------------------------------------------

/*
int Max(int arg1, int arg2, int arg3)
{
 int result = arg1;
 if (arg2 > result) result = arg2;
 if (arg3 > result) result = arg3;
 return result;
};

int[] arr = {15, 21, 33, 45, 89, 91, 8, 15, 29};

int max = Max(
 Max(arr[0], arr[1], arr[2]), 
 Max(arr[3], arr[4], arr[5]), 
 Max(arr[6], arr[7], arr[8]));

Console.WriteLine(max);
*/

//-----------------------------------------------

/*
void fillarr(int[] coll1)
{
 int n = coll1.Length;
 int i = 0;
 while (i < n){
  coll1[i] = new Random().Next(1, 10); 
  i++;
 }
}

void printarr(int[] coll2)
{
 int len = coll2.Length;
 int pos = 0;
 while (pos < len){
  Console.WriteLine(coll2[pos]);
  pos++;
 }
}

int indexof(int[] coll, int find)
{
 int count = coll.Length;
 int index = 0;
 int position = -1;

 while (index < count){
  if (coll[index] == find)
  {
   position = index; 
   break;
  }
  index++;
 }
 return position;
}

int[] arr = new int[10];

fillarr(arr);
printarr(arr);
Console.WriteLine("----------------");

int posof = indexof(arr, 5);
Console.WriteLine(posof);
*/

//-----------------------------------------------

// Методы
// 1 Вид:

/*
void func1()
{
 WriteLine("Привет, мир!");
}
func1();


// 2 Вид:

void func2(string msg)
{
 WriteLine(msg);
}
//func2("Сообщение");

void func2x(string msg, int count)
{
 int i = 0;
 while (i < count)
 {
  WriteLine(msg + i);
  i++;
 }
}
func2x(msg: "Сообщение", count: 3);


// 3 Вид:

int func3()
{
 return DateTime.Now.Year;
}
int year = func3();
WriteLine(year);


// 4 Вид:

string func4(int count, string x)
{
 
 string res = ""; // "" или String.Empty;
 for (int i = 0; i < count; i++)
 {
  res = res + x;
 }
 return res;
}

string res = func4(5, "Текст");
WriteLine(res);
*/

//-----------------------------------------------

// Цикл в цикле:

/*
for (int i = 2; i <= 10; i++)
{
 for (int x = 2; x <= 10; x++)
 {
  WriteLine($"{i} * {x} = {i*x}");
 }
 WriteLine();
}
*/

//-----------------------------------------------

/*
string text = "Быть знаменитым некрасиво."
+ "Не это подымает ввысь."
+ "Не надо заводить архива,"
+ "Над рукописями трястись."
+ "Цель творчества - самоотдача,"
+ "А не шумиха, не успех."
+ "Позорно, ничего не знача,"
+ "Быть притчей на устах у всех.";

string replace(string text, char oldval, char newval)
{
 string res = "";
 int len = text.Length;
 for (int i = 0; i < len; i++)
 {
  if (text[i] == oldval) res = res + $"{newval}";
  else res = res + $"{text[i]}";
 }
 return res;
};

string nextext = replace(text, ' ', '|');

WriteLine(nextext);
WriteLine();

nextext = replace(nextext, 'к', 'К');

WriteLine(nextext);
*/

//-----------------------------------------------

// Сортировка чисел

/*
int[] arr = {2, 1, 4, 3, 8, 6, 5, 7, 1, 1};

void printarr(int[] arrx)
{
 for (int i = 0; i < arrx.Length; i++)
 {
  Write($"{arrx[i]} ");
 }
 WriteLine();
}

void sort(int[] arrx)
{
 for (int i = 0; i < arrx.Length - 1; i++)
 {
  int minpos = i;
  for (int x = i + 1; x < arrx.Length; x++)
  {
    if (arrx[x] < arrx[minpos]) minpos = x;
  }
  int temp = arrx[i];
  arrx[i] = arrx[minpos];
  arrx[minpos] = temp;
 }
}

printarr(arr);
sort(arr);
printarr(arr);
*/

//-----------------------------------------------

