// Задача 38: Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементов массива.
/*
int[] array = GetArray(8, -10, 10);
Console.WriteLine($"[{string.Join(", ", array)}]");
int min = 0;
int max = 0;
foreach(int i in array)
{
    if(min > i) min = i;
    if(max < i) max = i;
}
Console.WriteLine($"разница между максимальным элементом {max} и минимальным элементом {min} = {max - min}");
//---------------method--------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
*/

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] array = GetArray(6, 100, 1000);
Console.WriteLine($"[{string.Join(", ", array)}]");
int count = 0;
//=====вариант 1 через цикл for

// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] % 2 ==0)
//     count ++;
// }

//====вариант 2 через цикл foreach

foreach(int el in array)
{
    if(el % 2 == 0)
    count++;
}
Console.WriteLine($"кол-во четных чисел в массиве = {count}");
//--------------method-------------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).
// [3, 7, 23, 12] -> 19       [-4, -6, 89, 6] -> 0
/*
int[] array = GetArray(10, -100, 100);
Console.WriteLine($"[{string.Join(", ", array)}]");
int sum = 0;
for(int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}
Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");
//---------------method--------------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
*/

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3       [6 7 3 6] -> 36 21
//--------------------- через цикл for -----------------
/*
int[] array = GetArray(5, 1, 10);
Console.WriteLine($"[{string.Join(", ", array)}]");
int[] arr = new int[array.Length / 2];

for (int i = 0; i < array.Length / 2; i++)
{
    arr[i] = array[i] * array[array.Length - i - 1];

}

Console.WriteLine($"[{string.Join(", ", arr)}]");
//------------------method------------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}
*/
//--------------- через цикл while ---------------
/*
int[] array = GetArray(5, 1, 10);
Console.WriteLine($"[{string.Join(", ", array)}]");

int[] arr = new int[array.Length / 2];

int first = 0;
int last = array.Length - 1;
int index = 0;

while(last > first)
{
    arr[index] = array[first] * array[last];
    first ++;
    last --;
    index ++;
}
Console.WriteLine($"[{string.Join(", ", arr)}]");

//------------------method------------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}
*/

