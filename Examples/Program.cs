/* Задайте значения M и N. Напишите программу, 
   которая выведет все натуральные числа в промежутке от M до N.*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число M: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int WriteNumber(int a, int b)
        {

            Console.Write(a + " ");
            if (a == b) return b;
            return WriteNumber(a + 1, b);
        }
        WriteNumber(a, b);

    }
}

/*Задайте значения M и N. Напишите программу, 
  которая найдёт сумму натуральных элементов в промежутке от M до N.*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число M: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int WriteNumber(int a, int b, int sum = 0)
        {

            sum += a;
            if (a == b) return sum;
            return WriteNumber(a + 1, b, sum);
        }
        Console.WriteLine($"Сумма элементов: " + WriteNumber(a, b));
    }
} 


/* Напишите программу вычисления функции Аккермана с помощью рекурсии.
   Даны два неотрицательных числа m и n.*/

Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
A(n, m);

static int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n, m);
}
Console.WriteLine($"Функция Аккермана: " + A(n, m));



