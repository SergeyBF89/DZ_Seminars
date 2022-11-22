// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
//int[] mas = {3, 6, 8, 2, 1, -7};
int[] mas = {7, -5, 0, 1, -1, 9};
double masD = Math.Sqrt(Math.Pow(mas[0] - mas[3], 2) + Math.Pow(mas[1]- mas[4], 2) + Math.Pow(mas[2] - mas[5], 2));
Console.WriteLine($"{masD:f2}");
*/

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int i = 1;
if(number < 0)
{
    number = -number;
    Console.WriteLine("Отрицательное число преобразованно в положительное");
}
for(i = 1; i <= number; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}
*/

// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine()!;
int len = number.Length;
if(number.Length == 5)
{
    if(number[0] == number[4] && number[1] == number[3])
    {
       Console.WriteLine("Палиндром"); 
    }
    else
    {
       Console.WriteLine("Не палиндром"); 
    }
}
else
{
    Console.WriteLine("Не является пятизначным числом");
}
*/

    



