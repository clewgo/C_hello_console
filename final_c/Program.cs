using static System.Console;
Clear();

string[] arr1 = new string[6] {"Яблоко", "Дом", "Вода", "Мир", "Кот", "Робот"};
string[] arr2 = new string[arr1.Length];
void arr_f(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void printArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]} ");
    }
    WriteLine();
}
arr_f(arr1, arr2);
printArr(arr2);