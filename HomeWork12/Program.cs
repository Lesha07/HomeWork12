using System;
public static class FibonachiCalculator
{
    public static int TryGetFibonachi(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Порядковий номер не може бути від'ємним.");
        }

        if (n == 0) return 0;
        if (n == 1) return 1;

        return TryGetFibonachi(n - 1) + TryGetFibonachi(n - 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть номер числа Фібоначчі:");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int n))
        {
            try
            {
                int result = FibonachiCalculator.TryGetFibonachi(n);

                Console.WriteLine($"Число Фібоначчі для {n} = {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Введіть правильне ціле число. Спробуйте ще раз!");
        }
    }
}
