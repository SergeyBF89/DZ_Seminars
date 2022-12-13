// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
int[,] array = FillArray(3, 4, 10, 100);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);

//-----------------------метод заполнения массива-----------------------------
int[,] FillArray(int size, int size2, int minValue, int maxValue)
{
    int[,] result = new int[size, size2];
    for(int i = 0; i < size; i++)
    {
        for(int j = 0; j < size2; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

//----------------------------метод печати массива--------------------------------
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//-------------------метод упорядочивания----------------------
void SortArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for(int n = 0; n < array.GetLength(1) - 1; n++)
            {
                if(array[i, n] < array[i, n + 1])
                {
                    int temp = 0;
                    temp = array[i, n];
                    array[i, n] = array[i, n + 1];
                    array[i, n + 1] = temp;
                }
                
            }
        }
    }
}
*/

// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int[,] array = FillArray(3, 4, 0, 10);
PrintArray(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементом = {SumMinRows(array)}");

//-----------------------метод заполнения массива-----------------------------
int[,] FillArray(int size, int size2, int minValue, int maxValue)
{
    int[,] result = new int[size, size2];
    for(int i = 0; i < size; i++)
    {
        for(int j = 0; j < size2; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

//----------------------------метод печати массива--------------------------------
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//---------------------------Метод суммы элементов строки---------------------------
int SumMinRows(int[,] array)
{
    int rows = 0;
    int minsum = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        minsum = minsum + array[0, i];
    }
    for(int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if(minsum > sum)
        {
            minsum = sum;
            rows = i;
        }
    }
    return rows;

}
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
Console.WriteLine("Введите кол-во строк первой матрицы: ");
int rowsA = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов первой матрицы: ");
int columnsA = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите кол-во строк второй матрицы: ");
int rowsB = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов второй матрицы: ");
int columnsB = Convert.ToInt32(Console.ReadLine()!);
if(columnsA != rowsB)
{
    Console.WriteLine("Такие матрицы умножать нельзя");
    return;
}

int[,] arrayA = FillArray(rowsA, columnsA, 0, 10);
int[,] arrayB = FillArray(rowsB, columnsB, 0, 10);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
PrintArray(GetMyltiplicationMatrix(arrayA, arrayB));

//-----------------------Метод заполнения массива--------------------------
int[,] FillArray(int r, int c, int minValue, int maxValue)
{
    int[,] result = new int[r, c];
    for(int i = 0; i < r; i++)
    {
        for(int j = 0; j < c; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

//-----------------------Метод печати массива--------------------------------
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//----------------------Метод произведения двух матриц----------------------------
int[,] GetMyltiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for(int i = 0; i < arrayA.GetLength(0); i++)
    {
        for(int j = 0; j < arrayB.GetLength(1); j++)
        {
            for(int n = 0; n < arrayA.GetLength(1); n++)
            {
                arrayC[i, j] += arrayA[i, n] * arrayB[n, j]; 
            }
        }
    }
    return arrayC;
}
*/