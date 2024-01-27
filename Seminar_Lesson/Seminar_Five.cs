// Задача 31
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

// int[] Intarray(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }
// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write(arr[i] + ",");
//         else Console.Write(arr[i]);
//     }
//     Console.WriteLine("]");
// }


// int GetSamPositiveElem(int[] arr)
// { 
//     int sum = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] > 0) sum += arr[i];
//     }
//     return sum;
// }

// int GetSamNegativElem(int[] arr)
// { 
//     int sum = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] < 0) sum += arr[i];
//     }
//     return sum;
// }
// int[] array = Intarray(12, -9, 9);
// PrintArray(array);
// int samPositiveElem = GetSamPositiveElem(array);
// int samNegativElem = GetSamNegativElem(array);
// Console.WriteLine($"Сумма положительных элкментов = {samPositiveElem} ");
// Console.WriteLine($"Сумма отрицательных элкментов = {samNegativElem} ");


// Задача 32: 
// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] Intarray(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }
// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write(arr[i] + ",");
//         else Console.Write(arr[i]);
//     }
//     Console.WriteLine("]");
// }

// int[] Version(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] *= -1;
//     }
//     return arr;
// }

// int[] array = Intarray(8, -9, 9);
// PrintArray(array);
// int[] arrayM = Version(array);
// PrintArray(arrayM);

// Задача 33: 
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = IntArray(8, -2, 14);
// bool getNumberPoisk = NumberPoisk(array, number);
// if (getNumberPoisk)
// {
//     Console.WriteLine($"Число {number}, есть в массиве: ");
//     PrintArray(array);
// }
// else {
//     Console.WriteLine($"Число {number}, нет в массиве: ");
//     PrintArray(array);
// }

// int[] IntArray(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max);
//     }
//     return arr;
// }

// void PrintArray(int[] arr )
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(i < arr.Length -1) Console.Write(arr[i] + " ,");
//         else Console.Write(arr[i]);
//     }
//     Console.WriteLine("]");
// }

// bool NumberPoisk(int[] arr, int num)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//        if(arr[i] == num) 
//             return true;
//     }
//     return false;
// }

// Задача 35: 
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// int[] array =  IntArrey(123, -100, 100);
// PrintArray(array);
// int countElement = CountElement (array);
// Console.WriteLine($"\n-> {countElement}");


// int[] IntArrey(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max);
//     }
//     return arr;
// }

// void PrintArray(int[] arr){
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(i < arr.Length -1) Console.Write(arr[i] + ", ");
//         else Console.Write(arr[i]);
//     }
//     Console.Write(']');
// }

// int CountElement(int[] arr, int min = 10, int max = 99)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] >= min && arr[i] <= max) count++;

//     }
//     return count;
// } 


// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] IntArrey(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine(']');
}

int[] ResultArray(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 == 1) size = +1;
    int[] resArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i != arr.Length - 1 - i)
            resArr[i] = arr[i] * arr[arr.Length - 1 - i];
        else resArr[i] = arr[i];
    }
    return resArr;
}

int[] array = IntArrey(5, 1, 5);
PrintArray(array);
int[] arrayRes = ResultArray(array);
PrintArray(arrayRes);


