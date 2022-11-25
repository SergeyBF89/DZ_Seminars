// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11     // 82 -> 10    // 9012 -> 12
/*
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {number} равна {GetSum(number)}");
//---------------метод---------------------

int GetSum(int num)
{
    int sum = 0, N;
    while(num != 0)
    {
        N = num % 10;
        num = num / 10;
        sum = sum + N;
    } 
    return sum;
} 
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)
/*
int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(", ",array)}]");
//--------------метод---------------------
int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(10, 101);
    }
    return result;
}
*/

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)
// 3, 5 -> 243 (3⁵)      // 2, 4 -> 16
/*
Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {numberA} в натуральной степени числа {numberB} = {GetMultiply(numberA, numberB)}");
//-------------метод----------------------
int GetMultiply(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}    
*/          





