
string[] arr1 = new string[7] {"YOU", "task", "home", "93939", "=", "+", "44"};
string[] arr2 = new string[arr1.Length];

ArrayNum(arr1, arr2);
PrintArray(arr2);

void ArrayNum(string[] arrone, string[] arrtwo)
{
    int count = 0;
    for (int i = 0; i < arrone.Length; i++)
    {
        if(arrone[i].Length <= 3)
        {
            arrtwo[count] = arrone[i];
            count ++;
        }

    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
