// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
/*
int[] array = More0(5, -1000, 1000);
Console.WriteLine($"[{string.Join(", ", array)}]");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Чисел больше 0 = {count}");
//-------------метод--------------------
int[] More0(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
*/

// Задача 2: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, 
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).
/*
int[] array = GetArray(8, 0, 100);
Console.WriteLine($"[{string.Join(", ", array)}]");
int tmp = 0;
for(int i = 0; i < array.Length; i++)
for(int j = i; j < array.Length; j++)
if (array[i] > array[j])
{
    tmp = array[j];
    array[j] = array[i];
    array[i] = tmp;
}
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", array)}]");

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
*/

