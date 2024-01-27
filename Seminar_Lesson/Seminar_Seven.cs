// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


// Проход по строкам(сначала идет повсей строке)
// int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
// {
//     int[,] matrix = new int[rows, colums];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {

//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }


// void PrintMaxrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4},");
//             else Console.Write($"{matrix[i, j], 4}  ");
//         }
//         Console.WriteLine("]");
//     }
// }

// int[,] array2D = CreateMatrixRndInt(3, 4, 1, 99);
// PrintMaxrix(array2D);


// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] CreateMatrixSumIndex(int rows, int colums)
// {
//     int[,] matrix = new int[rows, colums];


//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {

//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i + j;
//         }
//     }
//     return matrix;
// }

// void PrintMaxrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
//             else Console.Write($"{matrix[i, j],4}  ");
//         }
//         Console.WriteLine("]");
//     }
// }

// int[,] summIndex = CreateMatrixSumIndex(3, 4);
// PrintMaxrix(summIndex);

// Задача 49: 
// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2             
// 5 9 2 3
// 8 4 2 4


// int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
// {
//     int[,] matrix = new int[rows, colums];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {

//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// int[,] FindEven(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {

//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//            if(i % 2 == 0 && j % 2 == 0) matr[i, j] *= matr[i, j];
//         }
//     }
//     return matr;
// }


// void PrintMaxrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4},");
//             else Console.Write($"{matrix[i, j], 4}  ");
//         }
//         Console.WriteLine("]");
//     }
//     Console.WriteLine(" ");
// }

// int[,] array2D = CreateMatrixRndInt(3, 4, 1, 99);
// PrintMaxrix(array2D);
// int[,] findArray2D = FindEven(array2D);
// PrintMaxrix(findArray2D);

// Задача 51: 
// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
// {
//     int[,] matrix = new int[rows, colums];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {

//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// int FindSumDiagonaIndex(int[,] matr)
// {
//     int size = matr.GetLength(0);
//     if(size > matr.GetLength(1)) size = matr.GetLength(1);
//     int summ = 0;
//         for (int j = 0; j < size; j++)
//         {
//            summ += matr[j, j];
//         }
    
//     return summ;
// }


// void PrintMaxrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4},");
//             else Console.Write($"{matrix[i, j], 4}  ");
//         }
//         Console.WriteLine("]");
//     }
//     Console.WriteLine(" ");
// }

// int[,] array2D = CreateMatrixRndInt(3, 4, 1, 99);
// PrintMaxrix(array2D);
// int sumArray2D = FindSumDiagonaIndex(array2D);
// Console.WriteLine(sumArray2D);