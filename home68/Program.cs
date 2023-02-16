//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


int FAckermans(int m, int n)
{
    int res = 0;
if (m == 0)
res = n + 1;
if (m > 0 && n ==0)
res = FAckermans(m - 1, 1);
if (m > 0 && n > 0)
{
   res = FAckermans(m - 1, FAckermans(m, n -1)); 

}
return res;
}



Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FAckermans(m, n));
