//Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


int TwoNumbers(int m, int n)
{
    if (m < 0 || n < 0)
    return -1;

    if (m == n)
    return m;

    if (m <= n)
    return (m + TwoNumbers(m + 1, n));

    else 
    return (n + TwoNumbers(m, n + 1));
    
}

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(TwoNumbers(m, n));
