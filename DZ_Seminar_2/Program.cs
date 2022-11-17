// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Обязательна проверка на ввод чисел больше/меньше 3-х знаков.

/*
Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine()!;
if(number.Length != 3)
{
    Console.WriteLine("Введино не верное число");
}
else
{
    Console.WriteLine($"Вторая цифра числа будет: {number[1]}");
}
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000


// int number = new Random().Next(100, 100001); // метод Random().Next(в скобках вводим случайные числа в нужном диапазоне, в данном случае от 100, до 1000)
// Console.WriteLine(number);
// //Console.WriteLine($"Число без второй цифры имеет вид: {number / 1000}{number % 10}"); // целочисленное деление {number / 100} и деление с остатком {number % 10}
// int result = (number / 1000 | number % 10); 
// Console.WriteLine($"Число без второй цифры имеет вид: {result}");


// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine()!;

// if(number) // проверяем длинну строковой переменной numbers,  != (неравно) 3
// {
//     Console.WriteLine("Введено не верное число"); 
// }
// else
// {
//     Console.WriteLine($"Третья цифра числа: {number[2]}"); // добавили индексы цифр введеного цисла [0] - 1 цифра, [2] - 3 цифра
// }

// {
    
    
    
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if(number < 99)
{
    Console.WriteLine("Нет третьей цифры");
}
if(number > 100)
{
    Console.WriteLine(number % 10);
}   




    
   




    // готовое решение
// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int MakeArray(int a, int b)
// {
//     int result = 0;
//     if (b < 3)
//     {
//         Console.WriteLine("Третьей цифры нет: ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }
//         result = (a / c) % 10;
//     }
// return result;    
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
// Обязательна проверка на ввод числа <1 и >7

// Вариант 1.

/*
Console.WriteLine("Введите число: "); 
int number = int.Parse(Console.ReadLine()!);
if(number < 1 || number > 7)
{
    Console.WriteLine("Неверное число, такого дня нет");
}
if (number == 1) Console.WriteLine("Понедельник рабочий день");
if (number == 2) Console.WriteLine("Вторник рабочий день");
if (number == 3) Console.WriteLine("Среда рабочий день");
if (number == 4) Console.WriteLine("Четверг рабочий день");
if (number == 5) Console.WriteLine("Пятница рабочий день");
if (number == 6) Console.WriteLine("Суббота выходной день");
if (number == 7) Console.WriteLine("Воскресенье выходной день");
*/

//  Вариант 2.

/*
Console.WriteLine("Введите число: "); 
int number = int.Parse(Console.ReadLine()!);
if(number < 1 || number > 7)
{
    Console.WriteLine("Неверное число, такого дня нет");
}
if(number <= 5 && number > 0)
{
    Console.WriteLine("Рабочий день");
}
if(number <= 7 && number > 5)
{
    Console.WriteLine("Выходной день");
}
*/