//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string FindNumbers(int n)
{

    if (n <= 0){
        return $"{0}";
    }
    if (n == 1)
    {
        return $"{n}";
    }
    if (n > 1) return $"{n}  " + FindNumbers(n - 1);
    else return string.Empty;
        
}

int EnterNumber()
{
Console.WriteLine("Введите число:  ");
int.TryParse(Console.ReadLine(), out int result);
return result;
}

int num = EnterNumber();
Console.WriteLine(FindNumbers(num));










