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

/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (ThirdDigit(number) == -1)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третья цифра числа будет: {ThirdDigit(number)}");
int ThirdDigit(int number)
{
int result = -1;
if (number >= 100)
{
    while (number > 999)
    {
        number = number / 10;
    }
    result = number % 10;
}
    return result; 
}
*/ 
   
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