// Задача 39: 
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
//         else Console.Write(arr[i]);
//     }
//     Console.WriteLine(']');
// }


// // Array.Reverse(array)

// void ArrayReverse (int[] arr)
// {
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         int temp = arr[i];
//         arr[i] = arr[arr.Length -1 -i];
//         arr[arr.Length -1 -i] = temp;

//     }
// }

// int[] array = IntArrey(5, 1, 10);
// PrintArray(array);
// ArrayReverse(array);
// PrintArray(array);
// Array.Reverse(array);
// PrintArray(array);


// Задача 40: 
// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите треть число");
// int number3 = Convert.ToInt32(Console.ReadLine());

// bool result = IsExist(number1, number2, number3);
// Console.WriteLine(result ? "Такой треугольник сушествует" : "Такой треугольник не сушетсвует");

// bool IsExist (int num1, int num2, int num3)
// {
//     int sum1 = num1 + num2;
//     int sum2 = num1 + num3;
//     int sum3 = num2 + num3;
//     return sum1 > num3 && sum2 > num2 && sum3 > num1; 
// }

// bool max = IsExist(number1, number2, number3);
// if (max == true){
//     Console.WriteLine("Yes");
// }
// else{
//      Console.WriteLine("No");
// }

// Задача 42:
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());

// string res = ConvertBi(45);
// Console.WriteLine(res);

// string ConvertBi(int num)
// {
//     string result = string.Empty;
//     while (num > 0)
//     {
//         result = num % 2 + result;
//         num = num / 2;

//     }
//     return result;
// }

// Задача 44: 
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] res = FibonachiArrray(number);
// PrintArray(res);


// int[] FibonachiArrray(int size)
// {
//     int[] result = new int[size];
//     result[1] = 1;
//     for (int i = 2; i < result.Length; i++)
//     {
//         result[i] = result[i - 1] + result[i - 2];
//     }
//     return result;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
//         else Console.Write(arr[i]);
//     }
//     Console.WriteLine(']');
// }

// Задача 45: 
// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

// int[] arrayy = IntArrey(5, 1, 10);
// PrintArray(arrayy);
// int[] arrayCopy = ArrCopy(arrayy);
// PrintArray(arrayCopy);


// int[] ArrCopy(int[] arr)
// {
//     int[] result = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         result[i] = arr[i];
//     }
//     return result; 
// }

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

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
//         else Console.Write(arr[i]);
//     }
//     Console.WriteLine(']');
// }



// Console.WriteLine("Введите размерность массива:");
// int i, n = Convert.ToInt32(Console.ReadLine());
// int[] mas = new int[n];

// Console.WriteLine("Введите массив через пробел:");
// string[] str = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

// for (i = 0; i < (n < str.Length ? n : str.Length); ++i)
// mas[i] = Convert.ToInt32(str[i]);

// PrintArray(mas);
// Console.Write($" -> {Positive(mas)}");


// int Positive(int[] arr)
// {
//     int result = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] > 0) result++;
//     }
//     return result;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
//         else Console.Write(arr[i]);
//     }
//     Console.Write(']');
// }