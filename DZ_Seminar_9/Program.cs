// Задача 1: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма элементов в промежутке от {M} до {N} = {PrintSumElement(M, N)}");

//-----------------------Метод и рекурсия---------------------------
int PrintSumElement(int M, int N)
{
    if(M == N) return M;
    return(M += PrintSumElement(M + 1, N));
}
*/

// Задача 2: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N, 1));

//---------------------------Метод и рекурсия--------------------------------
string PrintNumbers(int start, int end)
{
    if(end == start) return start.ToString();
    return(start + " " + PrintNumbers(start - 1, end));
}
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
/*
Console.Write("Введите неотрицательное число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите неотрицательное число n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Функция Аккермана = {Ackerman(m, n)}");

//---------------------Метод и рекурсия----------------------
int Ackerman(int m, int n)
{
    if(m == 0)return n +1;
    if(n == 0) return Ackerman(m - 1, 1 );
    return Ackerman(m - 1, Ackerman(m, n - 1));
}
// Функция Аккермана (m, n) определяется следующим образом: Ackermann(0, n) = n+1; Ackermann(m,0) = Ackermann(m-1,1); 
//Ackermann(m, n) = Ackermann(m-1, Ackermann(m, n-1)), m>0, n>0。 Рекурсивная реализация.
*/