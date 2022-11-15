// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
int number2 = int.Parse(Console.ReadLine()!);   
 if(number1 > number2)
 {
    Console.WriteLine($"Число {number1} больше"); 
 }
if(number1 < number2)
{
    Console.WriteLine($"Число {number1} меньше");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
int number3 = int.Parse(Console.ReadLine()!);
Console.WriteLine(Math.Max(number1, Math.Max(number2, number3))); 
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(number % 2 == 0 ? "Да четное" : "Не четное");
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= number; i++)
if (i % 2 == 0) 
{
Console.Write(i + " ");
}
*/
