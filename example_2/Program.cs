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

