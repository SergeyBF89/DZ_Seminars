// Задача 1: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. (третья задача из дз к семинару 7)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
Console.WriteLine($"Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10); 
PrintArray(array);
Console.WriteLine();
GetAverageColumns(array);

//----------------метод заполнения двумерного массива----------------
int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++) 
    {
        for(int j = 0; j < n; j++) 
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1); 
        }
    }
    return result;
}
//---------------метод печати двумерного массива-----------------
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        Console.Write("[");
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("]");
    }
}
//----------------------Метод среднего арефмитического в каждом столбце------------------------------
void GetAverageColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
   {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{sum / array.GetLength(0):f2}; ");
    }
}        
*/

// Задача 2: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
Console.WriteLine("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = new double[rows, columns];
FillArrayRandomNum(array);
PrintArray(array);

//------------------метод заполнения двумерного массива--------------------
void FillArrayRandomNum(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-10, 11)) / 10;
        }
    }
}

//----------------метод печати массива-----------------
void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}; ");
        }
        Console.WriteLine("]");
    }
}
*/

//Задача 3: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 5; j = 2 -> такого числа в массиве нет
// i = 1; j = 1 -> 9
/*
Console.WriteLine("Введите индекс строки: ");
int rowsI = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите индекс столбца: ");
int columnsI = int.Parse(Console.ReadLine()!);

int[,] array = new int[5, 6];
FillArray(array);
PrintArray(array);

if(rowsI < array.GetLength(0) && columnsI < array.GetLength(1))
{
    Console.WriteLine($"{array[rowsI, columnsI]}");
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}

//-----------------------метод заполнения массива--------------
void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
}

//----------------метод печати массива----------------------
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("]");
    }
}
*/