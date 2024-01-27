// Задача 53: 
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


// int[,] matriz = CreateMatrixRndInt(5, 5, 1, 10);
// PrintMaxrix(matriz);
// ChainFirstAndLastRow(matriz);
// Console.WriteLine(" ");
// PrintMaxrix(matriz);

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
//     Console.WriteLine(" ");
// }


// void ChainFirstAndLastRow(int[,] mateixChein)
// {
//     int firstRow = 0;
//     int lastRow = mateixChein.GetLength(0)-1;
//     for (int i = 0; i < mateixChein.GetLength(1); i++)
//     {
//         int temp = mateixChein[firstRow, i];
//          mateixChein[firstRow, i] = mateixChein[lastRow, i];
//         mateixChein[lastRow, i] = temp;
//     }
// }

// Задача 55: 
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

// int matrixRows = 5;
// int matrixColums = 5;
// int matrixMin = 1;
// int matrixMax = 9;

// int[,] matrixFirst = CreateMatrixRndInt(matrixRows, matrixColums, matrixMin, matrixMax);
// PrintMaxrix(matrixFirst);
// if (matrixRows == matrixColums)
// {
//     Console.WriteLine(string.Empty);
        // Вызов с первого вварианта
    //int[,] matrixResult = ChangeRowColumsMatrix(matrixFirst);
    // PrintMaxrix(matrixResult);

    //  Вызов для втрого варинта
//     ChangeRowColumsMatrix(matrixFirst);
//     PrintMaxrix(matrixFirst);
// }
// else Console.WriteLine("Количсетво стобцов не равно количеству строк");

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
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
//             else Console.Write($"{matrix[i, j],4}  ");
//         }
//         Console.WriteLine("]");
//     }
//     Console.WriteLine(" ");
// }


//     Первый варинт Рещения с новым массивом
// int[,] ChangeRowColumsMatrix(int[,] matrix)
// {
//     int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             newMatrix[i, j] = matrix[j, i];
//         }
//     }
//     return newMatrix;
// }


// Второй варинт С заменой уже имеющегося массива


// void ChangeRowColumsMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0) -1; i++)
//     {
//         for (int j = i+1; j < matrix.GetLength(1); j++)
//         {
//             int temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }
// }

// Задача 57: 
// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
// PrintMaxrix(array2D);
// Console.WriteLine();
// int[] array = MatrixToArrray(array2D);
// PrintArray(array);
// Array.Sort(array);
// Console.WriteLine();
// PrintArray(array);
// Console.WriteLine();
// Dictionari(array);

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
//     Console.WriteLine(" ");
// }

// int[] MatrixToArrray (int[,] matrix)
// {
//     int[] array = new int[matrix.Length];
//     int k = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             array[k] = matrix[i, j];
//             k++;
//         }
//     }
//     return array;
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


// void Dictionari(int[] arr)
// {
//     int number = arr[0];
//     int count = 1;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] == number) count++;
//         else{
//             Console.WriteLine($"{number} -> {count}");
//             number = arr[i];
//             count = 1;
//         }
//     }
//     Console.WriteLine($"{number} -> {count}");
// }

// Задача 59: 
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
PrintMaxrix(array2D);
int[] indexMinVal = IndexMinVal(array2D);
PrintArray(indexMinVal);

Console.WriteLine("");

int[,] rowCroum = RemoveRowCroum(array2D, indexMinVal[0], indexMinVal[1]);
PrintMaxrix(rowCroum);


int[] IndexMinVal(int[,] matrix)
{
    int min = matrix[0,0];
    int indexRow = 0;
    int indexColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] < min) 
            {
                min = matrix[i, j];
                indexRow = i;
                indexColumn = j;
            }
        }
    }
    return new int[] {indexRow, indexColumn, min};
}

int[,] RemoveRowCroum(int[,] matrix, int removeRow, int removeCroum)
{
    int[,] newMatrix = new int[matrix.GetLength(0) -1,matrix.GetLength(1) -1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i == removeRow) m++;
        for (int j = 0; j < newMatrix.GetLength(1 ); j++)
        {
            if(j == removeCroum) n++;
            newMatrix[i,j] =  matrix[m,n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMaxrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4},");
            else Console.Write($"{matrix[i, j], 4}  ");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine(" ");
}

void PrintArray(int[] arr){
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write(']');
}