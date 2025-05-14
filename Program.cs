//Вьюгова К.Д. Ам-1-24
//solve task2
using System;

public class Program
{
    // Функция возвращает квадрат переданного аргумента
    static public double Sqr(double x)
    {
        return x * x;
    }

    // Тестирование функции
    public static void Main()
    {
        Console.WriteLine("Квадрат числа 5 равен {0}", Sqr(5));
        Console.WriteLine("Квадрат числа -3 равен {0}", Sqr(-3));
        Console.WriteLine("Квадрат числа 0 равен {0}", Sqr(0));
        Console.WriteLine("Квадрат числа 7.8 равен {0}", Sqr(7.8));

        // Проверка с дробным числом
        double result = Sqr(Math.Sqrt(2));   // Квадратный корень из 2 возведём в квадрат — должно вернуть исходное число
        Console.WriteLine("Квадрат корня из двух равен примерно {0}, округление до целого даёт {1}",
                          result, Math.Round(result));
    }
}